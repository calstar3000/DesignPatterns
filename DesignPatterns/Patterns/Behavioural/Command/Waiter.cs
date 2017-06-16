using DesignPatterns.Patterns.Behavioural.Command.Inerfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Command
{
    /// <summary>
    /// Class representing the waiter, or the invoker of the list of commands (orders).
    /// The invoker is responsible for collecting commands and executing them in batches.
    /// </summary>
    public class Waiter
    {
        private string _name;
        private List<IOrder> _orders;

        public Waiter(string name)
        {
            _name = name;
            _orders = new List<IOrder>();
            Console.WriteLine(string.Format("You are being served by {0}", name));
        }

        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
            Console.WriteLine(string.Format("Order of {0} added succesfully.", order.Name));
        }

        public void CancelOrder(IOrder order)
        {
            if (_orders.Contains(order))
            {
                _orders.Remove(order);
                Console.WriteLine(string.Format("Order of {0} cancelled succesfully.", order.Name));
            }
            else
            {
                Console.WriteLine(string.Format("Order of {0} is already being prepared and could not be cancelled.", order.Name));
            }
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}
