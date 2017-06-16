using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Proxy;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of the proxy pattern. This example simulates a protective
    /// proxy where the access to different database operations is tested
    /// before the operations are carried out.
    /// </summary>
    public class ProxyPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Proxy pattern"; }
        }

        public void Run()
        {
            new DatabaseAccessService().TestAccess();
        }
    }
}
