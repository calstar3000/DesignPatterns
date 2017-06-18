using System;

namespace DesignPatterns.Patterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// An example of a class implementing the template method. Here both taking the field,
    /// and playing are implemented.
    /// </summary>
    public class GameOfCricket : GameOfSport
    {
        public override string Name
        {
            get { return "Cricket"; }
        }

        public override void TakeTheField()
        {
            Console.WriteLine("The fielders take their positions. The batsmen mark their creases.");
        }

        public override void Play()
        {
            Console.WriteLine("The home side ammasses a large total before rain declares a draw.");
        }
    }
}
