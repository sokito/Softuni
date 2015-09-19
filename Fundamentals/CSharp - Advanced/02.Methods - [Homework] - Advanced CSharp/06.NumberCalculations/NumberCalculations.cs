using System;
using System.Collections.Generic;
class NumberCalculations
{
    static void Main(string[] args) //without overloading! TO BE COMPLETED
    {
        //Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers.
        //Overload the methods to work with numbers of type double and decimal.
        
        //get input with integers
        string[] numbersSetStrings = Console.ReadLine().Split(' ');
        int[] numbersSet = new int[numbersSetStrings.Length];
        for (int i = 0; i < numbersSetStrings.Length; i++)
        {
            numbersSet[i] = int.Parse(numbersSetStrings[i]);
        }
        Console.WriteLine("Max of the set = " + GetMax(numbersSet));
        Console.WriteLine("Min of the set = " + GetMin(numbersSet));
        Console.WriteLine("Sum of the set = " + GetSum(numbersSet));
        Console.WriteLine("Average of the set = " + GetAvg(numbersSet));
        Console.WriteLine("Product of the set = " + GetProduct(numbersSet));
        //get input with doubles
        string[] numbersSetStringsDoubles = Console.ReadLine().Split(' ');
        double[] numbers = new double[numbersSetStringsDoubles.Length];
        for (int i = 0; i < numbersSetStrings.Length; i++)
        {
            numbers[i] = double.Parse(numbersSetStringsDoubles[i]);
        }
        Console.WriteLine("Max of the set = " + GetMax(numbers));
        Console.WriteLine("Min of the set = " + GetMin(numbers));
        Console.WriteLine("Sum of the set = " + GetSum(numbers));
        Console.WriteLine("Average of the set = " + GetAvg(numbers));
        Console.WriteLine("Product of the set = " + GetProduct(numbers));
    }
    //get max methods
    private static int GetMax(int[] numbersSet)
    {
        int max = int.MinValue;
        foreach (var item in numbersSet)
        {
            if(item > max)
            {
                max = item;
            }
        }
        return max;
    }
    private static double GetMax(double[] numbersSet)
    {
        double max = double.MinValue;
        foreach (var item in numbersSet)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }
    private static decimal GetMax(decimal[] numbersSet)
    {
        decimal max = decimal.MinValue;
        foreach (var item in numbersSet)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }
    //get min methods
    private static int GetMin(int[] numbersSet)
    {
        int min = int.MaxValue;
        foreach (var item in numbersSet)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }
    private static double GetMin(double[] numbersSet)
    {
        double min = double.MaxValue;
        foreach (var item in numbersSet)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }
    private static decimal GetMin(decimal[] numbersSet)
    {
        decimal min = decimal.MaxValue;
        foreach (var item in numbersSet)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }
    //get sum methods
    private static int GetSum(int[] numbersSet)
    {
        int sum = 0;
        foreach (var item in numbersSet)
        {
            sum += item;
        }
        return sum;
    }
    private static double GetSum(double[] numbersSet)
    {
        double sum = 0;
        foreach (var item in numbersSet)
        {
            sum += item;
        }
        return sum;
    }
    private static decimal GetSum(decimal[] numbersSet)
    {
        decimal sum = 0;
        foreach (var item in numbersSet)
        {
            sum += item;
        }
        return sum;
    } 
    //get avg method
    private static double GetAvg(int[] numbersSet)
    {
        double sum = GetSum(numbersSet);
        double avg = sum / numbersSet.Length;
        return avg;
    }
    private static double GetAvg(double[] numbersSet)
    {
        double sum = GetSum(numbersSet);
        double avg = sum / numbersSet.Length;
        return avg;
    }
    private static decimal GetAvg(decimal[] numbersSet)
    {
        decimal sum = GetSum(numbersSet);
        decimal avg = sum / numbersSet.Length;
        return avg;
    }
    // get product methods
    private static int GetProduct(int[] numbersSet)
    {
        int product = 1;
        foreach (var item in numbersSet)
        {
            product *= item;
        }
        return product;
    }
    private static double GetProduct(double[] numbersSet)
    {
        double product = 1;
        foreach (var item in numbersSet)
        {
            product *= item;
        }
        return product;
    }
    private static decimal GetProduct(decimal[] numbersSet)
    {
        decimal product = 1;
        foreach (var item in numbersSet)
        {
            product *= item;
        }
        return product;
    }
 }