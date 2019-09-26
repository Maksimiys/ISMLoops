using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            Console.WriteLine("Введите N :");
            var intN = Console.ReadLine();
            while (!int.TryParse(intN, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                intN = Console.ReadLine();
            }
            n = Convert.ToInt32(intN);
            double result =0; 
            for (double i=1;i<=n;i++)
            {
                result = result +  (1 / i);
            }
            Console.WriteLine($"{ result}");
        }
    }
}
