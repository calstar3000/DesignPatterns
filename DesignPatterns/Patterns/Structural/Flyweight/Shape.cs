
namespace DesignPatterns.Patterns.Structural.Flyweight
{
    /// <summary>
    /// The template for the intrinsic (shared) properties of any shape
    /// </summary>
    public abstract class Shape
    {
        protected int width;
        protected int height;
        protected string colour;

        public abstract void Draw(int x, int y);
    }
}
