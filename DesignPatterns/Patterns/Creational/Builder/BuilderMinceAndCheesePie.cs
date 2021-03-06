﻿using DesignPatterns.Patterns.Creational.Builder.Interfaces;

namespace DesignPatterns.Patterns.Creational.Builder
{
    /// <summary>
    /// An example of a product built by the Builder
    /// </summary>
    public class BuilderMinceAndCheesePie : IPieBuilder
    {
        Pie _pie;

        public BuilderMinceAndCheesePie()
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
