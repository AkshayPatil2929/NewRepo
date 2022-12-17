using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asmb = Assembly.LoadFile(@"G:\Dot Net\Assignment Self\Assignment1\Assign1\bin\Debug\Assign1.exe");
         //   Console.WriteLine(asmb.FullName);
         //   Console.WriteLine(asmb.Location);
            //to get all the types i.e. Class

          Type[] arr=  asmb.GetTypes();
            foreach(Type t in arr)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(t.ToString());
                Console.WriteLine("constructors are : "+t.GetConstructors());
                MethodInfo [] minfo  =t.GetMethods();
               
                foreach (MethodInfo mi in minfo)
                {
                    Console.WriteLine("Methods name is : "+mi.Name);
                    Console.WriteLine("The parameters are :"+mi.GetParameters());
                    
                }

                
                
            }
            Console.ReadLine();
        }
    }
}
