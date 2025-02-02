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
            double total = TotalSavings(10);
            Console.WriteLine($"Сумма через 10 месяцев: {total} руб.");
        }
        
        static double TotalSavings(int months)
        {
            double sum = 0;
            for (int i = 0; i < months; i++)
            {
                sum += 100 + i * 50;
            }
            return sum;
        }
    }
}