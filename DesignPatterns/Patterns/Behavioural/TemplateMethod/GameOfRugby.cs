using System;

namespace DesignPatterns.Patterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// An example of a class implementing the template method. Here both taking the field,
    /// and playing are implemented.
    /// </summary>
    public class GameOfRugby : GameOfSport
    {
        public override string Name
        {
            get { return "Rugby"; }
        }

        public override void TakeTheField()
        {
            Console.WriteLine("The players take the field, 15 on each side.");
        }

        public override void Play()
        {
            Console.WriteLine("The match is a low-scoring affair, with only a penalty separating the two teams.");
        }
    }
}
