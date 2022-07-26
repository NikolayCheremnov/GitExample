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
            int count = 2;
            for (int i = 0; i < 2 * r; i++)
            {
                
                for (int j = r; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < count; j++)
                {
                    Console.Write("*");
                }
                count++;
                Console.WriteLine();
            }

            Console.WriteLine($"Hello, GitHub!");
        }
    }
}
