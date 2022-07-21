using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.Console;
using Humanizer;
using Lib;
using Refit;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Server=(localdb)\\MSSQLLocalDB;Database=HangfireSample;Trusted_Connection=True").UseConsole();
            BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));
            BackgroundJob.Enqueue(() => Class1.Test());
        }

        // public static void Test()
        // {
        //     Console.WriteLine("Hello World");
        // }
    }
}
