using System;

namespace Laba_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, first, second, third, fourth, proisv;
            Console.WriteLine("Введите четырехзначное число:");
            number = int.Parse(Console.ReadLine());
            first = number / 1000;
            second = (number - first * 1000) / 100;
            third = (number - first * 1000 - second * 100) / 10;
            fourth = (number - first * 1000 - second * 100 - third * 10);
            proisv = first * second * third * fourth;
            Console.WriteLine("Произведение чисел = " + proisv);

        }
    }
}
