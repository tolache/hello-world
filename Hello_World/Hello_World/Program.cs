using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This line 2. Wow!");
            Console.WriteLine("This line 3.");

            for (int line = 4; line <= 5; line++)
            {
                HelloSayer.SayHello("dude", line);
            }

            Console.ReadKey();
        }
    }
}
