using System;
using System.IO;
namespace Lab6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string path = @"C:\Users\alisa\source\repos\Lab6.5\" + name;
            BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open));
            char[] heading = br.ReadChars(2);
            int size = br.ReadInt32();
            br.ReadBytes(12);
            int wigth = br.ReadInt32();
            int height = br.ReadInt32();
            br.ReadBytes(2);
            short byteByPixel = br.ReadInt16();
            int compression = br.ReadInt32();
            string Compression = "";
            switch(compression)
            {
                case (0):
                    Compression = "BI_RBG";
                    break;
                case (1):
                    Compression = "BI_RLE8";
                    break;
                case (2):
                    Compression = "BI_RLE4";
                    break;
            }
            int sizeZip = br.ReadInt32();
            int horizontalResolution = br.ReadInt32();
            int verticalResolution = br.ReadInt32();
            br.Close();
            Console.WriteLine("Заголовки файла: {0}{1}\nИнформация о файле:\nРазмер файла: {2}байт\nШирина: {3} пикселей\nВысота: {4} пикселей\n{5} бит на пиксель\nГоризонтальное разрешение: {6} пикселей на метр\nВертикальное разрешение: {7} пикселей на метр\nТип сжатия: {8}\n {9}",heading[0],heading[1], size, wigth, height, byteByPixel, horizontalResolution, verticalResolution, Compression, sizeZip);
        }
    }
}
