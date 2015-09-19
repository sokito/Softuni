using System;
using System.Collections.Generic;
using System.Linq;
class BiggerNumber
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int maxNum = GetMax(firstNumber, secondNumber);
        Console.WriteLine(maxNum);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        if(firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
