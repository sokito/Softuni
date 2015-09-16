using System;
using System.Collections.Generic;
using System.Linq;
class CategorizeNumbers
{
    static void Main(string[] args)
    {
        //get the input in a string array and parse it to a float array
        string[] inputString = Console.ReadLine().Split(' ');
        float[] inputFloat = new float[inputString.Length];
        for (int i = 0; i < inputString.Length; i++)
        {
            inputFloat[i] = float.Parse(inputString[i]);
        }List<int> listInt = new List<int>();
        List<float> listFloat = new List<float>();
        for (int m = 0; m < inputFloat.Length; m++)
        {
            if (inputFloat[m] == Math.Floor(inputFloat[m])) // number is integer
            {
                listInt.Add((int)(inputFloat[m]));
            }
            else //number is float
            {
                listFloat.Add(inputFloat[m]);
            }
        }
        //print the float list - min - max -sum - avg.
        string outputFloat = "[";
        outputFloat += string.Join(", ",listFloat) + "]";
        double minFloat = listFloat.Min();
        double maxFloat = listFloat.Max();
        double sumFloat = listFloat.Sum();
        double avgFloat = listFloat.Average();
        outputFloat += string.Format(" -> min: {0:0.###}, max: {1:###}, sum: {2:###}, avg: {3:F2}",
                       minFloat,maxFloat,sumFloat,avgFloat);
        Console.WriteLine(outputFloat);
        //print the int list - min - max -sum - avg.
        string outputInt = "[";
        outputInt += string.Join(", ", listInt) + "]";
        double minInt = listInt.Min();
        double maxInt = listInt.Max();
        double sumInt = listInt.Sum();
        double avgInt = listInt.Average();
        outputInt += string.Format(" -> min: {0:###}, max: {1:###}, sum: {2:###}, avg: {3:F2}",
                       minInt, maxInt, sumInt, avgInt);
        Console.WriteLine(outputInt);
    }
}