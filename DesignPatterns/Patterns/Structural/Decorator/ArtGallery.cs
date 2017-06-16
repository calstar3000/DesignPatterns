using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Decorator
{
    /// <summary>
    /// Class represents an art gallery with a collection of artworks,
    /// some of which are up for sale or have been sold.
    /// </summary>
    public class ArtGallery
    {
        public void Populate()
        {
            var collection = new List<GalleryItem>();

            collection.Add(new Artwork("Mona Lisa", "Leonardo da Vinci"));
            collection.Add(new Artwork("The Starry Night", "Vincent van Gogh"));
            collection.Add(new Artwork("Guernica", "Pablo Picasso"));

            var americanGothic = new Artwork("American Gothic", "Grant wood");
            var theKiss = new Artwork("The Kiss", "Gustav Klimt");

            var americanGothicForSale = new Purchasable(americanGothic, 12000000);
            var theKissForSale = new Purchasable(theKiss, 2000000);

            collection.Add(americanGothicForSale);
            collection.Add(theKissForSale);

            americanGothicForSale.Purchase("Andy Hall");

            Console.WriteLine("Art gallery collection:");

            foreach (var artwork in collection)
            {
                artwork.Display();
            }
        }
    }
}
