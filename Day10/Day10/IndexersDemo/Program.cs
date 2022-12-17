using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexers id = new Indexers();
            id[0] = 10;
            id[1] = 20;
            id[2] = 30;          

            for (int i =0;i<id.Length;i++)
            {
                Console.WriteLine(id[i]);
            }
            Console.ReadLine();
        }
    }


    class Indexers
    {
        int[] arr = new int[3];
        public int this[int i]
        {
            set
            {
                arr[i] = value;
            }
            get
            {
                return arr[i];
            }
        }

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }
    }
}
