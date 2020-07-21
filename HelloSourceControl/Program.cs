using System;

namespace HelloSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            WriteStuff();
            LittleLoop();
        }
        public static void WriteStuff()
        {
            Console.WriteLine("I am writing stuff...");
        }

        public static void LittleLoop()
        {
            for (int i = 1; i <= 5; i++) 
            { 
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
