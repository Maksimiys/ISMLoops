using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a , b , suma = 1;
            Console.WriteLine("Введите А :");
            var intA = Console.ReadLine();
            while(!int.TryParse(intA,out a))
            {
                Console.WriteLine("Ошибка ввода!");
                intA = Console.ReadLine();
            }
            a = Convert.ToInt32(intA);
            b = int.Parse(Console.ReadLine());

            for (int i=a;i<=b;i++)
            {
                suma *= i;
            }
            Console.WriteLine($"{ suma}");
        }
    }
}
