using System;

namespace DesignPatterns.Patterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// The template for how a game of sport is played. Each sport inherits
    /// from this class and can customise some of the steps. Here, all matches
    /// involve shaking hands at the end of the match and this is done in the same
    /// way across all sports. Taking the field defaults to an 11-aside match
    /// like football, but can be customised for other sports. Playing must be
    /// implemented by each sport because that part of a game day is always unique.
    /// </summary>
    public abstract class GameOfSport
    {
        public abstract string Name { get; }

        /// <summary>
        /// Defaults to an 11-aside sport. Child classes can override this method.
        /// </summary>
        public virtual void TakeTheField()
        {
            Console.WriteLine("The players take the field, 11 on each side");
        }

        /// <summary>
        /// Must be implemented by each child class.
        /// </summary>
        public abstract void Play();

        /// <summary>
        /// All sports shake hands in the same way.
        /// </summary>
        public void ShakeHands()
        {
            Console.WriteLine("The players shake hands at the end of the match.");
        }
    }
}
