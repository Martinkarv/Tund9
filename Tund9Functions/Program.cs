using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund9Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your favourite color.");
            color = Console.ReadLine();
            KnowMe(name, color);
            Console.ReadLine();

        }

        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello, {name}. Your favourite color is {color}!");

        }


    }
}
