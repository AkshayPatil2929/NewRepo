using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
               Console.Write("Enter arr[{0}] : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int pos1 = Array.IndexOf(arr,10);
            Console.WriteLine("Index of : " + pos1);
            int pos2 = Array.LastIndexOf(arr, 20);
            Console.WriteLine("LastIndexof : " + pos2);
            int pos3 = Array.BinarySearch(arr, 30);
            Console.WriteLine("Binary Search : " + pos3);



           /* Array.Clear(arr, 0, 2);
            foreach (int arrays in arr)
            {
                Console.WriteLine(arrays);
            }*/

            Array.Sort(arr);
            Console.WriteLine("Sorted array");
            foreach (int arrays in arr)
            {
                Console.WriteLine(arrays);
            }
            Array.Reverse(arr);
            Console.WriteLine("Sorted array");
            foreach (int arrays in arr)
            {
                Console.WriteLine(arrays);
            }
        /*    for (int i=0;i<arr.Length;i++)
            {
             //   Console.Write("Enter arr[{0}] : ",i);
                Console.WriteLine($"The  arr[{i}] : {arr[i]}");

            }*/
        /*   foreach(int arrays in arr)
           {
               Console.WriteLine(arrays);
           }*/
        Console.ReadLine();
        }
    }
}
