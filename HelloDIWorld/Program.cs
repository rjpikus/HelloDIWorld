using System;

namespace HelloDIWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string Command1;
            Console.WriteLine("V^V online");
            Command1 = Console.ReadLine();
            if (Command1 == "hello")
            {
                Console.WriteLine("world!");
            }

            else
            {
                Console.WriteLine("Error: Did not type 'hello'");
            }

            //next step is to compare to HelloDI
        }
    }
}
