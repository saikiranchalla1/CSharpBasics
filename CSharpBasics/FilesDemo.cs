using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class FilesDemo
    {
        static void Main1(string[] args)
        {
            // File = collection of data stored on disk
            // Stream = sequence of bytes that is traveling from one source to destination

            // Input stream vs Output stream

            // File handling: Reading, Writing, Append

            // System.IO Namespace


            // FileStream

            string filePath = @"C:\Users\schalla\DemoFile.txt";

            FileStream fileStream = new FileStream(filePath, FileMode.Append);

            // fileStream = File.Create(filePath);

            byte[] data = Encoding.Default.GetBytes("We are learning C#!");

            fileStream.Write(data, 0, data.Length);

            fileStream.Close();

            // Reading a file using FileStream

            FileStream readStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);


            string readData;
            using (StreamReader streamReader = new StreamReader(readStream))
            {
                readData = streamReader.ReadToEnd();
            }

            Console.WriteLine(readData);


            // StreamWriter demo

            StreamWriter streamWriter = new StreamWriter(filePath);

            Console.WriteLine("Enter the data you want to write to a file: ");

            string inputData = Console.ReadLine();

            streamWriter.WriteLine(inputData);

            streamWriter.Flush();
            streamWriter.Close();


            // File class

            // if file exists

            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists!");

                string[] lines = File.ReadAllLines(filePath); 

                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }


                string linesFromText = File.ReadAllText(filePath);

                Console.WriteLine(linesFromText);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

            Console.WriteLine("Copy file demo");
            string DestnFilePath = @"C:\Users\schalla\DemoFileCopy.txt";

            if (File.Exists(filePath))
            {
                File.Copy(filePath, DestnFilePath, true);

                string lines = File.ReadAllText(DestnFilePath);

                Console.WriteLine(lines);

                File.Delete(filePath);
            }

            Console.WriteLine("TextWriter and TextReader");
            // TextWriter vs TextReader

            using (TextWriter textWriter = File.CreateText(filePath))
            {
                textWriter.WriteLine("Demo TextWriter");
                textWriter.WriteLine("Second line of text");
            }

            using (TextReader textReader = File.OpenText(filePath))
            {
                Console.WriteLine(textReader.ReadLine());
            }

            Console.WriteLine("BUffer sized TextReader");
            using (TextReader textReader = File.OpenText(filePath))
            {
                char[] ch = new char[4];
                textReader.ReadBlock(ch, 0, 4);
                Console.WriteLine(ch);
            }

            Console.WriteLine("BinaryWriter and Reader");

            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(@"C:\Users\schalla\DemoFile.bin", FileMode.Create)))
            {
                binaryWriter.Write("We are learning C# Binary Writers");
                binaryWriter.Write(true);
                binaryWriter.Write("0X8023584");

            }

            using (BinaryReader binaryReader = new BinaryReader(File.Open(@"C:\Users\schalla\DemoFile.bin", FileMode.Open)))
            {
                Console.WriteLine(binaryReader.ReadString());
                Console.WriteLine(binaryReader.ReadBoolean());
            }

            // FileInfo and DirectoryInfo

            Console.WriteLine("FileInfo and DirectoryInfo");

            FileInfo fileInfo = new FileInfo(filePath);
            /*fileInfo.CreateText();
            fileInfo.Delete();

            fileInfo.CopyTo(DestnFilePath);

            fileInfo.MoveTo(DestnFilePath);*/

            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.DirectoryName);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.IsReadOnly);
            Console.WriteLine(fileInfo.LastAccessTime);


            Console.WriteLine("DirectoryInfo Demo");

            string directoryPath = @"C:\Users\schalla";
            string moveDestnPath = @"C:\Users\schalla\DemoSubDIrectoryMoved";



            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            // directoryInfo.CreateSubdirectory("DemoSubDIrectory");


            string srcPath = @"C:\Users\schalla\MyTestFile";
            string destnPath = @"C:\Users\schalla\NewTestFile";

            DirectoryInfo directoryInfo1 = new DirectoryInfo(srcPath);
            directoryInfo1.Create();

            directoryInfo1.MoveTo(destnPath);

            // directoryInfo.Delete();

            Console.WriteLine(directoryInfo.FullName);
            Console.WriteLine(directoryInfo.Name);
            Console.WriteLine(directoryInfo.CreationTime);
            Console.WriteLine(directoryInfo.LastAccessTime);
            Console.WriteLine(directoryInfo.Exists);


        }
    }
}
