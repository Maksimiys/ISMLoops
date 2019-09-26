using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a , b , suma = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());


            for (int i = a; i <= b; i++)
            {
                suma += i*i;
            }
            Console.WriteLine($"{ suma}");
        }
    }
}
