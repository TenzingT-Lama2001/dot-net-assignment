
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.Week3
{
	public class Search
	{
		public static void SearchFruit()
		{

			string[] strs = { "apple", "mango", "banana", "orange", "papaya" };
			string fruit;
			Console.Write("\nEnter any fruit: ");
			fruit = Console.ReadLine().ToLower();

			if (strs.Contains(fruit))
			{
				System.Console.WriteLine("String Present");
			}
			else
			{
				System.Console.WriteLine("String Not Present");
			}
			Console.ReadLine();
		}



	}
}

