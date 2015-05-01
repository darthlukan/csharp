using System;

namespace fizzbuzz_function
{
	class MainClass
	{
		public static string FizzBuzzMessage (int num)
		{
			string msg;

			if (num % 3 == 0 && num % 5 == 0) {
				msg = num + ": FizzBuzz!";
			} else if (num % 3 == 0) {
				msg = num + ": Fizz!";
			} else if (num % 5 == 0) {
				msg = num + ": Buzz!";
			} else {
				msg = num.ToString ();
			}
			return msg;
		}

		public static void Main (string[] args)
		{
			int[] nums = { 100, 22, 13, 15, 24, 32, 30, 40, 90, 55 };

			foreach (int num in nums) {
				Console.WriteLine (FizzBuzzMessage (num));
			}
		}
	}
}
