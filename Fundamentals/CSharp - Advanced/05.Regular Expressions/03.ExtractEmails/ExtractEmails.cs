using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ExtractEmails
{
    static void Main(string[] args)
    {
        string searchPattern = @"(?<email>(?<user>[a-zA-Z0-9\.\-_]+)@(?<host>(?:[a-zA-Z]+\-?[a-z]+\.)+[a-z]+))";
        string text = Console.ReadLine();
        Regex myReg = new Regex(searchPattern);
        MatchCollection matches = myReg.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[0]);
        }
    }
}
