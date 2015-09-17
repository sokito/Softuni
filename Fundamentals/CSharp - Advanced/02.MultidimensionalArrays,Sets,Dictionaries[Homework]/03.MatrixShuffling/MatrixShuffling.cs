using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixShuffling
{
    static void Main(string[] args)
    {
        
        //get the size of the array
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        // get the input matrix
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        string command = Console.ReadLine();
        while(command != "END")
        {
            if(IsValid(command,rows,cols))
            {
                //invoke SWAP method
                matrix = Swap(matrix,command);
                //invoke the print method
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            command = Console.ReadLine();
        }
    }
    //method for swapping the values;
    private static string[,] Swap(string[,] matrix, string command)
    {
        string[] commandArray = command.Split(' ');
        int x1 = int.Parse(commandArray[1]);
        int y1 = int.Parse(commandArray[2]);
        int x2 = int.Parse(commandArray[3]);
        int y2 = int.Parse(commandArray[4]);
        string temp = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = temp;
        return matrix;
    }
    //method to check if the input is valid
    public static bool IsValid(string command,int rowsMax, int colsMax)
    {
        int[] indexes = new int[4];
        string[] commandArray = command.Split(' ');
        if (commandArray.Length != 5 && commandArray[0] == "swap")
        {
            return false; //not valid
        }
        for (int i = 0; i < commandArray.Length - 1; i++)
        //check if the cordinates are in the correct format and valid
        {
            if (int.TryParse(commandArray[i + 1], out indexes[i]) && indexes[i] >= 0)
                //if the value can be parsed to an int and is bigger than zero
            {
                if(i%2 ==0 && indexes[i] < rowsMax || // x cordinates
                    i%2 == 1 && indexes[i] < colsMax ) // y cordinates 
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else //value can not be parsed to an int
            {
                return false;
            }
        }
        return true;
    }
    //method for printing the matrix
    public static void PrintMatrix(string[,] matrix)
    {
        string output;
        for (int row= 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                output = matrix[row, col];
                Console.Write("{0} ",output);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

