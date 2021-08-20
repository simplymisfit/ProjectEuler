using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Program
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.

        //What is the largest prime factor of the number 600851475143 ?

        public void primeFactors(double x)
        {
            int[] array = new int[9999];
            int position = 0;
            for (int i = 2; i <= x; i++)
            {
                while (x % i == 0)
                {
                    array[position] = i;
                    position++;
                    x = x / i;
                }
            }

            Console.WriteLine("Prime factors of " + x + " are: ");
            for (int i = 0; i < position; i++)
            {
                Console.WriteLine(array[i] + "\n");
            }
        }

        public static void Main(string[] args)
        {
            Program primeFactors = new Program();
            primeFactors.primeFactors(600851475143);
        }

        
    }
}
