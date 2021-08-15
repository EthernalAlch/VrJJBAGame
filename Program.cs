using System;

namespace JJBAVR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello, Whats your name?");

            Console.ReadLine();

            Console.WriteLine("My name is RX-9000. I'm an AI sent from the future to destroy mankind.");
            Console.WriteLine("Whats is your favorite color");

            Console.ReadLine();

            Console.WriteLine("Cool! Mine is destruction.");

            Console.ReadKey();
        }
    }
}
