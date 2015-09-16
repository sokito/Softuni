using System;
using System.Collections.Generic;
using System.Linq;
class LegoBlocks
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine()); //number of rows in both jagged arrays
        int[][] firstJaggedArray = new int[rows][];
        int[][] secondJaggedArray = new int[rows][];
        bool fitting = true;
        //get the first jagged array
        for (int i = 0; i < rows; i++) 
        {
            firstJaggedArray[i] = Console.ReadLine().Trim()
                .Split(' ').Select(int.Parse).ToArray();
            
        }
        //get the second jagged array
        for (int z = 0; z < rows; z++)
        {
            secondJaggedArray[z] = Console.ReadLine().Trim()
                .Split(' ').Select(int.Parse).ToArray();
            
        }
        int matrixLength = firstJaggedArray[0].Length + secondJaggedArray[0].Length;
        for (int x = 1; x < rows; x++)
        {
            if(firstJaggedArray[x].Length + secondJaggedArray[x].Length
                !=matrixLength ) // if the arrays don't fit
            {
                fitting = false;
            }
        }
        if (fitting) //if it fits, display the new matrix
        {
            for (int w = 0; w < rows; w++)
            {
                Array.Reverse(secondJaggedArray[w]);
                Console.WriteLine("[{0}, {1}]",
                    string.Join(", ", firstJaggedArray[w]),
                    string.Join(", ", secondJaggedArray[w]));
            }
        }
        else //if not , print the number of cells
        {
            int totalNumberOfCells = 0;
            for (int y = 0; y < rows; y++)
            {
                totalNumberOfCells += firstJaggedArray[y].Count() + secondJaggedArray[y].Count();
            }
            Console.WriteLine("The total number of cells is: {0}",totalNumberOfCells);
        }
    }
}