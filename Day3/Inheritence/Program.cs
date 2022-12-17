using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main1(string[] args)
        {
      //    DerivedClass d = new DerivedClass();
      //    Console.WriteLine("i : " + d.i + " j : " + d.j);
          DerivedClass d1 = new DerivedClass(40,50);
            Console.WriteLine("i : " + d1.i + " j : " + d1.j);
            Console.ReadLine();
        }
    }

   public class BaseClass    {

      public  int i;
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor with no params");
            i = 10;
        }
        public BaseClass(int i)
        {
            this.i = i;
            Console.WriteLine("BaseClass Constructor with params");
        }
    }

    public class DerivedClass:BaseClass
    {

        //    public int i;       //i : 0 j : 20  because at base class we are initialising i ,but due to this line it will again make i=0
        public int j;

        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Constructor with no params");
            j = 20;
        }
        public DerivedClass(int i,int j):base(i)
        {
            Console.WriteLine("DerivedClass Constructor with params");
            this.j = j;
           
        }
    }
}



namespace Inheritence2
{
    class Program2
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.Display();
            dc.Display(20);

            //If we want to call Display method of derived class only with no params we have two ways

            //1. Hideing
            dc.Display1();

            //2. Overriding
            dc.Display2();

            SubDerivedClass sdc = new SubDerivedClass();
            //calling a sealed overriden
            sdc.Display2();
            Console.ReadLine();
        }
    }

    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display normal method in base class");
        }

        public void Display1()
        {
            Console.WriteLine("Display normal method in base class");
        }

        public virtual void Display2()
        {
            Console.WriteLine("Display virtual method which can be overridden in base class");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Display(int i)
        {
            Console.WriteLine("Display normal method with params in Derived class");

        }

        public new void Display1()               //Hides the base class
        {
            Console.WriteLine("Display in derived class with hiding base class");
        }

        public override void Display2()               //Over ride the virtual base class
        {
            Console.WriteLine("Display in derived class with hiding base class");
        }
    }

    class SubDerivedClass : DerivedClass
    {

        public sealed override void Display2()
        {
            Console.WriteLine("Display in Subderived class with sealed override");
        }
    }

    class SubSubDerivedClass:SubDerivedClass
    {

        //public  override void Display2()  //cant override a sealed class
       public new void Display2()       //We can hide any method ,new keyword is not compulsary
        {
            Console.WriteLine("Display in Subderived class with sealed override");
        }
    }
}