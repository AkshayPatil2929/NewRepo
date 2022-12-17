using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInvalidation
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Check n1 = new Check();
            int x =Convert.ToInt32(Console.ReadLine());
            n1.Num = x;
            }

            catch (InvalidNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadLine();
        }
       
    }

    class Check
    {
        private int num;
        public int Num
        {
            set
            {
                if (value < 50)
                {
                  

                    num = value;
                }
                else
                {
                    // Console.WriteLine("Invalid");        dont write this
                    //   Exception ex = new Exception("Invalid number");
                    //   throw ex;
                    //  throw new Exception("Invalid number");

                    //userdefined exeption
                    throw new InvalidNumberException(" Invalid number Enter correct number ");
                
                }
            }
        }
    }

    public class InvalidNumberException : ApplicationException
    {
        public InvalidNumberException(string message):base(message)
        {

        }
    }

}
