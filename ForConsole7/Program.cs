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
            int n,m;
            double suma = 0;
            n = int.Parse(Console.ReadLine()); 
            m = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                suma += Math.Pow(i, m);
            }
            Console.WriteLine($"{suma}");

        }
    }
}
