using System;

namespace Laba_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo, fi, se, th;
            Console.WriteLine("Введите трехзначное число:");
            chislo = int.Parse(Console.ReadLine());
            fi = chislo / 100;
            se = (chislo - fi * 100) / 10;
            th = (chislo - fi * 100 - se * 10);
            Console.WriteLine("Число наоборот: " + th + se + fi);
        }
    }
}
