/*
 * Class to solve the Heir's Dilemma problem on Kattis.
 *
 * url: https://open.kattis.com/problems/heirsdilemma?tab=metadata
 * author: Viktor Lundberg
 * date: 2024-05-08
 */
using System;
using System.Collections.Generic;

namespace HeirsDilemma
{
	public class HeirsDilemma
	{
		// Driver code
		public static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");
			int low = int.Parse(input[0]); // low user input value
			int high = int.Parse(input[1]); // high user input value
			int possibleCombination = 0; // count possible combinations in span

			for (int i = low; i <= high; i++)
			{
				// check if all digits are different on current i
				if (AllDifferent(i))
				{
					// if it is, check that they are divisible
					if (DivisibleByAll(i))
					{
						// if they are, count as possible combination
						possibleCombination++;
					}
				}
			}
			Console.WriteLine(possibleCombination);
		}

		public static bool AllDifferent(int n)
		{
			string numberStringed = n.ToString();
			List<char> memory = new List<char>();

			foreach (char e in numberStringed)
			{
				// check if we have seen the current char already
				if (memory.Contains(e))
				{
					return false; // duplicate found
				}
				// add each char into "memory" list we can compare to
				memory.Add(e);
			}
			return true; // test passed so no duplicates was found
		}

		public static bool DivisibleByAll(int n)
		{
			string numberStrined = n.ToString();
			List<int> numbers = new List<int>();

			// convert and add each number into a list
			foreach (char e in numberStrined)
			{
				numbers.Add(int.Parse(e.ToString()));
			}

			// make sure input n is divisible by all numbers in numbers
			foreach (int e in numbers)
			{
				// make sure we dont divide by 0
				if (e == 0)
				{
					return false;
				}

				if (n % e != 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}