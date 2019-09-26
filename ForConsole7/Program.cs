using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            double suma = 0;
            Console.WriteLine("Введите А :");
            var intA = Console.ReadLine();
            while (!int.TryParse(intA, out a))
            {
                Console.WriteLine("Ошибка ввода A!");
                intA = Console.ReadLine();
            }
            a = Convert.ToInt32(intA);
            Console.WriteLine("Введите B :");
            var intB = Console.ReadLine();
            while (!int.TryParse(intB, out b))
            {
                Console.WriteLine("Ошибка ввода B!");
                intB = Console.ReadLine();
            }
            b = Convert.ToInt32(intB);
            for (int i = 0; i <= a; i++)
            {
                suma += Math.Pow(i, b);
            }
            Console.WriteLine($"{suma}");

        }
    }
}
