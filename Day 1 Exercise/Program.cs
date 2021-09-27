using System;

namespace Day_1_Exercise
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Hello! Welcome to the Indetity Stealer");
            Console.Write("Please enter your name: ");
            string UserName = Console.ReadLine();

            Console.Write("Please enter your name: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your hometown: ");
            string hometown = Console.ReadLine();

            Console.WriteLine("Please enter your favorite food: ");
            string food = Console.ReadLine();
            Console.WriteLine($"Your name is {UserName}. Your age is {age}. Your hometown is {hometown}. Your favorite food is {food}.");
        }
    }
}
