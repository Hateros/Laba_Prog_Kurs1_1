using System;

namespace Laba_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную:");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Новое значение первой переменной = {0}; второй = {1}", a, b);
        }
    }
}
