using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Tharun!");
            string signal = "";
            while(signal != " ")
            {
                Console.WriteLine("Press Space Bar and Enter to exit:");
                signal = Console.ReadLine(); // prompts user input to exit the program
            }
            Console.WriteLine("Done.");
        }
    }
}
