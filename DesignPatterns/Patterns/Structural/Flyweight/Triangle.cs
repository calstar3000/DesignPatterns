using System;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
    /// <summary>
    /// An example of a concrete implementation of a shape. 
    /// Extrinsic (unique) properties are passed in to the draw method.
    /// </summary>
    public class Triangle : Shape
    {
        public Triangle()
        {
            this.height = 10;
            this.width = 10;
            this.colour = "green";
        }

        public override void Draw(int x, int y)
        {
            Console.WriteLine(string.Format("Drawing a triangle of height: {0}, width: {1}, colour: {2} at [{3}, {4}]", height, width, colour, x, y));
        }
    }
}
