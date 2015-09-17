using System;
using System.Collections.Generic;
using System.Linq;
class MaximumSum
{
    static void Main(string[] args)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int rowIndexMaxSum = 0;
        int colIndexMaxSum = 0;
        //get the size of the array
        int[] inputSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = inputSize[0];
        int cols = inputSize[1];
        int[,] matrix = new int [rows,cols];
        // get the input matrix
        for (int row = 0; row < rows; row++)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
			{
                matrix[row, col] = input[col];
			} 
        }
        for (int r = 0; r < rows -2; r++)
		{
			for (int c = 0; c < cols -2; c++)
			{
			    currentSum = CalcSum(r,c,matrix);
                if (currentSum >= maxSum)
                {
                    maxSum = currentSum;
                    rowIndexMaxSum = r;
                    colIndexMaxSum = c;
                }
			}
		}
        Console.WriteLine("Sum = {0}",maxSum);

        //display matrix 3x3 with max Sum
        for (int rowAdd = 0; rowAdd <= 2; rowAdd++)
        {
            for (int colAdd = 0; colAdd <= 2; colAdd++)
            {
                string output = matrix[rowIndexMaxSum + rowAdd,colIndexMaxSum + colAdd].ToString().PadLeft(2, ' ');
                Console.Write("{0} ", output);
            }
            Console.WriteLine();
        }
        
    }

    private static int CalcSum(int r,int c,int[,] matrix)
    {
        int sum = 0;
        for (int m = 0; m <= 2; m++)
        {
            for (int n = 0; n <= 2; n++)
            {
                sum += matrix[r + m, c + n];
            }
        }
        return sum;
    }
}
