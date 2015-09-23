using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    //Write a program that converts a string to a sequence of C# Unicode character literals. 
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        foreach (var symbol in inputText)
        {
            Console.Write(String.Format(@"\u{0:x4}", (ushort)symbol));
        }
    }
}
