using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CombinationsWithRepetitions
{
    private static int k;
    private static int startIndex;
    private static int n;
    private static List<int> numbers = new List<int>();

    static void Main(string[] args)
    {
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine()); // = nested loops
        startIndex = 1;
        Combinations(n,k,startIndex);
    }

    private static void Combinations(int n, int k,int startIndex)
    {
        if (k == 0) //no more loops => display the numbers
        {
            Console.WriteLine(string.Join(" ", numbers));
            return;
        }

        for (int i = startIndex; i <= n; i++)
        {
            numbers.Add(i);
            Combinations(n, k - 1, i);
            numbers.RemoveAt(numbers.Count - 1); //remove last number
        }
    }
}
