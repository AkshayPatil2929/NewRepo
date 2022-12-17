using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Func1);
            Thread t2 = new Thread(Func2);
            t1.Start();
            t2.Start();

        //    t1.IsBackground = true;
        //    t2.IsBackground = true;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }
            t1.Join();
            Console.ReadLine();
        }

        static void Func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First : " + i);
            }

        }
        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second : " + i);
            }
        }
    }
}
