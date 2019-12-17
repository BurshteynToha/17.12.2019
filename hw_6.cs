using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big is your triangle?");
            int triangle_size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= triangle_size; i++)
            {
                for (int j = 1; j <= triangle_size; j++)
                {
                    Console.Write(j <= i ? $"{j}" : "*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }
    }
}
