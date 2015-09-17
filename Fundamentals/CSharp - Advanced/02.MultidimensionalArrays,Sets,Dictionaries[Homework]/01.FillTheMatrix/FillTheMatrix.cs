using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine()); // get the size of the matrix
            int[,] patternAmatrix = new int[n, n];
            int[,] patternBmatrix = new int[n,n];

            for (int row = 0; row < patternAmatrix.GetLength(0); row++) 
                                // patternAmatrix.GetLength(0) = n; 
            {
                for (int col = 0; col < patternAmatrix.GetLength(1); col++)
                {
                    patternAmatrix[row, col] = n * col + row + 1;
                    if (col % 2 == 0)
                    {
                        patternBmatrix[row, col] = n * col + row + 1;
                    }
                    else
                    {
                        patternBmatrix[row,col] = n * (col+1) - row;
                    }
                }
            }
            //display the matrices
            string output;
            //pattern A matrix
            for (int rowA= 0; rowA < n; rowA++)
            {
                for (int colA = 0; colA < n; colA++)
                {
                    output = patternAmatrix[rowA, colA].ToString().PadLeft(2, ' ');
                    Console.Write("{0} ",output);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //pattern B matrix
            for (int rowB = 0; rowB < n; rowB++)
            {
                for (int colB = 0; colB < n; colB++)
                {
                    output = patternBmatrix[rowB, colB].ToString().PadLeft(2, ' ');
                    Console.Write("{0} ", output);
                }
                Console.WriteLine();
            }
        }
    }
}
