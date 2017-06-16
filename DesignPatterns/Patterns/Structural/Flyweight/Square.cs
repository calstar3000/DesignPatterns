using System;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
    public class Square : Shape
    {
        /// <summary>
        /// An example of a concrete implementation of a shape. 
        /// Extrinsic (unique) properties are passed in to the draw method.
        /// </summary>
        public Square()
        {
            this.height = 9;
            this.width = 9;
            this.colour = "red";
        }

        public override void Draw(int x, int y)
        {
            Console.WriteLine(string.Format("Drawing a square of height: {0}, width: {1}, colour: {2} at [{3}, {4}]", height, width, colour, x, y));
        }
    }
}
