using System;

namespace Laba_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a1:");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b1:");
            float b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c1:");
            float c1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d1:");
            float d1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите a2:");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b2:");
            float b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c2:");
            float c2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d2:");
            float d2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите a3:");
            float a3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b3:");
            float b3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c3:");
            float c3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d3:");
            float d3 = float.Parse(Console.ReadLine());
            float x, y, z, ay, ad, az, ax;
            ax = a1 * b1 / c1;
            ay = a2 * a1 / a1;
            az = c1 * a2 / a1;
            ad = d1 * a2 / a1;
            a2 = a2 - ax;
            b2 = b2 - ay;
            c2 = c2 - az;
            d2 = d2 - ad;
            ax = a1 * a3 / a1;
            ay = b1 * a3 / a1;
            az = c1 * a3 / a1;
            ad = d1 * a3 / a1;
            a3 = a1 - ax;
            b3 = b3 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            ay = b2 * b3 / b3;
            az = c2 * b3 / b2;
            ad = c2 * b3 / b2;
            b2 = b2 - ay;
            c3 = c3 - az;
            d3 = d3 - ad;
            z = d3 / c3;
            y = (c2 - b2 * z) / b2;
            x = (d1 - c1 * z - b1 * y) / a1;
            Console.WriteLine("Ответ: x = {0}; y = {1}; z = {2}", x, y, z);

        }
    }
}
