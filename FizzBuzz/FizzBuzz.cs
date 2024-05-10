/*
 * Class to solve the FizzBuzz problem on Kattis.
 *
 * url: https://open.kattis.com/problems/fizzbuzz
 * author: Viktor Lundberg
 * date: 2024-05-06
 */
using System;
using System.Numerics;

namespace FizzBuzz
{
	public class FizzBuzz()
	{
		// Driver code
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int x, y, n;

			try
			{
				// Split string into words with blankspace as delimiter
				string[] words = input.Split(" ");

				// Parse words to int
				x = int.Parse(words[0]);
				y = int.Parse(words[1]);
				n = int.Parse(words[2]);
			}
			catch
			{
				Console.WriteLine("Invalid input format, please use format \"2 3 7\"");
				return;
			}

			// Early exit if invalid input rules
			if (!ValidInputRules(x, y, n))
			{
				Console.WriteLine("Invalid input rules, please note 1 <= X < Y <= N <= 100");
				return;
			}

			// Solve it
			Solve(x, y, n);
		}

		// Validate input according to input rules
		private static bool ValidInputRules(int x, int y, int n)
		{
			if (1 <= x && x < y && y <= n && n <= 100)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// FizzBuzz solve algorithm
		private static void Solve(int x, int y, int n)
		{
			for (int i = 1; i <= n; i++)
			{

				if (i % x == 0 && i % y == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % x == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % y == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}