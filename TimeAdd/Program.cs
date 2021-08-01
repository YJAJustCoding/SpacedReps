using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("spaced repetition schedule Calendar");

            var d = DateTime.Today;
            //var d = dateAndTime.Date;

            Console.WriteLine(d);

            Console.WriteLine("Spaced Repition Schedule");

            Console.WriteLine("\n");
            Console.WriteLine(d.AddDays(1));
            Console.WriteLine("\n");
            Console.WriteLine(d.AddDays(8));
            Console.WriteLine("\n");
            Console.WriteLine(d.AddDays(16));
            Console.WriteLine("\n");
            Console.WriteLine(d.AddDays(30));
            Console.WriteLine("\n");
            Console.WriteLine(d.AddDays(90));

            Console.ReadLine();



        }
    }
}
