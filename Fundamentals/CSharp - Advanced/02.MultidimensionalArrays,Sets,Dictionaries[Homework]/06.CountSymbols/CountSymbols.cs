using System;
using System.Collections.Generic;
using System.Linq;
class CountSymbols
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        SortedDictionary <char,int> lettersCounter = new SortedDictionary<char,int>();
        for (int i = 0; i < inputText.Length; i++)
        {
            if(!lettersCounter.ContainsKey(inputText[i])) 
            {
                int count = inputText.Count(p => p == inputText[i]); //get the count
                lettersCounter.Add(inputText[i], count);
            }
        }
        foreach (var pair in lettersCounter)
        {
            Console.WriteLine("{0}: {1} time/s",pair.Key,pair.Value);
        }
    }
}
