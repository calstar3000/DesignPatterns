using System;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    /// <summary>
    /// This class simulates a summer sale where games are discounted.
    /// Any games who have wishlisted the game are notified when its price
    /// changes.
    /// </summary>
    public class SummerSale
    {
        public void Start()
        {
            var anne = new Gamer("Anne");
            var bob = new Gamer("Bob");
            var cathy = new Gamer("Cathy");
            var game = new Game("GTA V", 99.99);

            game.Wishlist(anne);
            game.Wishlist(bob);
            game.Wishlist(cathy);

            Console.WriteLine(string.Format("Discounting {0}", game.Name));
            game.Price = 49.99;
        }
    }
}
