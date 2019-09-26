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
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                suma += Math.Pow(i, n - i + 1);
            }
            Console.WriteLine($"{suma}");

        }
    }
}
