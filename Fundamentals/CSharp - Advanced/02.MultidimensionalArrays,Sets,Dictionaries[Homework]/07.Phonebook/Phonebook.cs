﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Phonebook
{
    static void Main(string[] args)
    {
        Dictionary<string,string> phonebook = new Dictionary<string,string>();
        string input = Console.ReadLine();
        while(input != "search")
        {
            string name = input.Split('-')[0];
            string number = input.Split('-')[1];
            phonebook.Add(name, number);
            input = Console.ReadLine();
        }
        string searchName = Console.ReadLine();
        while(searchName != null)
        {
            if(phonebook.ContainsKey(searchName))
            {
                string num;
                phonebook.TryGetValue(searchName, out num);
                Console.WriteLine("{0} -> {1}", searchName, num);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist",searchName);
            }
            searchName = Console.ReadLine();
        }
    }
}

