using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarVariables
{
    class Program
    {
        static void Main1(string[] args)
        {
            var a = "abc";
            a = "pq";
          //  var b;   error
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

namespace VarVariables
{
    class Program1
    {
        static void Main(string[] args)
        {
            var o = new {a=10 ,b="akshay" };
            Console.WriteLine(o.a);
            Console.WriteLine(o.b);
            Console.WriteLine(o.GetType());
            Console.WriteLine(args.GetType());
            Console.ReadLine();
            
        }
    }
}
