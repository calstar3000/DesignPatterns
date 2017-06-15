using DesignPatterns.Patterns.Factory.Interfaces;
using DesignPatterns.Patterns.Factory.Products;

namespace DesignPatterns.Patterns.Factory
{
    /// <summary>
    /// The "Factory" responsible for creating different instances of the "Product",
    /// based on some input data.
    /// </summary>
    public static class SocialNetworkFactory
    {
        public static ISocialNetwork CreateSocialNetwork(SocialNetwork network)
        {
            switch (network)
            {
                case SocialNetwork.Google:
                    return new Google();
                case SocialNetwork.Facebook:
                    return new Facebook();
                case SocialNetwork.Instagram:
                    return new Instagram();
                default:
                    return new NullNetwork();
            }
        }
    }
}
