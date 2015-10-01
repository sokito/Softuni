using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string searchPattern = @"(?<startingLetters>[a-z])\1*";
        string text = "aaaaabbbbbcdddeeeedssaa";
        Regex reg = new Regex(searchPattern);
        MatchCollection matches = reg.Matches(text);
        foreach (var match in matches)
        {
            Console.Write(match.ToString()[0]);
        }
        Console.WriteLine();
    }
}
