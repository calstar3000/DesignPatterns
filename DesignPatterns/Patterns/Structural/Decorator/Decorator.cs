
namespace DesignPatterns.Patterns.Structural.Decorator
{
    /// <summary>
    /// The decorator class looks like a gallery item, but holds a reference 
    /// to the class it decorates.
    /// </summary>
    public abstract class Decorator : GalleryItem
    {
        protected GalleryItem _item;

        public Decorator(GalleryItem item)
        {
            _item = item;
        }

        public override void Display()
        {
            _item.Display();
        }
    }
}
