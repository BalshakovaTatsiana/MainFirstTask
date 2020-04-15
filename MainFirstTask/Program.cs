using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFirstTask
{
    class Program
    {
        static void Main(string[] args)

        {
            string yourName;
            Console.WriteLine("What is your name?");

            yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}");
        }
    }
}
