using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Builder
{
	/// <summary>
	/// Represents a product of the Builder, in this case a pie.
	/// The pie has a name and is made up of parts (pastry, filling, topping).
	/// </summary>
	public class Pie
	{
		private string _name;

		public Dictionary<string, string> parts;

		public Pie(string name)
		{
			this._name = name;
			this.parts = new Dictionary<string, string>();
		}

		public void Display()
		{
			Console.WriteLine(string.Format("Pie: {0}", _name));

			foreach (var key in this.parts.Keys)
			{
				Console.WriteLine(string.Format("{0}: {1}", key, parts[key]));
			}

			Console.WriteLine();
		}
	}
}
