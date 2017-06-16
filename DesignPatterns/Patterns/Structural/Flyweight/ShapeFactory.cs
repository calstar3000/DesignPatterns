using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
    /// <summary>
    /// The shape factory is responsible for creating new instances of shapes
    /// where they don't already exist in its cache, otherwise returning
    /// an existing instance.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// The cache of existing shapes
        /// </summary>
        private Dictionary<ShapeType, Shape> _shapes;

        public ShapeFactory()
        {
            _shapes = new Dictionary<ShapeType, Shape>();
        }

        /// <summary>
        /// Get a shape from the cache based on its type, or if it doesn't
        /// exist in the cache, create a new one and add it to the cache
        /// </summary>
        /// <param name="type">The type of shape to retrieve</param>
        /// <returns></returns>
        public Shape GetShape(ShapeType type)
        {
            Shape shape = null;

            // If it already exists in the dictionary, just grab it
            if (_shapes.ContainsKey(type))
            {
                Console.WriteLine(string.Format("Getting existing instance of {0}", type.ToString()));

                shape = _shapes[type];
            }
            else
            {
                Console.WriteLine(string.Format("Creating new instance of {0}", type.ToString()));

                // Creat a new instance and add it to the dictionary
                switch (type)
                {
                    case ShapeType.Circle:
                        shape = new Circle();
                        break;
                    case ShapeType.Square:
                        shape = new Square();
                        break;
                    case ShapeType.Triangle:
                        shape = new Triangle();
                        break;
                }

                _shapes.Add(type, shape);
            }

            return shape;
        }

        /// <summary>
        /// Display the contents of the factory's cache
        /// </summary>
        public void Display()
        {
            Console.WriteLine("\nDisplaying contents of factory:");

            foreach (var key in _shapes.Keys)
            {
                Console.WriteLine(string.Format("* {0}", key));
            }

            Console.WriteLine();
        }
    }
}
