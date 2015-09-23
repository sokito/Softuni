using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountSubstringAppearance
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        string searchWord = Console.ReadLine();
        int countMatches = CountMatches(inputText, searchWord);
        Console.WriteLine(countMatches);
    }
    static int CountMatches(string text, string searchWord)
    {
        int countMatches = 0;
        string wordAtIndex = string.Empty;
        for (int textIndex = 0; textIndex <= text.Length - searchWord.Length; textIndex++)
        {
            wordAtIndex = text.Substring(textIndex, searchWord.Length);
            if(wordAtIndex.ToLower() == searchWord.ToLower()) // check for match , case - insensitive
            {
                countMatches++;
            }
            else
            {
                continue;
            }
        }
        return countMatches;
    }
}