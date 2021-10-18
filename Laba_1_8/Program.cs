using System;

namespace Laba_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            double rez = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine("Результат вычислений = " + rez);
        }
    }
}
