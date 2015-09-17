using System;
using System.Collections.Generic;
using System.Linq;
class SequenceInMatrix
{
    static void Main(string[] args)
    {
        //get the size of the array
        int[] inputSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = inputSize[0];
        int cols = inputSize[1];
        string[,] matrix = new string[rows, cols];
        // get the input matrix
        for (int row = 0; row < rows; row++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }
        string longestSequenceString = matrix[0,0];
        int countMax = 0;
        int currentCount = 0;

        //check the rows
        for (int r = 0; r < rows; r++)
        {
            
            for (int c = 0; c < cols - 1; c++)
            {
                if (matrix[r, c] == matrix[r, c + 1])
                {
                    currentCount++;
                }
                else //end of sequence
                {
                    currentCount = 1;
                }
                if (currentCount > countMax)
                {
                    longestSequenceString = matrix[r, c];
                    countMax = currentCount;
                }  
            }
            currentCount = 1; 
        }

        //check the columns
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > countMax)
                {
                    longestSequenceString = matrix[row, col];
                    countMax = currentCount;
                }
            }
            currentCount = 1;
        }
        //check diagonal
        for (int row = 0, col = 0; row < rows - 1 && col < cols -1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > countMax)
            {
                countMax = currentCount;
                longestSequenceString = matrix[row, col];
            }
        }
        currentCount = 1;

        string output = "";
        for (int w = 0; w < countMax; w++)
        {
            output += longestSequenceString + ", ";
        }
        output = output.TrimEnd(' ').TrimEnd(',');
        Console.WriteLine(output);
    }
}

