using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
             double suma=0;
            Console.WriteLine("Введите N :");
            var intN = Console.ReadLine();
            while (!int.TryParse(intN, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                intN = Console.ReadLine();
            }
            n = Convert.ToInt32(intN);
            for (int i=0;i<=n;i++)
            {
                suma += Math.Pow(i, n - i + 1);
            }
            Console.WriteLine($"{suma}");

        }
    }
}
