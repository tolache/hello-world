using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This line 2. Wow!");
            Console.WriteLine("This line 3.");
            HelloSayer.SayHello("dude");
            Console.ReadKey();
        }
    }
}
