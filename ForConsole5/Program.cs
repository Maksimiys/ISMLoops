using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k=1;
            Console.WriteLine("Введите N :");
            var intN = Console.ReadLine();
            while (!int.TryParse(intN, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                intN = Console.ReadLine();
            }
            n = Convert.ToInt32(intN);
            long  suma = 0;
            for(int i=1;i<=n;i++)
            {
                k *= i;
                suma += k ;
            }
            Console.WriteLine($"{ suma}");
        }
    }
}
