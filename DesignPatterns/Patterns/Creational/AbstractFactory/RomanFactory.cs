using System;

namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of one of the factories.
    /// </summary>
    public class RomanFactory : AbstractFactory
    {
        public override void CreateSwordsman()
        {
            Console.WriteLine("Centurion swordsman added to the ranks of the mighty Roman Empire.");
        }

        public override void CreateArcher()
        {
            Console.WriteLine("Sagittarii archer added to the ranks of the mighty Roman Empire.");
        }
    }
}
