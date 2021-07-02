using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 0, sum = 0;
            while (a < 4000000) 
            { 
                c = a;
                a = b;
                b += c;
                if(c % 2 == 0)
                {
                    sum += c;
                }
            }
            Console.WriteLine("Sum: "+sum);
        }
    }
}
