using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TextFilter
{
    /* Write a program that takes a text and a string of banned words. All
     * words included in the ban list should be replaced with asterisks "*", equal to 
     * the word's length. The entries in the ban list will be separated by a comma and space ", ".
     * The ban list should be entered on the first input line and the text on the second input line. Example:
     */

    static void Main(string[] args)
    {
        //get list of banned words
        List<string> bannedWords = Console.ReadLine().Split(new [] {' ', ',' },
                                StringSplitOptions.RemoveEmptyEntries).ToList<string>();
        string text = Console.ReadLine();
        foreach (var word in bannedWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(text);
    }
}
