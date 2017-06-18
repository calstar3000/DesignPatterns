using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Visitor
{
    /// <summary>
    /// Class simulating the taxi dispatcher, which loops through a list of
    /// clients and has each of them 'accept' a 'visitor', in this case a taxi.
    /// </summary>
    public class TaxiDispatcher
    {
        private List<Client> _clients;
        private Taxi _taxi;

        public TaxiDispatcher()
        {
            _clients = new List<Client>()
            {
                new Client("Anne", "47 Park Road"),
                new Client("Bob", "12a Windslow Crescent"),
                new Client("Carl", "228 Harris Avenue")
            };

            _taxi = new Taxi("Dave");
        }

        public void Dispatch()
        {
            foreach (var client in _clients)
            {
                client.Accept(_taxi);
            }
        }
    }
}
