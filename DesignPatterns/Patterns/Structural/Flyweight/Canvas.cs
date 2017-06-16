
namespace DesignPatterns.Patterns.Structural.Flyweight
{
    /// <summary>
    /// The class represents a canvas having a number different of shapes drawn on it.
    /// </summary>
    public class Canvas
    {
        public void Paint()
        {
            var factory = new ShapeFactory();

            factory.Display();

            var circle = factory.GetShape(ShapeType.Circle);
            circle.Draw(1, 1);

            factory.Display();

            var anotherCircle = factory.GetShape(ShapeType.Circle);
            anotherCircle.Draw(2, 2);

            factory.Display();

            var square = factory.GetShape(ShapeType.Square);
            square.Draw(1, 1);

            factory.Display();

            var anotherSquare = factory.GetShape(ShapeType.Square);
            anotherSquare.Draw(2, 2);

            factory.Display();

            var triangle = factory.GetShape(ShapeType.Triangle);
            triangle.Draw(1, 1);

            factory.Display();

            var anotherTriangle = factory.GetShape(ShapeType.Triangle);
            anotherTriangle.Draw(2, 2);

            factory.Display();
        }
    }
}
