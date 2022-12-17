using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFile(@"G:\Dot Net\By SIr\Day11\ReflectionExample\UKCalculator\bin\Debug\UKCalculator.dll");
           
            Type t = asm.GetType(asm.GetName().Name + ".TaxCalculator", true, true);
            Console.WriteLine("type is : " +t.GetTypeInfo());
            object obj = Activator.CreateInstance(t);
            Console.WriteLine("Object type  is : " + obj.GetType());
    
            
            PropertyInfo pi=t.GetProperty("Basic");
            pi.SetValue(obj, 45000.0M, null);
            Console.WriteLine(pi.GetValue(obj,null).ToString());
           


           MethodInfo mi= t.GetMethod("GetNetSalary");
            decimal NetSal =((decimal)mi.Invoke(obj,null));
            Console.WriteLine(NetSal.ToString());
            Console.ReadLine();
        }

        static void Main1(string[] args)
        {
            Assembly asmb = Assembly.LoadFile(@"G:\Dot Net\By SIr\Day11\ReflectionExample\UKCalculator\bin\Debug\UKCalculator.dll");

           Type t1 = asmb.GetType(asmb.GetName().Name + ".TaxCalculator", true, true);
            Object obj = Activator.CreateInstance(t1);

            PropertyInfo pi1=t1.GetProperty("Basic");
            pi1.SetValue(obj, 45000.00M, null);
            Console.WriteLine(pi1.GetValue(obj, null).ToString());

            MethodInfo mi1 = t1.GetMethod("GetNetSalary");
          decimal sal=  ((decimal)mi1.Invoke(obj, null));
            Console.WriteLine(sal);
            Console.ReadLine();
        }
    }
}
