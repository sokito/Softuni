using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string inputReversed = string.Join("", input.Reverse());
        Console.WriteLine(inputReversed);
    }
}
