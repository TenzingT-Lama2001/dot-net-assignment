using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.Week3
{
    public class Swap
    {
        public static void SwapNumbers()
        {


            int number1, number2, temp;
            Console.Write("\nEnter First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }



    }
}

