using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund9Teine
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  //DRY-Do not repeat yourself
            int a = 5;
            int b = 5;
            int c = a + b; 
            */
            Hello();
            string name;
            Console.WriteLine("Enter your name, please.");
            name = Console.ReadLine();
            GreetByName(name);
            Console.ReadLine();
        }

        public static void Hello()
        {
            Console.WriteLine("Hello!");
        }
        
        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
}
