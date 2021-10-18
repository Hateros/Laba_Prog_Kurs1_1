using System;

namespace Laba_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько прошло часов?");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько прошло минут?");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько прошло секунд?");
            int sec = int.Parse(Console.ReadLine());
            //1 час = 30 градусов, 1 минута = 0,5 градусов, 1 секунда = 0.0083 градуса
            int AngHour = hour * 30;
            double AngMin = (double)(min * 0.5);
            double AngSec = (double)(sec * 0.0083);
            int TotalAng1 = (int)(AngHour + AngMin + AngSec);
            int TotalAng2 = 360 - TotalAng1;
            Console.WriteLine("Угол составляет {0} градусов, или же {1}", TotalAng1, TotalAng2);
        }
    }
}
