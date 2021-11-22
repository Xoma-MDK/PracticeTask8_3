using System;

namespace PracticeTask8_3
{
    internal class Program
    {
        static int Fact(int a)
        {
            if (a == 0) return 1;
            return a * Fact(a - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите аргумент: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double Chis = x;
            double ElemX;
            double Znam = Fact(1);
            double SumX = 0;
            double SumX2 = 0;
            int n = 1;
            int i = 1;
            Console.WriteLine("\n{0,18} {1,0} {2,15} {3,7} {4,10} ", "номер итерации", '|', "слагаемое", '|', "сумма");
            do
            {
                ElemX = Chis / Znam;
                SumX += ElemX;
                Console.WriteLine("\n|{0,14} {1,5} {2,21} {3,1} {4,10}|", n, '|', ElemX, '|', SumX);
                Chis *= Math.Pow(x, 2);
                Znam *= Fact(i+2);
                n++;
            }
            while (Math.Abs(ElemX) > 0.01);
            x -= 1;
            i = 1;
            Chis = x;
            Znam = Fact(1);
            n = 1;
            do
            {
                ElemX = Chis / Znam;
                SumX2 += ElemX;
                //Console.WriteLine("\n|{0,14} {1,5} {2,21} {3,1} {4,10}|", n, '|', ElemX, '|', SumX2);
                Chis *= Math.Pow(x, 2);
                Znam *= Fact(i+2);
                n++;
            }
            while (Math.Abs(ElemX) > 0.01);
            Console.WriteLine($"{SumX} {SumX2}");
            Console.WriteLine($"\nF(x)={Math.Sqrt(SumX / SumX2)}");
            Console.ReadKey();
        }
    }
}
