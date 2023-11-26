using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
namespace modu_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;
            int v = 0;
            var result = MultipleReturns(a, b, c, x1, x2, v);
            switch (v)
            {
                case 1:
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {result.Item1} b={result.Item2} c={result.Item3} x1 = {result.Item4} x2 = {result.Item5}"); break;
                case 0:
                    Console.WriteLine($"Корень уравнения с коэффициентами a={result.Item1} b={result.Item2} c={result.Item3} x = {result.Item4}"); break;
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a={result.Item1} b={result.Item2} c={result.Item3} нет."); break;
            }
        }
        static Tuple<double, double, double, double, double, int> MultipleReturns(double a, double b, double c, double x1, double x2, int v)
        {
            x1 = 0;
            x2 = 0;
            double d = Math.Sqrt(b * b - 4 * a * c);
            if (d > 0)
            {
                v = 1;
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
            }
            else if (d == 0)
            {
                v = 0;
                x1 = -b / (2 * a);
            }
            else
                v = -1;
            return new Tuple<double, double, double, double, double, int>(a, b, c, x1, x2, v);
        }
    }
}