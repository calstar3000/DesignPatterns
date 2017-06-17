using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    /// <summary>
    /// This class simulates a game that is 'observed'.
    /// When its prices changes, its observers are notified.
    /// </summary>
    public class Game
    {
        private string _name;
        private double _price;
        private List<Gamer> _observers;

        public Game(string name, double price)
        {
            _name = name;
            _price = price;
            _observers = new List<Gamer>();
        }

        public string Name
        {
            get { return _name; }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                
                foreach (var observer in _observers)
                {
                    observer.Notify(this);
                }
            }
        }

        public void Wishlist(Gamer gamer)
        {
            _observers.Add(gamer);
        }
    }
}
