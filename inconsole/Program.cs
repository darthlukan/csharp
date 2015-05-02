using System;

namespace inconsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Input something:");

            string input;
            input = Console.ReadLine();
            Console.WriteLine("You put in: {0}", input);
		}
	}
}
