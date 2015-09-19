using System;
using System.Collections.Generic;
using System.Linq;
class TeroristsWin
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int firstIndex = 0;
        int secondIndex = 0;
        int bombStrength = 0;
        string bombString;
        char[] inputChars = input.ToCharArray(); 
        firstIndex = input.IndexOf('|');
        secondIndex = input.IndexOf('|', firstIndex + 1);
        while(firstIndex != -1)
        {
            //indexOf - returns -1 if not found
            bombString = input.Substring(firstIndex + 1,secondIndex-firstIndex - 1);
            foreach (var letter in bombString)
            {
                bombStrength += letter;
            }
            bombStrength = bombStrength % 10;
            
            for (int i = firstIndex - bombStrength; i <= secondIndex + bombStrength ; i++)
            {
                if(i>=0 && i < input.Length)
                {

                    inputChars[i] = '.';
                }
            }
            firstIndex = input.IndexOf('|',secondIndex + 1);
            secondIndex = input.IndexOf('|', firstIndex + 1);
            bombStrength = 0;
        }
        foreach (var letter in inputChars)
        {
            Console.Write(letter);
        }
    }
}
