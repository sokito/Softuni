using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        /*Write a program that extracts from a given text all palindromes,
         * e.g. ABBA, lamal, exe and prints them on the console on a single line,
         * separated by comma and space. Use spaces, commas, dots, question marks
         * and exclamation marks as word delimiters. Print only unique palindromes,
         * sorted lexicographically.
        */
        string[] inputWords = Console.ReadLine().Split(new char[] { ' ', '!', '?', '.', ',' },
                            StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> sortedInputWords = new SortedSet<string>();
        foreach (var word in inputWords)
        {
            if(IsPalindrome(word))
            {
                sortedInputWords.Add(word);
            }
        }
        Console.WriteLine(string.Join(", ",sortedInputWords ));
    }

    private static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2 ; i++) 
            //check n/2 or (n+1)/2 elements
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
            else
            {
                continue;
            }
        }
        return true;
    }
}
