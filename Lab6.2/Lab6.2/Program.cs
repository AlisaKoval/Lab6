using System;
using System.IO;
namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alisa\source\repos\Lab6.2\lab.dat";
            using (BinaryWriter writeToFirstFile = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                for (int i = 4; i < 82; i++)
                {
                    double N = Math.Pow(i, 0.5);
                    writeToFirstFile.Write(i);
                    writeToFirstFile.Write(N);
                }
            }
            WriterToSecondFileFrom(path);
            Console.ReadKey();
        }
        static void WriterToSecondFileFrom(string path)
        {
            BinaryReader readFromFirstFile = new BinaryReader(new FileStream(path, FileMode.Open));
            BinaryWriter writeToSecondFile = new BinaryWriter(new FileStream(@"C:\Users\alisa\source\repos\Lab6.2\lab1.dat", FileMode.OpenOrCreate));
            while (readFromFirstFile.PeekChar()>-1)
            {             
                int i = readFromFirstFile.ReadInt32();
                double N = readFromFirstFile.ReadDouble();
                Console.WriteLine(i);
                Console.WriteLine(N);
                writeToSecondFile.Write(N);
            }
            writeToSecondFile.Close();
            readFromFirstFile.Close();
        }
    }
}
