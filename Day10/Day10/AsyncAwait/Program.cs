using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Before");
            string message =await DoWorkAsync();   //Its waiting call on different thread doesnot hold main
            Console.WriteLine(message);
            Console.WriteLine("After");
            Console.ReadLine();
        }

         static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Done with work!";
            });
        }
    }
}
