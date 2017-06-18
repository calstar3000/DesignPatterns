using DesignPatterns.Patterns.Behavioural.Strategy.Interfaces;
using System;

namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    /// <summary>
    /// An example of an airport transfer strategy that implements the common
    /// strategy interface. In reality the transfer method would be much more
    /// complex.
    /// </summary>
    public class TransferByBus : ITransferMethod
    {
        public void Transfer()
        {
            Console.WriteLine("Transferring passenger by bus...");
        }
    }
}
