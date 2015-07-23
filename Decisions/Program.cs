using System;

namespace Decisions
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Enter a value:");
//			string value;
//			value = Console.ReadLine ();
//
//			Console.WriteLine ("You typed: " + value);
//			Console.ReadLine ();

			string choice;
			string message;
			Console.WriteLine ("Door number 1, 2, or 3?");
			choice = Console.ReadLine ();

			if (choice == "1") {
				message = "You won a car!";
			} else if (choice == "2") {
				message = "You won a boat!";
			} else if (choice == "3") {
				message = "You won a cat!";
			} else {
				message = "That was not one of the available choices. You win nothing!";
			}

			Console.WriteLine (message);
		}
	}
}
