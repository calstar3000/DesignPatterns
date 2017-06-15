using DesignPatterns.Patterns.Factory.Interfaces;

namespace DesignPatterns.Patterns.Factory.Products
{
    /// <summary>
    /// Example of a "Product" of the "Factory"
    /// </summary>
    public class Instagram : ISocialNetwork
    {
        private SocialNetwork _networkId;

        public Instagram()
        {
            _networkId = SocialNetwork.Instagram;
        }

        public string GetDescription()
        {
            return string.Format("Connect with {0}", _networkId);
        }
    }
}
