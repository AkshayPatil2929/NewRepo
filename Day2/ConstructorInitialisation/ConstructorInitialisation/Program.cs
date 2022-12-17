using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInitialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       Program2 pg = new Program2();
                   //     pg.x = 20;
                   //     System.Console.WriteLine(pg.x); //20
                   pg.SetA(145);
                   System.Console.WriteLine(pg.GetA());

                   Console.ReadLine();*/

            /*     Program3 pg3 = new Program3();
                 pg3.A = 95;
                 System.Console.WriteLine(pg3.A);
                 Console.ReadLine();*/

            /*  Program4 pg4 = new Program4();
              //      pg4.A = 95; // Cant do this as its ReadOnly we have not defined any setters here
              System.Console.WriteLine(pg4.A);*/  //45 already defined value

            Program5 pg5 = new Program5();
            pg5.A = 120;
            System.Console.WriteLine(pg5.A);  //120 
            Console.ReadLine();
        }
    }

    class Program2
    {
        public int x;
        private int a;
        public void SetA(int a) {
            if(a<100)
            this.a = a;
            else
            {
                System.Console.WriteLine("Invalid Number");
            }
        }
        public int GetA()
        {
            return a;
        }
    }

    class Program3
    {
        public int x;
        private int a;
        public int A
        {
            set
            {
                if (value < 100)        //value shows the passed value from main
                    a = value;
                else
                {
                    System.Console.WriteLine("Invalid Number");
                }
            }
            get
            {
                return a;     
            }
        }
    }

    class Program4
    {
        public int x;
        private int a=45;
        public int A
        {
            get   //Read Only 
            {
                return a;
            }
        }
    }


    class Program5
    {
        public int x;
        private int a;
        public int A { get; set; }
        
    }
}
