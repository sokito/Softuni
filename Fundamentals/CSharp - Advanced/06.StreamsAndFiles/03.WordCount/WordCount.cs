using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class WordCount
{
    static void Main(string[] args)
    {
        var wordCountDictionary = new Dictionary<string,int>();
        StreamReader textReader = new StreamReader("../../text.txt");
        StreamReader wordsReader = new StreamReader("../../words.txt");
        StreamWriter resultWriter = new StreamWriter("../../result.txt");
        int countMatches = 0;
        using (textReader)
        {
            using (wordsReader)
            {
                using (resultWriter)
                {
                    string text = textReader.ReadToEnd().ToLower();
                    while(true)
                    {
                        string word = wordsReader.ReadLine();
                        if(word == null)
                        {
                            break;
                        }
                        string searchPattern = string.Format(@"\b{0}\b", word);
                        Regex wordSearcher = new Regex(searchPattern);
                        countMatches = wordSearcher.Matches(text).Count;
                        
                        // add count and word to Dictionary
                        wordCountDictionary.Add(word,countMatches);
                    }
                    
                    //sort dictionary by keys
                    var list = wordCountDictionary.Values.ToList();
                    list.Sort();

                    //write to results.txt
                    foreach (KeyValuePair<string, int> item in wordCountDictionary.OrderByDescending(value => value.Value))
                    {
                        resultWriter.WriteLine("{0} - {1}", item.Key, item.Value);
                    }
                }
            }
        }
    }
}
