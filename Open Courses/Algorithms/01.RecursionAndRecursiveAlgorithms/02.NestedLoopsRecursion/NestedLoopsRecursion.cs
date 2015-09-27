using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NestedLoopsRecursion
{
    static List<int> nums = new List<int>();
    private static int loops = 0;
 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Loop(n, loops);
    }

    static void Loop(int n, int loops)
    {
        if (loops == n)
        {
            Console.WriteLine(string.Join(" ", nums));
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            nums.Add(i);
            Loop(n, loops + 1);
            nums.RemoveAt(nums.Count - 1); // remove the last row after you
            // are done with the recursion and have printed it
        }
    }
}
