using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main1(string[] args)
        {
            // AbstractClass ac = new AbstractClass(); cant instantinaite an abstractclass
            Derived d = new Derived(); //can call abstract class method with its derived class
            d.Display();
            Console.ReadLine();
        }
    }

    public abstract class AbstractClass
    {
        public void Display()
        {
            Console.WriteLine("Display method of abstract class");
        }
    }


    public class Derived :AbstractClass
    {
        public void View()
        {
            Console.WriteLine("View method of derived class of abstract class");
        }
    }
}


namespace InterfaceDemo
{
    class Program1
    {
        static void Main3(string[] args)
        {
            Derived d1 = new Derived();
            //Method 1 -can call all methods  of Derived class
            d1.show();
            d1.view();
            d1.check();

            //Method 2-TO call only interface methods of Derived class
            Interface1 d1I ;
            d1I = d1;
            d1I.show();
            d1I.view();
            // d1I.check();--Error cant call this method as its not an interface method

            //Method 3-
            ((Interface1)d1).show();        //This is works asme way as method 2
            ((Interface1)d1).view();

            //Method 4-
            (d1 as Interface1).show();      //This is another way of writhing mathod 3
            (d1 as Interface1).view();

            Console.ReadLine();
        }
    }

     public interface Interface1
    {
         void show();
         void view();
    }

    public class Derived : Interface1
    {
        public void show()
        {
            Console.WriteLine("Show method in derived class from Interface");
        }

        public void view()
        {
            Console.WriteLine("View method in derived class from Interface");
        }

        public void check()
        {
            Console.WriteLine("Check method in derived class own method");
        }
    }
}


namespace InterfaceDemo2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Derived1 od1 = new Derived1();
            Derived2 od2 = new Derived2();
            insertmethod(od1);
            insertmethod(od2);
            Console.ReadLine();
        }

        static void insertmethod(Interface1 od)
        {
            od.insert();
        }
    }

    public interface Interface1
    {
        void insert();
        void delete();
        void show();
    }
    


    public class Derived1 : Interface1
    {
        public void delete()
        {
            Console.WriteLine("Delete method in derived1 class from Interface");
        }

        public void insert()
        {
            Console.WriteLine("insert method in derived1 class from Interface");
        }

        public void show()
        {
            Console.WriteLine("show method in derived1 class from Interface");
        }
    }


    public class Derived2 : Interface1
    {
        public void delete()
        {
            Console.WriteLine("Delete method in derived2 class from Interface");
        }

        public void insert()
        {
            Console.WriteLine("insert method in derived2 class from Interface");
        }

        public void show()
        {
            Console.WriteLine("show method in derived2 class from Interface");
        }
    }
}