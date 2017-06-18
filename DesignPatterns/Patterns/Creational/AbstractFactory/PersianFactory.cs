using System;

namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of one of the factories.
    /// </summary>
    public class PersianFactory : AbstractFactory
    {
        public override void CreateSwordsman()
        {
            Console.WriteLine("Daylami swordsman added to the ranks of the glorious Sasanian Empire!");
        }

        public override void CreateArcher()
        {
            Console.WriteLine("Kamandaran swordsman added to the ranks of the glorious Sasanian Empire!");
        }
    }
}
