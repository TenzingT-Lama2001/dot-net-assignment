using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.week3
{
    public class SelectStatement
    {
        public static void ElseIfStatement(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than  {num2}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
        }


        public static void SwitchStatement()
        {
            Console.WriteLine("Press 1 for apple");
            Console.WriteLine("Press 2 for banana");
            Console.WriteLine("Press 3 for kiwi");


            var a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("apple");
                    break;
                case "2":
                    Console.WriteLine("banana");
                    break;
                case "3":
                    Console.WriteLine("kiwi");
                    break;
                default:
                    Console.WriteLine("Input value incorrect");
                    break;
            }
        }
    }
}