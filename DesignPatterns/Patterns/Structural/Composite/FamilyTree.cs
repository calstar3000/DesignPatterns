using System;

namespace DesignPatterns.Patterns.Structural.Composite
{
    /// <summary>
    /// The class representing the family tree.
    /// The tree is 'grown' by creating and adding nodes
    /// to other nodes already in the tree.
    /// </summary>
    public class FamilyTree
    {
        public void Grow()
        {
            Console.WriteLine("Family tree:");

            var root = new TreeNode("Anne");
            var child1 = new TreeNode("Bob");
            var child2 = new TreeNode("Carol");
            root.AddNode(child1);
            root.AddNode(child2);

            var child3 = new TreeNode("Dave");
            var child4 = new TreeNode("Eliza");
            var child5 = new TreeNode("Frank");
            child1.AddNode(child3);
            child1.AddNode(child4);
            child1.AddNode(child5);

            var child6 = new TreeNode("Grace");
            child2.AddNode(child6);

            root.Display(1);
        }
    }
}
