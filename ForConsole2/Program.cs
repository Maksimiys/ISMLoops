using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            n = int.Parse(Console.ReadLine());
            double result =0; 
            for (double i=1;i<=n;i++)
            {
                result = result +  (1 / i);
            }
            Console.WriteLine($"{ result}");
        }
    }
}
