using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = Sum(150, -200, 0.2);
            Console.WriteLine($"Сумма первых 150 членов: {sum}");
        }
        
        static double Sum(int n, double a1, double d)
        {
            return n / 2 * (2 * a1 + (n - 1) * d);
        }
    }
}