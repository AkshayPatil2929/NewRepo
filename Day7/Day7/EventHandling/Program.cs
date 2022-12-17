using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        static void Main1(string[] args)
        {
            Check ch = new Check();
            ch.invalidh += Ch_invalidh;
            ch.invalidh += Ch_invalidh1;
            ch.A = 150;
            Console.ReadLine();
        }

        private static void Ch_invalidh1()
        {
            Console.WriteLine("event handler code part 2");
        }

        private static void Ch_invalidh()
        {
            Console.WriteLine("event handler code");
        }
    }

    public delegate void InvalidHandler();
    class Check
    {
        public event InvalidHandler invalidh;

        private int a;
        public int A
        {
            set
            {
                if (value < 50) 
                { 
                a = value;
                }
                else
                {
                    // event raising
                    invalidh();
                }
            }
            get
            {
                return a;
            }
        }
    }

}



namespace EventHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckWithValue chv = new CheckWithValue();
            chv.IHWV += Chv_IHWV;
            chv.A = 49;
            Console.ReadLine();
        }

        private static void Chv_IHWV(int invalidValue)
        {
            Console.WriteLine("invalidValue value is :" + invalidValue );
        }

        private static void Ch_invalidh1()
        {
            Console.WriteLine("event handler code part 2");
        }

        private static void Ch_invalidh()
        {
            Console.WriteLine("event handler code");
        }
    }

    public delegate void InvalidHandlerWithValue(int invalidValue);
    public class CheckWithValue
    {
        public event InvalidHandlerWithValue IHWV;
        private int a;
        public int A
        {
            set
            {
                if (value < 50)
                {
                    a = value;
                }
                else
                {
                    // event raising
                    IHWV(value);
                }
            }
            get
            {
                return a;
            }
        }
        }
}