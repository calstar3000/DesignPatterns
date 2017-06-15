using System;

namespace DesignPatterns.Patterns.Builder
{
    /// <summary>
    /// An example of a product built by the Builder
    /// </summary>
    public class MinceAndCheesePieBuilder : IPieBuilder
    {
        Pie _pie;

        public MinceAndCheesePieBuilder()
        {
            _pie = new Pie("Mince and Cheese Pie");
        }

        public Pie PieInstance
        {
            get { return _pie; }
        }

        public void MakePastry()
        {
            _pie.parts.Add("Pastry", "Flaky puff");
        }

        public void AddFilling()
        {
            _pie.parts.Add("Filling", "Mince, cheese");
        }

        public void AddToppig()
        {
            _pie.parts.Add("Topping", "Pastry lid");
        }
    }
}
