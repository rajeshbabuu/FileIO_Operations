using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operations
{
    public class Operations
    {
        public void FileExists()
        {
            Console.WriteLine("\n**********File Exists Operation**********");
            string filePath = @"D:\RFP-244\FileIO\FileIO_Operations\FileIO_Operations\WordFile1.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nFile Exists");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }

        public void ReadAllLines()
        {
            Console.WriteLine("\n**********Read All Lines**********\n");
            string filePath = @"D:\RFP-244\FileIO\FileIO_Operations\FileIO_Operations\WordFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(filePath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadLine();
        }

        public void ReadAllText()
        {
            Console.WriteLine("\n**********Read All Text**********\n");
            string filePath = @"D:\RFP-244\FileIO\FileIO_Operations\FileIO_Operations\WordFile1.txt";
            string text;
            text = File.ReadAllText(filePath);
            Console.WriteLine(text);
            Console.ReadLine();
        }

        public void CopyPath()
        {
            Console.WriteLine("\n**********Copy File Path**********");
            string filePath = @"D:\RFP-244\FileIO\FileIO_Operations\FileIO_Operations\Program.cs";
            string copyFilePath = @"D:\RFP-244\FileIO\FileIO_Operations\FileIO_Operations\WordFile2.txt";
            File.Copy(filePath, copyFilePath);
            Console.WriteLine("\nCopied Successfully");
            string copiedText;
            copiedText = File.ReadAllText(copyFilePath);
            Console.WriteLine(copiedText);
        }
}
}
