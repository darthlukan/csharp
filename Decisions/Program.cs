using System;

namespace Decisions
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a value:");
			string value;
			value = Console.ReadLine ();

			Console.WriteLine ("You typed: " + value);
			Console.ReadLine ();
		}
	}
}
