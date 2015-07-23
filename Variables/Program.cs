using System;

namespace Variables
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			int x;
			int y;

			x = 7;
			y = x + 3;
			Console.WriteLine (y);
			*/

			int x = 7;
			string myFirstName = "Brian";

			// Implicit type conversion o.0
			string tryThis = x + myFirstName;
			// >> 7Brian
			Console.WriteLine (tryThis);

			// This compiles, but with warnings and breaks at runtime (as expected)
			// int anotherTry = x + int.Parse (myFirstName);
			// Console.WriteLine (anotherTry);

			string y = "5";
			int yetAnotherTry = x + int.Parse (y);
			// Output >> 12
			Console.WriteLine (yetAnotherTry);
		}
	}
}
