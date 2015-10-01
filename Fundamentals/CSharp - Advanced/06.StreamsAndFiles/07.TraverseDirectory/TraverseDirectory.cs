using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TraverseDirectory
{
    static void Main(string[] args)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string pathTraverse = Console.ReadLine();

        //get all the files info in a list 
        string[] filePaths = Directory.GetFiles(String.Format(@"{0}",pathTraverse));
        List<FileInfo> fileInfos = filePaths.Select(p => new FileInfo(p)).ToList();
        
        //sort the list
        var sorted = fileInfos.OrderByDescending(file => file.Length).GroupBy(file => file.Extension).
            OrderByDescending(group => group.Count()).ThenBy(group => group.Key);

        //create file report.txt
        using (StreamWriter reportWriter = new StreamWriter(desktopPath + "/report.txt"))
        {
            foreach (var group in sorted)
            {
                reportWriter.WriteLine(group.Key);
                foreach (var info in group)
                {
                    double sizeKB = info.Length/ 1024.0;
                    reportWriter.WriteLine(String.Format("--{0} - {1:0.00}kb",info.Name,sizeKB));
                }
            }
        }
    }
}
