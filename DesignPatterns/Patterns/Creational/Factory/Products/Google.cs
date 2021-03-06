﻿using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Products
{
    /// <summary>
    /// Example of a "Product" of the "Factory"
    /// </summary>
    public class Google : ISocialNetwork
    {
        private SocialNetwork _networkId;

        public Google()
        {
            _networkId = SocialNetwork.Google;
        }

        public string GetDescription()
        {
            return string.Format("Connect with {0}", _networkId);
        }
    }
}
