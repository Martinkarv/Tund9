using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the numbers and the count on the console.
            /*
             * int counter = 0;
            for(int i = 1; i <= 100;i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                    counter++;

                }
                Console.WriteLine($"Total {counter}");
                
                
            }
            */

            //Task2- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the numbers, display "you won"!, otherwise,
            //display "you lost!"
            Start:
            Random randomGenerator = new Random();
            int cpuRoll = randomGenerator.Next(1, 11);
            
            Console.WriteLine("Hello, try to guess the number I picked from 1 to 10!");

            int totalAnswers = 0;

            while (totalAnswers < 4)
            {
                int userChoice = int.Parse(Console.ReadLine());
                totalAnswers++;

                if (userChoice == cpuRoll)
                {
                    Console.WriteLine("You Won!");
                    Console.ReadLine();
                }

            }

            
            {
                Console.WriteLine("You Lost!");
              
            }
            Console.WriteLine($"My number was {cpuRoll}!");
            goto Start;
            Console.ReadLine();
        }
    }
}
