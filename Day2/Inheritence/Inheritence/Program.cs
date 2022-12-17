using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch1 = new Child();
            System.Console.WriteLine(ch1.x); //Parent variable is accessible in child class
            Console.ReadLine();
        }

        public class Parent
        {
           public int x = 45;
        }
        public class Child : Parent
        {

        }
    }
}

namespace InheritenceAccess
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

   public class Parentclass
    {
        public int Public;
        private int Private;
        internal int Internal;
        protected int Protected;
        protected internal int Protected_Internal;
        private protected int Private_Protected;

    }

    public class Childclass :Parentclass
    {
        void checking()
        {
            this.Public = 100;
  //          this.Private = 120;// Not allowed
            this.Internal = 120;
            this.Protected = 120;
            this.Protected_Internal = 120;
            this.Private_Protected = 120;          
        }
    }
}


namespace InheritenceAccessFromOtherProject
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Childclass : AccessLibrary.BaseClass
    {
        void checking()
        {
            this.Public = 100;
            //     this.Private = 120;// Not allowed
            //     this.Internal = 120; // Not allowed
            this.Protected = 120;
            this.Protected_Internal = 120;
            //     this.Private_Protected = 120; // Not allowed
        }
    }
}