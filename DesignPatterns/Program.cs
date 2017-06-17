using DesignPatterns.Clients;
using DesignPatterns.Clients.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    /// <summary>
    /// This class runs through the various design pattern demos
    /// by taking user input and running the corresponding demo.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var patterns = new Dictionary<int, IPatternClient>
            {
                { 1, new AbstractFactoryPatternClient() },
                { 2, new FactoryPatternClient() },
                { 3, new BuilderPatternClient() },
                { 4, new SingletonPatternClient() },
                { 5, new PrototypePatternClient() },
                { 6, new AdapterPatternClient() },
                { 7, new BridgePatternClient() },
                { 8, new CompositePatternClient() },
                { 9, new DecoratorPatternClient() },
                { 10, new FacadePatternClient() },
                { 11, new FlyweightPatternClient() },
                { 12, new ProxyPatternClient() },
                { 13, new ChainOfResponsibilityClient() },
                { 14, new CommandPatternClient() },
                { 15, new IteratorPatternClient() },
                { 16, new IteratorPatternClient() },
                { 17, new MediatorPatternClient() },
                { 18, new MementoPatternClient() },
                { 19, new ObserverPatternClient() },
                { 20, new StatePatternClient() },
                { 21, new StrategyPatternClient() },
                { 22, new TemplateMethodPatternClient() },
                { 23, new VisitorPatternClient() }
            };

            Console.WriteLine("Design pattern demos:");
            Console.WriteLine("---------------------");

            foreach (var key in patterns.Keys)
            {
                Console.WriteLine(string.Format("Press {0} for {1}", key, patterns[key].PatternName));
            }

            string input = Console.ReadLine();
            int keyCode;
            IPatternClient client;
            if (Int32.TryParse(input, out keyCode) && patterns.TryGetValue(keyCode, out client))
            {
                patterns[keyCode].Run();
            }
            else
            {
                Console.WriteLine("Pattern not found!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
