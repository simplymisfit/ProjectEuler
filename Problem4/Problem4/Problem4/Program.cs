using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    //Find the largest palindrome made from the product of two 3-digit numbers.

    public class Program
    {
        public void largestPalindrome()
        {
            bool isFound = false;
            int firstHalf = 998, palindrome = 0;
            int[] factors = new int[2];

            while (!isFound)
            {
                firstHalf--;
                palindrome = isPalindrome(firstHalf);
                for (int i = 999; i >= 100; i--)
                {
                    if ((palindrome / i) > 999 || i * i < palindrome)
                    {
                        break;
                    }

                    if ((palindrome % i == 0))
                    {
                        isFound = true;
                        factors[0] = palindrome / i;
                        factors[1] = i;
                        break;
                    }
                }
            }

            Console.WriteLine("Palindrome: {0}\nmade of {1}*{2}", palindrome, factors[0], factors[1]);
        }

        private int isPalindrome(int firstHalf)
        {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.largestPalindrome();
        }
    }
}
