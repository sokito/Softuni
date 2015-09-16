using System;
class Program
{
    static void Main(string[] args)
    {
        //get the input in a string array and parse it to a int array
        string[] inputString = Console.ReadLine().Split(' ');
        int[] inputInt = new int[inputString.Length];
        for (int i = 0; i < inputString.Length; i++)
        {
            inputInt[i] = int.Parse(inputString[i]);
        }
        int changes = 0; // this integer holds the number of changes in each iteration
        //sort the array with the bubble sort (not the array.sort function)
        while(true)
        {
            changes = 0; //null the changes value 
            for (int m = 0; m < inputInt.Length - 1; m++)
            {
                //check if the next value is bigger than the previous one
                if (inputInt[m] > inputInt[m + 1])
                {
                    int temp = inputInt[m];
                    inputInt[m] = inputInt[m + 1];
                    inputInt[m + 1] = temp;
                    changes++; // increment the number of 'changes' with each change by 1.
                }
             }
            //if there are no changes the array is sorted and breaks the loop
            if (changes == 0)
            {
                break;
            }
        }
        //display the array
        foreach (var number in inputInt)
        {
            Console.Write(number + " ");
        }
    }
}
