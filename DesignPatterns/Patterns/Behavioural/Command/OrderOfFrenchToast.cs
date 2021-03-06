﻿using DesignPatterns.Patterns.Behavioural.Command.Inerfaces;
using System;

namespace DesignPatterns.Patterns.Behavioural.Command
{
    /// <summary>
    /// An example order. In reality the implementation of each order would be more customised and complex.
    /// </summary>
    public class OrderOfFrenchToast : IOrder
    {
        public string Name
        {
            get { return "French Toast"; }
        }

        public void Execute()
        {
            Console.WriteLine(string.Format("An order of {0} is being prepared.", Name));
        }
    }
}
