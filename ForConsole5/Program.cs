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
            n = int.Parse(Console.ReadLine());
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
