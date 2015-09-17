using System;
using System.Collections.Generic;
using System.Linq;
class CollectTheCoins
{
    static void Main(string[] args)
    {
        //jagged array with 4 rows
        int wallHits = 0;
        int coinsTaken = 0;
        char[][] field = new char[4][];
        for (int i = 0; i < field.GetLength(0); i++)
        {
            field[i] = Console.ReadLine().ToCharArray();
        }
        int indexX = 0;
        int indexY = 0;
        char coin = '$';
        char[] commands = Console.ReadLine().ToCharArray();
        for (int i = 0; i < commands.Length; i++)
        {
            if(commands[i] == 'v' || commands[i] == 'V') //down
            {
                if(indexX == 3) // hit the bottom wall
                {
                    wallHits++;
                }
                else if(field[indexX+1].GetLength(0) <= indexY) // there is no such field on the bottom row
                {
                    wallHits++; 
                }
                else
                {
                    indexX++;
                    if(field[indexX][indexY] == coin) //taking a coin
                    {
                        coinsTaken++;
                        field[indexX][indexY] = ' '; //remove coin
                    }
                }
            }
            if (commands[i] == '^') //up
            {
                if (indexX == 0) // hit the bottom wall
                {
                    wallHits++;
                }
                else if (field[indexX -1].GetLength(0) <= indexY) // there is no such field on the upper row
                {
                    wallHits++;
                }
                else
                {
                    indexX--;
                    if (field[indexX][indexY] == coin) //taking a coin
                    {
                        coinsTaken++;
                        field[indexX][indexY] = ' '; //remove coin
                    }
                }
            }
            if (commands[i] == '<') //left
            {
                if (indexY == 0) // hit the left wall
                {
                    wallHits++;
                }
                else
                {
                    indexY--;
                    if (field[indexX][indexY] == coin) //taking a coin
                    {
                        coinsTaken++;
                        field[indexX][indexY] = ' '; //remove coin
                    }
                }
            }
            if (commands[i] == '>') //right
            {
                if (indexY == field[indexX].GetLength(0) - 1) // hit the right wall
                {
                    wallHits++;
                }
                else
                {
                    indexY++;
                    if (field[indexX][indexY] == coin) //taking a coin
                    {
                        coinsTaken++;
                        field[indexX][indexY] = ' '; //remove coin
                    }
                }
            }
        }
            Console.WriteLine("Coins collected: {0}",coinsTaken);
            Console.WriteLine("Walls hit: {0}",wallHits);
    }
}
