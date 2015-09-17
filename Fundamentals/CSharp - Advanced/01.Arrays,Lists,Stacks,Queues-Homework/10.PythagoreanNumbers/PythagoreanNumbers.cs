using System;
using System.Collections.Generic;
using System.Linq;
class PythagoreanNumbers
{
    static void Main(string[] args)
    {
        //get input
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int solutions = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //check all combinations of a^2 + b^2 = c^2 and print the correct ones
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                { 
                    //if pythagorean numbers - print them
                    if(numbers[a] * numbers[a] + numbers[b] * numbers[b] 
                        == numbers[c] * numbers[c] && numbers[a] <= numbers[b]) // a<b restricts duplicated sets
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}",
                            numbers[a],numbers[b],numbers[c]);
                        solutions++;
                    }
                }
            }
        }
        if(solutions<=0)
        {
            Console.WriteLine("No");
        }
    }
}
