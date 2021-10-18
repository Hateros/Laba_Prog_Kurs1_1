using System;

namespace Laba_1_Indiv_1_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое государство:");
            string ex11 = Console.ReadLine();
            Console.WriteLine("Введите столицу этого государства:");
            string ex12 = Console.ReadLine();
            Console.WriteLine("Введите население государства:");
            int ex13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Строй государства (Ф - федерация, УГ - унитарное государство):");
            string ex14 = Console.ReadLine();
            Console.WriteLine("Введите второе государство:");
            string ex21 = Console.ReadLine();
            Console.WriteLine("Введите столицу этого государства:");
            string ex22 = Console.ReadLine();
            Console.WriteLine("Введите население государства:");
            int ex23 = int.Parse(Console.ReadLine());
            Console.WriteLine("Строй государства (Ф - федерация, УГ - унитарное государство):");
            string ex24 = Console.ReadLine();
            Console.WriteLine("Введите третье государство:");
            string ex31 = Console.ReadLine();
            Console.WriteLine("Введите столицу этого государства:");
            string ex32 = Console.ReadLine();
            Console.WriteLine("Введите население государства:");
            int ex33 = int.Parse(Console.ReadLine());
            Console.WriteLine("Строй государства (Ф - федерация, УГ - унитарное государство):");
            string ex34 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("География");
            Console.WriteLine("Государство\tСтолица\t\tНаселение\t\tСтрой");
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", ex11, ex12, ex13, ex14);
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t\t{3}", ex21, ex22, ex23, ex24);
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", ex31, ex32, ex33, ex34);
            Console.WriteLine("Перечисляемый тип: Ф - федерация, УГ - унитарное государство");
            Console.ReadKey();

        }
    }
}
