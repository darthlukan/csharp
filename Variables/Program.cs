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
			Console.ReadLine ();
		}
	}
}
