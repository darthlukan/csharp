using System;

namespace cat_object
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Cat cat = new Cat ("Pebbles", "Orange");
			Console.WriteLine (cat.Describe ());
			cat.Color = "Pink";
			cat.Name = "Lady";
			Console.WriteLine (cat.Describe ());
		}
	}

	public class Cat
	{
		private string name, color;

		public Cat (string name, string color)
		{
			this.name = name;
			this.color = color;
		}

		public string Name {
			get { return name; }
			set { name = value; }
		}

		public string Color {
			get { return color; }
			set { color = value; }
		}

		public string Describe ()
		{
			return string.Format ("{0} the cat is {1}!", this.Name, this.Color);
		}
	}
}
