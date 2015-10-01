using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*You are part of the back-end development team of the next Facebook.
 * You are given a line of usernames, between one of the following symbols:
 * space, “/”, “\”, “(“, “)”. First you have to export all valid usernames.
 * A valid username starts with a letter and can contain only letters, digits
 * and “_”. It cannot be less than 3 or more than 25 symbols long. Your task 
 * is to sum the length of every 2 consecutive valid usernames and print on the 
 * console the 2 valid usernames with biggest sum of their lengths, each on a separate line. 
 */
class ValidUsernames
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string passwordCheck = @"((?<=[\s\/\\(\)]|^)[a-zA-z]+[\w]{2,24})(?=[\s\/\\(\)]|$)";
        Regex passwordValidation = new Regex(passwordCheck);
        MatchCollection matches = passwordValidation.Matches(input);
        int currentLength = 0;
        int maxLength = 0;
        int maxIndexFirst = 0;
        //get the max length of 2 consecutive passwords
        for (int i = 0; i < matches.Count - 1; i++)
        {
            currentLength = matches[i].Length + matches[i + 1].Length;
            if(currentLength > maxLength)
            {
                maxLength = currentLength;
                maxIndexFirst = i;
            }
        }
        Console.WriteLine(matches[maxIndexFirst]);
        Console.WriteLine(matches[maxIndexFirst + 1]);
    }
}