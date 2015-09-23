using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StringLength
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string inputCut = input.Remove(20);
        Console.WriteLine(inputCut.PadRight(20, '*'));
    }
}
