using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Decorator;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of the decorator pattern. This is example simulates 
    /// an art gallery where some of the collection have been put up 
    /// for sale. The decorator adds the ability for the artworks to 
    /// have a sale price and a buyer, without changing the artwork code.
    /// </summary>
    public class DecoratorPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Decorator pattern"; }
        }

        public void Run()
        {
            new ArtGallery().Populate();
        }
    }
}
