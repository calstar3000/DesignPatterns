using DesignPatterns.Patterns.Creational.Builder.Interfaces;

namespace DesignPatterns.Patterns.Creational.Builder
{
    /// <summary>
    /// An example of a product built by the Builder
    /// </summary>
    public class BlueberryPieBuilder : IPieBuilder
    {
        Pie _pie;

        public BlueberryPieBuilder()
        {
            _pie = new Pie("Blueberry Pie");
        }

        public Pie PieInstance
        {
            get { return _pie; }
        }

        public void MakePastry()
        {
            _pie.parts.Add("Pastry", "Short crust");
        }

        public void AddFilling()
        {
            _pie.parts.Add("Filling", "Blueberries, sugar");
        }

        public void AddToppig()
        {
            _pie.parts.Add("Topping", "Lattice lid");
        }
    }
}
