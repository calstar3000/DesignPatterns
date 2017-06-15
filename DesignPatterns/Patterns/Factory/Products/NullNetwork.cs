using System;

namespace DesignPatterns.Patterns.Factory.Products
{
    /// <summary>
    /// Class representing the default null social network, if incorrect data is provided. 
    /// Example of the null object pattern.
    /// </summary>
    public class NullNetwork : ISocialNetwork
    {
        public string GetDescription()
        {
            return "Network not found!";
        }
    }
}
