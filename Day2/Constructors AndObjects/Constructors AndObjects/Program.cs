using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_AndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1 p1 = new Program1();
            System.Console.WriteLine(p1.a);
            System.Console.WriteLine(p1.c);

            Program1 p11 = new Program1(50, 60, "Welcome");
            System.Console.WriteLine(p11.a);
            System.Console.WriteLine(p11.c);

            p11.K = 102;
            System.Console.WriteLine("Value of k is : " + p11.K);

            //Program2 p2 = new Program2() { p = 10, q = 20, r = "R" };
            //System.Console.WriteLine("String r is : " + p2.r);
            //p2.show(); // method where values of fields are written

            Program2 p22 = new Program2() { p = 10, q = 20}; //by this only p and q are initialised while r is empty
            System.Console.WriteLine("String r is : " + p22.r);
            System.Console.WriteLine("Value  of p is : " + p22.p);
            p22.show(); // method where values of fields are written
            Console.ReadLine();
        }
    }

    public class Program1
    {
        public int a;
        public int b;
        public string c;
        public Program1()
        {
            a = 10;
            b = 20;
            c = "Hello";
            System.Console.WriteLine("No Parameters constructor is called");
        }

        public Program1(int a, int b, string c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            System.Console.WriteLine("Parameters constructor is called");
        }

        private int k;
        public int K
        {
            set
            {
                if (value < 100)
                {
                    k = value;
                }
                else
                {
                    k = 150;
                }
            }

            get
            {
                return k;
            }
        }
    }

    public class Program2{
        public int p;
        public int q;
        public string r;
        public Program2()
        {
            System.Console.WriteLine("No parms constructor called");
            System.Console.WriteLine("String r in cons is : "+r);  //__ After cons is called than the value is assigned so at this point its empty
        }
        public void show()
        {
            System.Console.WriteLine("String r in method is : " + r); //  R
        }
}
}
