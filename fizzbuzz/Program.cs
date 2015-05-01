using System;

namespace fizzbuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] nums = { 100, 22, 13, 15, 24, 32, 30, 40, 90, 55 };

			foreach (int num in nums) {
				if (num % 3 == 0 && num % 5 == 0) {
					Console.WriteLine (num + ": FizzBuzz!");
				} else if (num % 3 == 0) {
					Console.WriteLine (num + ": Fizz!");
				} else if (num % 5 == 0) {
					Console.WriteLine (num + ": Buzz!");
				} else {
					Console.WriteLine (num);
				}
			}
		}
	}
}