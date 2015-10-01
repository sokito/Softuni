using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CopyBinaryFile
{
    static void Main(string[] args)
    {
        FileStream inputStream = new FileStream("../../file.txt",FileMode.Open);
        FileStream outputStream = new FileStream("../../fileCopy.txt",FileMode.Create);
        try
        {
            byte[] buffer = new byte[4096];
            while(true)
            {
                int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                if(readBytes == 0)
                {
                    break;
                }
                outputStream.Write(buffer, 0, buffer.Length);
            }
        }
        finally
        {
            inputStream.Close();
            outputStream.Close();
        }
    }
}
