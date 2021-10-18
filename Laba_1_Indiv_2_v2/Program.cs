using System;

namespace Laba_1_Indiv_2_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, e, x, f, z;
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите e"); 
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Я не собираюсь делить на ноль, выбери другое число");
                Console.ReadKey();
            }
            else
            {
                f = Math.Log(a + (x * x)) + Math.Pow(Math.Sin(x / b), 2);
                Console.WriteLine("f = " + f);

                if (x - Math.Sqrt(x - b) != 0)
                {
                    z = Math.Pow(e, -c * x) * ((x + Math.Sqrt(x + a)) / (x - Math.Sqrt(Math.Abs(x - b))));
                    Console.WriteLine("z = " + z);
                }
                else
                {
                    Console.WriteLine("ОДЗ = 0");
                }

                Console.ReadKey();
            }
            
        }
    }
}
