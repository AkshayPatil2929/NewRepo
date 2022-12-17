using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 c1 = new Class1();
           Console.WriteLine(c1.i);
           Console.WriteLine(c1.j);
           Console.WriteLine(c1.k);  //if namespaces is same than only we can access other partial classes in other namespace
           Console.ReadLine();

        }
    }

    public partial class Class1
    {
        public int i = 100;
    }
    
    public partial class Class1
    {
        public int j = 50;
    }
}

namespace PartialClass
{
    public partial class Class1
    {
        public int k = 300;
    }
}


//------------------------Partial Methods----------------------------
namespace PartialMethod
{
    class Program
    {
        static void Main2(string[] args)
        {
            ClassA a = new ClassA();
            Console.WriteLine(a.result());
            Console.ReadLine();
        }
    }

    public partial class ClassA
    {
        public bool isvalid = false;
        partial void check();
        public bool result()
        {
            check();
            return isvalid;
        }
    }

    public partial class ClassA
    {
        partial void check()
        {
            isvalid = true;
        }
    }
}



//------------------------Extension Methods----------------------------
namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "abc";
            //  x.display();
            ClassE.display(x);
            int i = 35;
               i = i.Add( 35);
           // i = ClassE.Add(i,35);     //same as above line
            Console.WriteLine(i);
            x.AllObject();      //35
            i.AllObject();      //abc

            ClassI i1 = new ClassI();
            i1.subtract();

            Console.ReadLine();


        }
    }


    public static class ClassE
    {
       public static void display(this string s)
        {
            Console.WriteLine(s);
        }

        public static int Add(this int i,int j)
        {
            return i + j;
           
        }

        public static void AllObject(this object o)
        {
            Console.WriteLine("Object method : "+o);
        }

        public static void subtract(this InterfaceView i)
        {
            Console.WriteLine("Interface method : " + i);
        }
    }

    public interface InterfaceView
    {
         void view();
    }
    
    public class ClassI : InterfaceView
    {
        public void view()
        {
            Console.WriteLine("View method implemented");
        }
    }
}
