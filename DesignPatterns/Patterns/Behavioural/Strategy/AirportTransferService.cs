using DesignPatterns.Patterns.Behavioural.Strategy.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    /// <summary>
    /// Class representing an airport transfer service. All transfer methods
    /// ("strategies") follow the same interface, so can be called in the same way.
    /// </summary>
    public class AirportTransferService
    {
        private Dictionary<TransferType, ITransferMethod> _transferMethods;

        public AirportTransferService()
        {
            _transferMethods = new Dictionary<TransferType, ITransferMethod>
            {
                { TransferType.Car, new TransferByCar() },
                { TransferType.Taxi, new TransferByTaxi() },
                { TransferType.Bus, new TransferByBus() }
            };
        }

        public void ChooseTransferMethod()
        {
            Console.WriteLine("Airport transfer service:");
            Console.WriteLine("Press 1 for transfer by car");
            Console.WriteLine("Press 2 for transfer by taxi");
            Console.WriteLine("Press 3 for transfer by bus");

            string input = Console.ReadLine();
            TransferType transferType;
            ITransferMethod transferMethod;

            if (Enum.TryParse(input, out transferType) && _transferMethods.TryGetValue(transferType, out transferMethod))
            {
                _transferMethods[transferType].Transfer();
            }
            else
            {
                Console.WriteLine("Transfer method not found!");
            }
        }
    }
}
