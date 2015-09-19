using System;
using System.Collections.Generic;
using System.Linq;
class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 4, 7, 1, 2, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers,i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool isLarger ;
        if (i == numbers.Length - 1 && numbers[i] > numbers[i - 1])
        //if the element is the last one and bigger than the previous one
        {
            isLarger = true;
            return isLarger;
        }
        else if( i == 0 && numbers[i] > numbers[i+1]) 
            //first element and bigger than the next one
        {
            isLarger = true;
            return isLarger; 
        }
        else if( numbers[i] > numbers[i-1] && numbers[i] > numbers[i + 1])
        {
            isLarger = true;
            return isLarger;
        }
        else
        {
            isLarger = false;
            return isLarger;
        }
            
    }
}
