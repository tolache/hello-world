using System;

namespace Hello_World
{
    class HelloSayer
    {
        public static void SayHello(string name, int lineNumber)
        {
            Console.WriteLine("Hello {0}! This is line #{1}.", name, lineNumber);
        }
    }
}
