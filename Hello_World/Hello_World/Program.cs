using System;
using Newtonsoft.Json;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloSayer.HelloSayer.SayHello("World", 2);
            Console.WriteLine(useNewtonsoftJson());
            Console.ReadKey();
        }
        private static string useNewtonsoftJson()
        {
            Account account = new Account
            {
                Name = "John Doe",
                Email = "john@microsoft.com",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            return json;
        }
    }
}