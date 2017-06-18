using System;

namespace DesignPatterns.Patterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// An example of a class implementing the template method. Here the only method
    /// properly implemented is the play method.
    /// </summary>
    public class GameOfFootball : GameOfSport
    {
        public override string Name
        {
            get { return "Football"; }
        }

        public override void TakeTheField()
        {
            base.TakeTheField();
        }

        public override void Play()
        {
            Console.WriteLine("The players contest the football match.");
        }
    }
}
