using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=0;
            n = int.Parse(Console.ReadLine());
            while(Math.Pow(3,i)<=n)
            {
                i++;
            }
            Console.WriteLine($"{i}");
        }
    }
}
