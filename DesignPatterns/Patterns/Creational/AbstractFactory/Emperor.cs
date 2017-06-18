using System;

namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// The client of the factory. The factory is chosen at runtime based on
    /// user input. The chosen factory is then used to create soldiers for an
    /// army.
    /// </summary>
    public class Emperor
    {
        public void SummonArmy()
        {
            Console.WriteLine("Choose your empire:");
            Console.WriteLine("Press 1 for Romans");
            Console.WriteLine("Press 2 for Persians");

            string input = Console.ReadLine();

            if (input == "1")
            {
                SummonTroops(new RomanFactory());
                
            }
            else if (input == "2")
            {
                SummonTroops(new PersianFactory());
            }
            else
            {
                Console.WriteLine("Unknown empire selected");
            }
        }

        private void SummonTroops(AbstractFactory factory)
        {
            Console.WriteLine("Press 1 for swordsman");
            Console.WriteLine("Press 2 for archer");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "1")
                {
                    factory.CreateSwordsman();
                }
                else if (input == "2")
                {
                    factory.CreateArcher();
                }
                else
                {
                    Console.WriteLine("Unknown soldier selected");
                }
            }
        }
    }
}
