using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           // Directory.CreateDirectory(@"G:\Dot Net\FileCreated");
         //   File.Create(@"G:\Dot Net\FileCreated\f.txt");
            File.Create(@"G:\Dot Net\FileCreated\f.txt");
            string st = "Akshay";
            byte[] arr = Encoding.Default.GetBytes(st);
            stream.
                //.Write(arr, 0, arr.Length);

        }
    }
}
