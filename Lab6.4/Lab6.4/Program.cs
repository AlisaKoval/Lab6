using System;
using System.IO;

namespace Lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alisa\source\repos\Lab6\lab.dat";
            string pathDirectory = @"E:\Lab6_Temp";
            DirectoryInfo directory = new DirectoryInfo(pathDirectory);
            if(!directory.Exists)
            {
                directory.Create();
            }
            string pathLabDat = @"E:\Lab6_Temp\lab.dat";
            string pathCopyFile = @"E:\Lab6_Temp\lab_backup.dat";
            FileInfo file = new FileInfo(path);
            file.CopyTo(pathLabDat,true);
            BinaryReader br = new BinaryReader(new FileStream(pathLabDat, FileMode.Open));
            BinaryWriter bw = new BinaryWriter(new FileStream(pathCopyFile, FileMode.OpenOrCreate));
            while(br.PeekChar()>-1)
            {
                byte line = br.ReadByte();
                bw.Write(line);
            }
            bw.Close();
            br.Close();

            using (BinaryReader bb = new BinaryReader(new FileStream(pathLabDat, FileMode.Open)))
            {

                using (BinaryWriter bbw = new BinaryWriter(new FileStream(pathCopyFile, FileMode.OpenOrCreate)))
                {

                }

            }
                Console.WriteLine("размер файла: {0}\nвремя последнего изменения: {1}\nвремя последнего доступа: {2}", file.Length, file.LastWriteTime, file.LastAccessTime);
            Console.ReadKey();
        }
    }
}
