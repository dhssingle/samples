using System;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/formatting-types
            Console.WriteLine(String.Format("It is now {0:d} at {0:t}", DateTime.Now));
            Console.WriteLine($"It is now {DateTime.Now:d} at {DateTime.Now:t}");
            // Output similar to: 'It is now 4/10/2015 at 10:04 AM'

            Console.WriteLine();
            // 右对齐
            Console.WriteLine(String.Format("{0,6} {1,15}\n", "Year", "Population"));
            Console.WriteLine(String.Format("{0,6} {1,15:N0}", 2019, 1105967));
            Console.WriteLine(String.Format("{0,6} {1,15:N0}\n", 2020, 1025632));
            // 左对齐
            Console.WriteLine(String.Format("{0,-10} {1,-0}\n", "Year", "Population"));
            Console.WriteLine(String.Format("{0,-10} {1,-0:N0}", 2019, 1105967));
            Console.WriteLine(String.Format("{0,-10} {1,-0:N0}", 2020, 1025632));


        }
    }
}
