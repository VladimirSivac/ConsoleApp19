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
            int sum = Func(1, 4);
            Console.WriteLine($"Сумма пяти членов: {sum}");
        }
        
        static int Func(int a1, int d)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int term = a1 + i * d;
                Console.Write($"{term} ");
                sum += term;
            }
            return sum;
        }
    }
}