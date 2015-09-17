using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // number of numbers
        bool hasSolution = false;
        string[] numbers = new string[n];
        numbers = Console.ReadLine().Split(' ').ToArray();
        //4 nested for loops to check every combination
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        if(a != b && a != c && a != d && b != c && b != d && c != d) // no number should match another
                        {
                            if(FindStuckNumbers(a, b, c, d, numbers))
                            {
                                hasSolution = true;
                                Console.WriteLine("{0}|{1}=={2}|{3}",
                                    numbers[a],numbers[b],numbers[c],numbers[d]);
                            }
                        }
                    }
                }
            }
        }
        if (hasSolution == false)
        {
            Console.WriteLine("No");
        }
    }
    private static bool FindStuckNumbers(int a, int b, int c, int d, string[] numbers)
    {
        bool isStuck = false;
        if(numbers[a] + numbers[b] == numbers[c] + numbers[d])
        {
            isStuck = true;
        }
        return isStuck;
    }
        
}
