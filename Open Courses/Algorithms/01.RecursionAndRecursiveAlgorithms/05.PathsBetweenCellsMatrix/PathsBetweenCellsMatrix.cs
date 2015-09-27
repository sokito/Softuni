using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class PathsBetweenCellsMatrix
{
    /*s			
	    **	
	    **	
	    *e	
			
    */
    static char[,] mazeMatrix = new char[5, 4] {{'s',' ',' ',' '},
                                                {' ','*','*',' '},
                                                {' ','*','*',' '},
                                                {' ','*','e',' '},
                                                {' ',' ',' ',' '}
                                                };
    static List<char> path = new List<char>();
    static int countPaths = 0;
    static void Main(string[] args)
    {
        
        int indexRows = 0;
        int indexCols = 0;
        getPaths(indexRows, indexCols, 's');
        Console.WriteLine("Total paths found: {0}",countPaths);

    }
    static void getPaths(int row, int col, char direction)
    {
        
        if (row < 0 || row == mazeMatrix.GetLength(0) ||
            col < 0 || col == mazeMatrix.GetLength(1) )
        {
            //out of the labirinth
            return;
        }

        // add the current direction
        path.Add(direction);

        // Check if we have found the exit
        if (mazeMatrix[row, col] == 'e')
        {
            countPaths++;
            PrintPath(path);
        }

        if (mazeMatrix[row, col] == ' ' || mazeMatrix[row,col] == 's')
        {
            // mark the current cell with the char of the direction
            mazeMatrix[row, col] = '.';

            // explore all the directions with recursion
            
            getPaths(row, col + 1, 'R'); // right
            getPaths(row + 1, col, 'D'); // down
            getPaths(row, col - 1, 'L'); // left
            getPaths(row - 1, col, 'U'); // up

            // remove the char from the current cell
            mazeMatrix[row, col] = ' ';
        }

        // Remove the last direction from the path
        path.RemoveAt(path.Count - 1);
    }
   
    static void PrintPath(List<char> path)
    {
        Console.Write("Found path to the exit: ");
        foreach (var c in path)
        {
            Console.Write(c);
        }
        Console.WriteLine();
    }
}

