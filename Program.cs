using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ievadi kateti a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ievadi kateti b:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            double S = a * b / 2;
            double P = a + b + c;

            Console.WriteLine("Hipotenūza c = " + c);
            Console.WriteLine("Laukums S = " + S);
            Console.WriteLine("Perimetrs P = " + P);

        }
    }
}