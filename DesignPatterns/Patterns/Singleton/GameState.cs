using System;

namespace DesignPatterns.Patterns.Singleton
{
	public class GameState
	{
		/// <summary>
		/// The singular instance of this class to be returned
		/// </summary>
		private static GameState _instance;

		/// <summary>
		/// Constructor cannot be accessed outside this class
		/// </summary>
		protected GameState()
		{
		}

		/// <summary>
		/// Only create a new instance if it doesn't already exist.
		/// Otherwise, just return the existing instance.
		/// </summary>
		/// <returns></returns>
		public static GameState Instance()
		{
			if (_instance == null)
			{
				Console.WriteLine("Returning new instance...");

				_instance = new GameState();
			} 
			else
			{
				Console.WriteLine("Returning existing instance...");
			}

			return _instance;
		}
	}
}
