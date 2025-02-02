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
            PrintFirstFiveNumbers(1, 4);
        }
        
        static void PrintFirstFiveNumbers(int a1, int d)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{a1 + i * d} ");
            }
        }
    }
}