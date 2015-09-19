using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            //get input matrix
            string[] command = Console.ReadLine().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            int degrees = int.Parse(command[1]) % 360;
            List<string> inputLines = new List<string>();
            while(input != "end" &&  input != "END")
            {
                inputLines.Add(input);
                input = Console.ReadLine();
            }
            //get max length of the elements which is the cols
            int rows = inputLines.Count();
            int cols = 0;
            foreach (var lines in inputLines)
	        {
		        if( cols < lines.Length)
                {
                    cols = lines.Length;
                }
	        }
            char [,] matrix = new char[rows,cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if(c < inputLines[r].Length) //get the char
                    {
                        matrix[r,c] = inputLines[r][c];
                    }
                    else // pad with space
                    {
                        matrix[r, c] = ' ';
                    }
                }
            }
            switch (degrees)
            {
                case 0: DisplayMatrix(matrix); break;
                case 90: DisplayMatrix(Rotate90(matrix)); break;
                case 180: DisplayMatrix(Rotate90(Rotate90(matrix))); break; 
                //invoke the 90 degrees rotation matrix TWICE
                case 270: DisplayMatrix(Rotate90(Rotate90(Rotate90(matrix)))); break; 
                //invoke the 90 degrees rotation matrix three times
            }
        }

        private static void DisplayMatrix(char[,] matrix)
        {
            //display matrix
            int rotRows = matrix.GetLength(0);
            int rotCols = matrix.GetLength(1);
            for (int m = 0; m < rotRows; m++)
            {
                for (int n = 0; n < rotCols; n++)
                {
                    Console.Write(matrix[m, n]);
                }
                Console.WriteLine();
            }
        }

        private static char[,] Rotate90(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            char[,] rotatedMatrix = new char[cols,rows];
            for (int c = 0; c < cols; c++)
            {
                for (int r = rows - 1; r >= 0; r--)
                {
                    rotatedMatrix [c,rows - r - 1] = matrix[r,c];
                }
            }
            return rotatedMatrix;
        }
    }
}
