using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class MatchFullName
{
    static void Main(string[] args)
    {
        /* Write a regular expression to match a valid full name. A valid full name consists 
         * of two words, each word starts with a capital letter and contains only lowercase
         * letters afterwards; each word should be at least two letters long; the two words
         * should be separated by a single space.[EXERCISE]
         */ 
        string text = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov,Ivan Ivanov";
        string searchPattern = @"(\b[A-Z][a-z]{1,})(?: )(\b[A-Z][a-z]{1,}\b)";
        Regex myRegex = new Regex(searchPattern);
        Console.WriteLine(myRegex.Matches(text));

    }
}