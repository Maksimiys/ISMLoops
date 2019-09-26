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
            double m = 10,p,km=0,d=0;
            p = int.Parse(Console.ReadLine());
            while(km<=200)
            {
                km += m;
                m += (m / 100) * p;
                d++;
            }
            Console.WriteLine($"{km} , {d}");
            
        }
    }
}
