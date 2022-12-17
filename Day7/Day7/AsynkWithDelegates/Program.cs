using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynkWithDelegates
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("FIRST");
            Action o = Display;
            //   o();      this will again waith for display to end fully i.e. sync
            o.BeginInvoke(null, null);   //async call , i.e. on different thread
            Action s = Show;
            s.BeginInvoke(null, null);    //async call , i.e. on different thread
            Console.WriteLine("LAST");
            Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(3000);  //This will dilay displaye method by 3 seconds but will wait for it to fully complete
            Console.WriteLine("Display Called");
        }

        static void Show()
        {
            System.Threading.Thread.Sleep(3000);  //This will dilay displaye method by 3 seconds but will wait for it to fully complete
            Console.WriteLine("Show Called");
        }
    }

    class Program2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("FIRST");
            Action<string> o = Display;
            //   o();      this will again waith for display to end fully i.e. sync
            o.BeginInvoke("Hello", null, null);   //async call , i.e. on different thread
            Action<string> s = Show;
            s.BeginInvoke("Welcome",null, null);    //async call , i.e. on different thread
            Console.WriteLine("LAST");
            Console.ReadLine();
        }

        static void Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called "+s );
        }

        static void Show(string p)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Show Called "+p);
        }
    }


    class Program3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("FIRST");
            Func<string,string> o = Display;
            //   o();      this will again waith for display to end fully i.e. sync
            o.BeginInvoke("Hello", CallbackFunction, null);   //async call , i.e. on different thread
            Func<string, string> s = Show;
            s.BeginInvoke("Welcome", CallbackFunctionsh, null);    //async call , i.e. on different thread
            Console.WriteLine("LAST");
            Console.ReadLine();
        }

        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called " + s);
            return s.ToUpper();    //Return a copy of uppercase of s
        }

        static string Show(string p)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Show Called " + p);
            return p.ToUpper();    //Return a copy of uppercase of p
        }

       static void CallbackFunction(IAsyncResult asy)  //Respresnts the status of asynchnorous operation
        {
            Console.WriteLine("Call baclk function for display called");
        }

        static void CallbackFunctionsh(IAsyncResult asynk)  //Respresnts the status of asynchnorous operation
        {
            Console.WriteLine("Call baclk function for show called");
        }
    }


    class Program4
    {
       static Func<string, string> o;
        static Func<string, string> s;
        static void Main(string[] args)
        {
            Console.WriteLine("FIRST");
                o = Display;
            //   o();      this will again waith for display to end fully i.e. sync
            IAsyncResult ar=  o.BeginInvoke("Hello", CallbackFunction, null);   //async call , i.e. on different thread
                s = Show;
            IAsyncResult sr=   s.BeginInvoke("Welcome", CallbackFunctionsh, null);    //async call , i.e. on different thread
            Console.WriteLine("LAST");
            Console.ReadLine();
        }

        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called " + s);
            return s.ToUpper();    //Return a copy of uppercase of s
        }

        static string Show(string p)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Show Called " + p);
            return p.ToUpper();    //Return a copy of uppercase of p
        }

        static void CallbackFunction(IAsyncResult asy)  //Respresnts the status of asynchnorous operation
        {
            Console.WriteLine("Call baclk function for display called");
            string val;
            val = o.EndInvoke(asy);
            Console.WriteLine("return value :" + val);
        }

        static void CallbackFunctionsh(IAsyncResult asynk)  //Respresnts the status of asynchnorous operation
        {
            Console.WriteLine("Call baclk function for show called");
            string val;
            val = s.EndInvoke(asynk);
            Console.WriteLine("return value :" + val);
        }
    }

}