using System;

namespace Laba_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s, p;
            Console.WriteLine("Введите длину первого катета:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета");
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            s = 0.5 * a * b;
            p = a + b + c;
            Console.WriteLine("Периметр = {0}, Площадь = {1}", p, s);
        }
    }
}
