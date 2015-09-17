using System;
using System.Collections.Generic;
using System.Linq;
class LongestIncreasingSequence
{
    static void Main(string[] args)
    {
        //get the integers from a line in the console separated by a space
        string[] inputStrings = Console.ReadLine().Split(' ');
        int[] inputInts = inputStrings.Select(int.Parse).ToArray();
        int maxSequenceLength = 0;
        int currentSequenceLength = 1;
        int currentStartIndex = 0;
        int maxStartIndex = 0;
        for (int i = 0; i < inputInts.Length - 1; i++)
        {
            
            if (inputInts[i] < inputInts[i+1]) //increasing sequence
            {
                currentSequenceLength++;
            }
            else //print the old sequence, start a new sequence, update maxLength
            {
                Console.WriteLine(String.Join(" ",inputStrings,currentStartIndex,currentSequenceLength));
                currentStartIndex = i+1;
                currentSequenceLength = 1;
                if(currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                    maxStartIndex = currentStartIndex;
                }
                
            }
        }
        //print the last sequence
        Console.WriteLine(String.Join(" ", inputStrings, currentStartIndex, currentSequenceLength));
        //print the longest sequence
        Console.Write("Longest: ");
        Console.WriteLine(String.Join(" ", inputStrings, maxStartIndex, maxSequenceLength));
    }
}
