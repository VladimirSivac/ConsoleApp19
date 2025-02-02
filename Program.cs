using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    /// <summary>
    /// Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить: а) в какой день он пробежит больше 20 км; б) в какой день суммарный пробег за все дни превысит 100 км.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = FuncA();
            int b = FuncB();
        
            Console.WriteLine($"a) День, когда пробежит больше 20 км: {a}");
            Console.WriteLine($"б) День, когда суммарный пробег больше 100 км: {b}");
        }
        
        static int FuncA()
        {
            double distance = 10;
            int day = 1;
            while (distance <= 20)
            {
                distance *= 1.1;
                day++;
            }
            return day;
        }

        static int FuncB()
        {
            double total = 10;
            double distance = 10;
            int day = 1;
            while (total <= 100)
            {
                distance *= 1.1;
                total += distance;
                day++;
            }
            return day;
        }
    }
}