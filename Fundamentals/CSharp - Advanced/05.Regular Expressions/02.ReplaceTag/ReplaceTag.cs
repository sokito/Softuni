using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ReplaceTag
{
    static void Main(string[] args)
    {
        string text = "<ul><li><a href=\"http://softuni.bg\">SoftUni</a></li></ul>";
        string searchPattern = "<a href=([\",'])(?<link>[a-zA-Z:/.]+\\1)>(?<name>[a-zA-Z]+)</a>" ;
        Regex myReg = new Regex(searchPattern);
        MatchCollection matches = myReg.Matches(text);
        foreach (Match match in matches)
        {
            string newLink = string.Format("[URL href={0}]{1}[/URL]",match.Groups["link"],match.Groups["name"]);
            text = text.Replace(match.Groups[0].ToString(),newLink);
        }
        Console.WriteLine(text);
    }
}
