using DesignPatterns.Patterns.Structural.Proxy.Interfaces;
using System;

namespace DesignPatterns.Patterns.Structural.Proxy
{
    /// <summary>
    /// The repository class that the proxy wraps.
    /// </summary>
    public class DatabaseRepository : IDatabaseRepository
    {
        public void Create()
        {
            Console.WriteLine("Resource created successfully.");
        }

        public void Read()
        {
            Console.WriteLine("Resource read successfully.");
        }

        public void Update()
        {
            Console.WriteLine("Resource updated successfully.");
        }

        public void Delete()
        {
            Console.WriteLine("Resource deleted successfully.");
        }
    }
}
