/*
 * Class to solve the Heir's Dilemma problem on Kattis.
 *
 * url: https://open.kattis.com/problems/heirsdilemma?tab=metadata
 * author: Viktor Lundberg
 * date: 2024-05-07
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
				// TODO
				// check if all digits are different on current i
				// if it is, check that they are divisible
				// if they are, count as possible combination
			}
			Console.WriteLine(possibleCombination);
		}


		public static bool AllDifferent(int n)
		{
			// TODO
			// make number a string
			// add each char into a "memory" list
			// check if there are duplicates in the list
			return false;
		}

		public static bool DivisibleByAll(int n)
		{
			// TODO
			// make number a string
			// add each char to a list but add it as separate ints
			// take each number and make sure it is % 0 to all numbers in the list
			return false;
		}
	}
}