using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ZipingSlicedFiles
{
    private static List<string> files = new List<string>();
    private static MatchCollection matches;
    private static void Main()
    {
        string inputFile = @"../../text.txt";
        string folderPath = @"../../";
        int NumberOfParts = 4;

        Slice(inputFile, folderPath, NumberOfParts);

        Assemble(files, folderPath);
    }
    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var sourceStream = new FileStream(sourceFile, FileMode.Open))
        {
            //get the sizes of each part
            long partSize = (long)Math.Ceiling((double)sourceStream.Length / parts);

            // The offset at which to start reading from the source file
            long fileOffset = 0;

            string currentPartPath;
            FileStream fsPart;
            long sizeRemaining = sourceStream.Length;

            // extracting name and extension of the input file
            string pattern = @"((\w+)\.(\w+))";
            Regex fileNames = new Regex(pattern);
            matches = fileNames.Matches(sourceFile);
            for (int i = 0; i < parts; i++)
            {
                currentPartPath = destinationDirectory + String.Format(@"Part{0}", i) + "." + matches[0].Groups[3];
                files.Add(currentPartPath);

                using (fsPart = new FileStream(currentPartPath, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(fsPart, CompressionMode.Compress, false))
                    {
                        long currentPieceSize = 0;
                        byte[] buffer = new byte[4096];
                        while (currentPieceSize < partSize)
                        {
                            int readBytes = sourceStream.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            compressionStream.Write(buffer, 0, readBytes);
                            currentPieceSize += readBytes;
                        }
                    }
                    
                }

                sizeRemaining = (int)sourceStream.Length - (i * partSize);
                if (sizeRemaining < partSize)
                {
                    partSize = sizeRemaining;
                }
                fileOffset += partSize;
            }
        }
    }
    static void Assemble(List<string> files, string destinationDirectory)
    {
        string fileOutputPath = destinationDirectory + "assembled" + "." + matches[0].Groups[3];
        var fsSource = new FileStream(fileOutputPath, FileMode.Create);
        fsSource.Close();

        using (fsSource = new FileStream(fileOutputPath, FileMode.Append))
        {
            // reading the file paths of the parts from the files list
            foreach (var filePart in files)
            {
                using (var partSource = new FileStream(filePart, FileMode.Open))
                {
                    using (var compressionStream = new GZipStream(partSource,CompressionMode.Decompress,false))
                    {
                        // copy the bytes from part to new assembled file
                        Byte[] bytePart = new byte[4096];
                        while (true)
                        {
                            int readBytes = compressionStream.Read(bytePart, 0, bytePart.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            fsSource.Write(bytePart, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
    static void Decompress(string inputFile, string outputFile)
    {
        using (var inputStream = new FileStream(inputFile, FileMode.Open))
        {
            using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
            {
                using (var outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        outputStream.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
    
}
