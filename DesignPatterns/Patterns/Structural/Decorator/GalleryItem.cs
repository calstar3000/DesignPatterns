
namespace DesignPatterns.Patterns.Structural.Decorator
{
    /// <summary>
    /// Class representing a generic gallery item.
    /// </summary>
    public abstract class GalleryItem
    {
        protected string _name;
        protected string _artist;
        protected bool _inCollection;

        public abstract void Display();
    }
}
