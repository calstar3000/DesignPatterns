using System;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
    public class Circle : Shape
    {
        /// <summary>
        /// An example of a concrete implementation of a shape. 
        /// Extrinsic (unique) properties are passed in to the draw method.
        /// </summary>
        public Circle()
        {
            this.height = 8;
            this.width = 8;
            this.colour = "blue";
        }

        public override void Draw(int x, int y)
        {
            Console.WriteLine(string.Format("Drawing a circle of height: {0}, width: {1}, colour: {2} at [{3}, {4}]", height, width, colour, x, y));
        }
    }
}
