using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0,n;
             while (true)
            { 
                Console.WriteLine("Введите N :");
            var intN = Console.ReadLine();
            while (!int.TryParse(intN, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                intN = Console.ReadLine();
            }
            n = Convert.ToInt32(intN);
            suma += n;
                if (n == 0)
                    break;
            }
            Console.WriteLine($"Ответ : { suma}");
        }
    }
}
