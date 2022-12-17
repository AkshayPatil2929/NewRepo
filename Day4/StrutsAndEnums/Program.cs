using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutsAndEnums
{
    class Program
    {
        static void Main1(string[] args)
        {
            //  int i = new int();
            //int i=0;
            // Console.WriteLine(i);
            First f1 = new First();
            First f = new First(10,20,30);  
            Console.ReadLine();
        }
    }

    public struct First
    {
        public int x;
        public int y;

        public int Z
        {
            set; get;
        }

       public First(int x,int y,int z)
        {
            Console.WriteLine("Param const Called");
            this.x = x;                 //compulsary line
            this.y = y;                  //compulsary line
            this.Z = z;                  //compulsary line
        }
    }
}

namespace Enums
{
    class Program1
    {
        static void Main(string[] args)
        {
            Display(Time.evening);
            Display(Time.night);
            Console.ReadLine();
        }
        static void Display(Time t)
        {
            if (t == Time.morning)
                Console.WriteLine("Good Morning ");
            else if (t == Time.afternoon)
                Console.WriteLine("Good Afternoon ");
            else if (t == Time.evening)
                Console.WriteLine("Good evening ");
            else if (t == Time.night)
                Console.WriteLine("Good night ");

        }
    }

    public enum Time
    {
        morning,
        afternoon,
        evening,
        night
    }
}