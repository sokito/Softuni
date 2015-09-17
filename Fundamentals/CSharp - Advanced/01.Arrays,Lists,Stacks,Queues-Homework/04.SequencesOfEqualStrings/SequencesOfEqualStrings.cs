using System;
using System.Linq;
class SequencesOfEqualStrings
{
    static void Main(string[] args)
    {
        string[] inputStrings = Console.ReadLine().Split(' ').ToArray();
        Console.Write("{0} ", inputStrings[0]);
        for (int i = 1; i < inputStrings.Length; i++)
        {
            if (inputStrings[i] == inputStrings[i - 1])
            {
                Console.Write("{0} ", inputStrings[i]);
            }
            else
            {
                Console.Write("\n{0} ", inputStrings[i]);
            }
        }
        Console.WriteLine();

    }
}
