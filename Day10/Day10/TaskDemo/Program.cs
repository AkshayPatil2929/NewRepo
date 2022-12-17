using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Action objAction = fun1;                                      --First way
            //Task t1 = new Task(objAction);

            //Task t1 = new Task(fun1);        //Same code as above         --Second way
            //t1.Start();


            //     Task t1 = new Task(fun1); t1.Start();         Instead of writing thes code we can directly start on same line

            //--Third way
            //   Task t1 = Task.Run(fun1);    //cant pass paramenters


            //--Fourth way
            Task t1 = Task.Factory.StartNew(fun1);  //can pass parameters
                
            Console.ReadLine();
           
        }

        //Void return type method 
        static void Main2(string[] args)
        {
            //    Action<object> objAction = fun2;
            //    Task t2 = new Task(objAction);

            //    Task t2 = new Task(fun2 ,"akshay");
            //    t2.Start();

       //     string s = "akshay";
       //     Task t2 = Task.Run(delegate () { Console.WriteLine(s); });
            Task t2 = Task.Factory.StartNew(fun2, "bbb");
            Console.ReadLine();
        
        }


        //Return type method
        //==Was not possible in thread
        static void Main3(string[] args)
        {
           

            Func<int> objfunc = fun3;
            Task t1 = new Task<int>(objfunc);
            t1.Start();

            Console.ReadLine();

        }


        //Return type method with parameters
        
        static void Main(string[] args)
        {
            Task t2 = new Task(fun5);        //Same code as above         --Second way
            t2.Start();
            Console.WriteLine("t2 : completed "+t2.IsCompleted);
           
            Func<object,int> objfunc = fun4;
            Task<int> t1 = new Task<int>(objfunc,"akshay");
            t1.Start();

            if (!t1.IsCompleted)
                t1.Wait();
            Console.WriteLine("output obtained is : "+t1.Result);  //before obtaining result make sure t1 is ended 
            
            Console.WriteLine("t1 : completed : "+t1.IsCompleted);
           
            Console.ReadLine();

        }

        private static void fun5()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Fifth functn called from {0} {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }

        private static void fun1()
        {
           for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("First functn called from {0} {1}",Thread.CurrentThread.ManagedThreadId,i );
            }
        }

        private static void fun2(object obj)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("First functn called from {0} and value passed is : {1}", i, obj.ToString());
                
                Console.WriteLine("First functn called from {0} and Type is : {1}", i, obj.GetType());
                Console.WriteLine();
            }
        }

        private static int fun3()
        {
            int i;
            for ( i = 0; i < 50; i++)
            {
                Console.WriteLine("First functn called from {0} and value passed is : {0}", i );
                Console.WriteLine();
            }
            return i;
        }

        private static int fun4(object obj)
        {
            int i;
            for (i = 0; i < 50; i++)
            {
        
                Console.WriteLine("fourth functn called from {0} and value passed is : {1}", i, obj.ToString());

                Console.WriteLine();
            }
            return i;
        }


    }
}
