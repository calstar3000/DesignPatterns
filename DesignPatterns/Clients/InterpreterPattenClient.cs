using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.Interpreter;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of the interpreter pattern. This example simulates a calculator
    /// that can interpret expressions, where each expression can itself be made up
    /// of more expressions.
    /// </summary>
    public class InterpreterPattenClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Interpreter pattern"; }
        }

        public void Run()
        {
            new Calculator().Compute();
        }
    }
}
