using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.Week3
{
    public class OddEven
    {
        public static void isOddEven()
        {

            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("The Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("The Number is an Odd Number");
                Console.Read();
            }
        }



    }
}