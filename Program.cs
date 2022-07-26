using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите радиус: ");
            int r = Convert.ToInt32(Console.ReadLine());
            // первая полуось
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= 10 + i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Hello, GitHub!");
        }
    }
}
