using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../TextFile.txt");
        using (reader)
        {
            int lineCount = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if(lineCount%2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
                lineCount++;
            }
        }
    }
}
