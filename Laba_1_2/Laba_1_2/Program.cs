using System;

namespace Laba_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько прошло секунд?");
            int sec = int.Parse(Console.ReadLine());
            int hour = sec / 3600;
            int min = (sec - hour * 3600) / 60;
            Console.WriteLine("Прошло {0} часов и {1} минут.", hour, min);
        }
    }
}
