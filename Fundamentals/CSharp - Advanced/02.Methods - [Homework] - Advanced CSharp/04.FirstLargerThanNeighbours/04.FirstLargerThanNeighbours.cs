using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    private static int GetIndexOfFirstElementLargerThanNeighbours(int[] sequence)
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            if(IsLargerThanNeighbours(sequence,i))
            {
                return i;
            }
        }
        return -1;
    }
    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        if (i == 0)
        {
            if (numbers[i] > numbers[i + 1])
            //first element and bigger than the next one
            {
                return true;
            }
            else //first element and smaller than the next one
            {
                return false;
            }
        }
        else if (i == numbers.Length - 1 )
        {    
            if (numbers[i] > numbers[i - 1])
            //if the element is the last one and bigger than the previous one
            {
                return true;
            }
            else
            //if the element is the last one and bigger than the previous one
            {
                return false;
            }
        }
        
        else if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
