using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(number);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double num)
    {
        string reversedStr = new string(num.ToString().Reverse().ToArray());
        double reversedDouble = double.Parse(reversedStr);
        return reversedDouble;

    }
}
