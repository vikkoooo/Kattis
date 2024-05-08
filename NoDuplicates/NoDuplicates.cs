/*
 * Class to solve the No Duplicates problem on Kattis.
 *
 * url: https://open.kattis.com/problems/nodup?tab=metadata
 * author: Viktor Lundberg
 * date: 2024-05-07
 */
using System;
using System.Collections.Generic;

namespace NoDuplicates
{
	public class NoDuplicates
	{
		// Driver code
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] words = input.Split(" ");

			if (NoDupes(words))
				Console.WriteLine("yes");
			else if (!NoDupes(words))
				Console.WriteLine("no");
			else
				Console.WriteLine("Something wrong with input");
		}

		public static bool NoDupes(string[] words)
		{
			List<string> memory = new List<string>();

			foreach (string e in words)
			{
				// if e is in list memory, return 
				if (memory.Contains(e))
				{
					return false; //duplicate found
				}
				memory.Add(e);
			}
			return true; //passed test, no dupes
		}
	}
}