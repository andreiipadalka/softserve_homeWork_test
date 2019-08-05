using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine($"переменая а = {a}");
            Console.WriteLine($"переменая а = {b}");
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"переменая а = {a}");
            Console.WriteLine($"переменая а = {b}");
        }
    }
}
