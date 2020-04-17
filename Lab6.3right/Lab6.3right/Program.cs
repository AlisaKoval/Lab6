using System;
using System.IO;
namespace Lab6._3right
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathOriginalFile = @"C:\Users\alisa\source\repos\Lab6.3right\text.txt";
            string pathEditlFile = @"C:\Users\alisa\source\repos\Lab6.3right\text1.txt";
            int cntOfDeletions = 0;
            using (StreamReader sr = new StreamReader(pathOriginalFile))
            {
                StreamWriter sw = new StreamWriter(pathEditlFile,false);
                while (sr.Peek() > -1)
                {
                    char symbol = Convert.ToChar(sr.Read());
                    if (!Char.IsDigit(symbol))
                    {
                        sw.Write(symbol);
                    }
                    else 
                       
                        cntOfDeletions++;
                    
                }
                sw.Close();
            }
            Console.WriteLine(cntOfDeletions);
            Console.ReadKey();
        }
    }
}
