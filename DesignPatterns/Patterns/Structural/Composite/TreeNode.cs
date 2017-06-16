using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Composite
{
    /// <summary>
    /// This class represents a node on the family tree.
    /// The node itself can be a child of another node, and
    /// can have children of its own.
    /// </summary>
    public class TreeNode
    {
        private string _name;
        private List<TreeNode> _children;

        public TreeNode(string name)
        {
            _name = name;
            _children = new List<TreeNode>();
        }

        public void AddNode(TreeNode node)
        {
            _children.Add(node);
        }

        /// <summary>
        /// Display the node by recursively calling the display
        /// method on each of its children.
        /// </summary>
        /// <param name="indent">Keep track of the current level of the tree</param>
        public void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+" + _name);

            foreach (var child in _children)
            {
                child.Display(indent + 2);
            }
        }
    }
}
