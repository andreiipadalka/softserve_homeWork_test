using System;

namespace v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine($"переменая а = {a}");
            Console.WriteLine($"переменая а = {b}");
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"переменая а = {a}");
            Console.WriteLine($"переменая а = {b}");
        }
    }
}
