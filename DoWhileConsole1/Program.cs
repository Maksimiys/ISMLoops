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
            int suma = 0,a;
             while (a = int.Parse(Console.ReadLine()))
            {
                suma += a;
                if (a == 0)
                    break;
            }
        }
    }
}
