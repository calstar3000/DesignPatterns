using System;

namespace DesignPatterns.Patterns.Structural.Decorator
{
    /// <summary>
    /// This class adds the ability for an artwork to be purchased, ie. it has
    /// been decorated to have this extra functionality.
    /// </summary>
    public class Purchasable : Decorator
    {
        private int _salePrice;
        private string _buyer;

        public Purchasable(GalleryItem item, int salePrice)
            : base(item)
        {
            _salePrice = salePrice;
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine(
                string.Format("  - Price: {0}, {1}",
                _salePrice,
                string.IsNullOrEmpty(_buyer) ? "unsold" : "sold to " +_buyer));
        }

        public void Purchase(string buyer)
        {
            _buyer = buyer;
        }
    }
}
