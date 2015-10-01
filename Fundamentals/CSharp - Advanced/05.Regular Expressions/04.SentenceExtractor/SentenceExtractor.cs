using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class SentenceExtractor
{
    static void Main(string[] args)
    {
        string searchWord = Console.ReadLine();
        string text = Console.ReadLine();
        string sentenceSearchPattern = "([^.!?]+[.!?])";
        string wordSearch = string.Format(@"\b{0}\b", searchWord);
        Regex sentenceSearcher = new Regex(sentenceSearchPattern);
        Regex wordSearcher = new Regex(wordSearch);
        MatchCollection sentences = sentenceSearcher.Matches(text);
        foreach (Match sentence in sentences )
        {
            if(wordSearcher.IsMatch(sentence.ToString()))
            {
                Console.WriteLine(sentence.ToString());
            }
        }
    }
}
