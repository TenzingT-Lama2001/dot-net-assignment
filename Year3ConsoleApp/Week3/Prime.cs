using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.Week3
{
    public class Prime
    {
        public static void isPrime()
        {

            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check wheather it is prime or not: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }


       
    }
}