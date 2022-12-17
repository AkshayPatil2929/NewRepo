using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
     //   int x = 29;
        static void Main(string[] args)
        {
            int p = 45;
            //      System.Console.WriteLine("Helloworld");



            Test t = new Test();
            //      t.add(10,20 );              //30
            //      t.add(10, 20,30);           //60
            //      t.add(x: 10, y: 20, z: 30); //60
            //      t.add(x: 10,  20, z: 30);   //60
            //      t.add(x: 10,  z: 30);       //Error occurs
            //      t.add(x: 10,  y: 30);       //40
            //      t.add(x: 10,20, z: 30);     //60
            //      t.add(x: 10, y: 20);        //30
            // System.Console.WriteLine("b : "+b); Error -cannot access inner function from outer  

     //    ConsoleApp2.Program2 pg = new ConsoleApp2.Program2();//Differet name space
      //     pg.add(15,30,45);  // 90




            void Local()
            {
                System.Console.WriteLine("Enter the value of a : ");
                //  int a = Console.Read();
                int a = 78;
             //   int b = 99;
                System.Console.WriteLine("Value of a : " + a+ "Value of p : " + p); //can access p from outer function
            //    System.Console.WriteLine(" Value of variable from other class : " + t.value);  //cant access t.value outside the outer function/ class
            //    System.Console.WriteLine("Value of x : "+x);  //cant accessx outside outerfunction

            }
            Local();


            Console.ReadLine();
        }
    }
    
    class Test
    {
       // int value = 48;
        public void add(int x, int y,int z=0)  //The method is called from Program class
        {
            System.Console.WriteLine("The Sum is : " + (x +y+z));

        }
    }
}

namespace ConsoleApp2
{
    class Program2
    {
        public void add(int e=0,int f=0,int j=0)
        {
            System.Console.WriteLine("Sum in namespace ConsoleApp2 : " + (e+f+j));
        }
    }
}