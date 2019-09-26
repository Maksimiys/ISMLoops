using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = 10,n,km=0,d=0;
            Console.WriteLine("Введите N :");
            var intN = Console.ReadLine();
            while (!double.TryParse(intN, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                intN = Console.ReadLine();
            }
            n = Convert.ToInt32(intN);
            while (km<=200)
            {
                km += m;
                m += (m / 100) * n;
                d++;
            }
            Console.WriteLine($"Километры :{km} Дни : {d}");
            
        }
    }
}
