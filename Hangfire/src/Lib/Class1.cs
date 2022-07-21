using System;
using System.Threading.Tasks;

namespace Lib
{
    public class Class1
    {
        public static async Task Test()
        {
            Console.WriteLine("Hello World");
            await Task.CompletedTask;
        }
    }
}
