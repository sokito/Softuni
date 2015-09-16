using System;
using System.Collections.Generic;
using System.Linq;
class SubsetSums
{
    static int[] numbers;
    public static int sumNeeded;
    static int solutions = 0;

    private static void PrintSubset(List<int> subset) 
    // method for printing the subsets, which are a solution.
    {
        Console.WriteLine(" {0} = {1}", string.Join(" + ", subset), sumNeeded);
    }

    static void MakeSubset(int index, List<int> subset) // method for making the subsets with recursion
    {
        int sum = subset.Sum();
        if (sum == sumNeeded)
        {
            PrintSubset(subset);
            solutions++;
        }

        if (subset.Count == numbers.Length) // there are no more numbers to be put into the sequence
        {
            return;
        }
        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]); // add element to the susbset
            MakeSubset(i + 1, subset); // recursion - call the method with index i+1
            subset.RemoveAt(subset.Count - 1); // remove last element
        }
    }

    static void Main()
    {
        sumNeeded = int.Parse(Console.ReadLine());

        numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // make subsets
        List<int> subset = new List<int>();
        MakeSubset(0, subset);

        // if no solutions
        if (solutions == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}
