using DesignPatterns.Patterns.Creational.Builder.Interfaces;

namespace DesignPatterns.Patterns.Creational.Builder
{
    /// <summary>
    /// An example of a product built by the Builder
    /// </summary>
    public class BuilderPotatoTopPie : IPieBuilder
    {
        Pie _pie;

        public BuilderPotatoTopPie()
        {
            _pie = new Pie("Potato Top Pie");
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
            _pie.parts.Add("Filling", "Mince");
        }

        public void AddToppig()
        {
            _pie.parts.Add("Topping", "Potato lid");
        }
    }
}
