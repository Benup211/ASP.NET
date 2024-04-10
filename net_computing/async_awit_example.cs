using System;

namespace ConsoleApp
{
    class Program
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    System.Console.WriteLine("Method1");
                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("Method2");
            }
        }
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
    }
}