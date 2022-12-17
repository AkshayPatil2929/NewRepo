using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
       
        static void Main(string[] args)
        {
            num1 o = new num1();
            try { 
         
                o = null;
          
            int x = Convert.ToInt32(Console.ReadLine());
            o.A = 100 / x;
            Console.WriteLine(o.A);

           
            }
           

            catch (DivideByZeroException )
            {
                Console.WriteLine("DivideByZeroException occurred");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException occurred");
            }

            catch (FormatException )
            {

                Console.WriteLine("FormatException occurred");
            }

            Console.ReadLine();
        }
    }
    class num1
    {
        private int a;
        public int A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
    }
}
