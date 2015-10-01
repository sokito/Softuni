using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class MatchPhoneNumber
{
    static void Main(string[] args)
    {
        //[EXERCISE]
        string searchPattern = @"(?<numberDashes>\ ?\+359-2-[0-9]{3}-[0-9]{4}\b)|"
        + @"(?<numberrSpaces>\ ?\+359 2 [0-9]{3} [0-9]{4}\b)";
        string text = @"359-2-222-2222, +359/2/222/2222, +359-2 222 2222
                        +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222
                        +359 2 222 2222 ";
        Regex myRegex = new Regex(searchPattern);
        MatchCollection matches = myRegex.Matches(text);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
