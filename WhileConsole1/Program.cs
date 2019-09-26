using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=0;
            Console.WriteLine("Введите N :");
            var intN = Console.ReadLine();
            while (!int.TryParse(intN, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                intN = Console.ReadLine();
            }
            n = Convert.ToInt32(intN);
            while (Math.Pow(3,i)<=n)
            {
                i++;
            }
            Console.WriteLine($"{i}");
        }
    }
}
