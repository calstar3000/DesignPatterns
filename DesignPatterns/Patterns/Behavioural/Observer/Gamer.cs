using System;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    /// <summary>
    /// This class represents a gamer or 'observer' of a game
    /// in the games sale. The notify method is called when
    /// the price of the game changes.
    /// </summary>
    public class Gamer
    {
        string _name;

        public Gamer(string name)
        {
            _name = name;
        }

        public void Notify(Game game)
        {
            Console.WriteLine(string.Format("Notified {0} of {1} change to {2:C}", _name, game.Name, game.Price));
        }
    }
}
