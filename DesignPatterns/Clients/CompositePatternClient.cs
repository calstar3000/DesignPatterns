using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Composite;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of a composite pattern. In this example,
    /// a family tree is constructed from individual tree nodes.
    /// Each node can have its own children, so the complex tree
    /// object is constructed from lots of 'simple' sub-tree objects.
    /// </summary>
    public class CompositePatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Composite pattern"; }
        }

        public void Run()
        {
            new FamilyTree().Grow();
        }
    }
}
