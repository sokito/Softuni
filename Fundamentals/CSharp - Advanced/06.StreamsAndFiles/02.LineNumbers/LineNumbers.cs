using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class LineNumbers
{
    static void Main(string[] args)
    {
        const string pathReader = "../../TextFile.txt";
        const string pathWriter = "../../TextFileWithLineNumbers.txt";
        StreamReader reader = new StreamReader(pathReader);
        StreamWriter writer = new StreamWriter(pathWriter);
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                int lineCounter = 0;
                while(line != null)
                {
                    writer.WriteLine("{0} {1}",lineCounter,line);
                    line = reader.ReadLine();
                    lineCounter++;
                }
            }
        }
    }
}

