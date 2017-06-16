using System;

namespace DesignPatterns.Patterns.Structural.Decorator
{
    /// <summary>
    /// Class representing a type of gallery item, in this case an artwork.
    /// </summary>
    public class Artwork : GalleryItem
    {
        public Artwork(string name, string artist)
        {
            _name = name;
            _artist = artist;
        }

        public override void Display()
        {
            Console.WriteLine(string.Format("* {0} by {1}", _name, _artist));
        }
    }
}
