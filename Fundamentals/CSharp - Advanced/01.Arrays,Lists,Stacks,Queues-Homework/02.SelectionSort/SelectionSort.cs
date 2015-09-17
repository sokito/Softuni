using System;
class SelectionSort
{
    static void Main(string[] args)
    {
        //get the input in a string array and parse it to a int array
        string[] inputString = Console.ReadLine().Split(' ');
        int arraySize = inputString.Length;
        int[] inputInt = new int[inputString.Length];
        for (int i = 0; i < inputString.Length; i++)
        {
            inputInt[i] = int.Parse(inputString[i]);
        }
        //sort the array with selection sort
        int temp = 0;
        int indexMin = 0;
        for (int j = 0; j < arraySize - 1; j++)
        {
            indexMin = j;
 
            for (int k = j + 1; k < arraySize; k++)
            {
                if (inputInt[k] < inputInt[indexMin])
                {
                    indexMin = k;
                }
            }
 
            temp = inputInt[indexMin];
            inputInt[indexMin] = inputInt[j];
            inputInt[j] = temp;
        }
        
        //display the array
        foreach (var number in inputInt)
        {
            Console.Write(number + " ");
        }
    }
}
