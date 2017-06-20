using System;

namespace DesignPatterns.Patterns.Behavioural.Interpreter
{
    /// <summary>
    /// This class simulates a calculator which can compute sums based on a grammar
    /// of expressions. Each expression is either a number, or an add or subtract
    /// expression.
    /// </summary>
    public class Calculator
    {
        public void Compute()
        {
            var expressionEasy = new ExpressionPlus(new ExpressionNumber(1), new ExpressionNumber(2));
            Console.WriteLine("Easy:");
            Console.WriteLine(string.Format("Answer: {0}", expressionEasy.Interpret()));

            Console.WriteLine();

            var expressionHarder = new ExpressionPlus(
                new ExpressionMinus(new ExpressionNumber(10), new ExpressionNumber(2)), 
                new ExpressionMinus(new ExpressionNumber(7), new ExpressionNumber(3)));
            Console.WriteLine("Harder:");
            Console.WriteLine(string.Format("Answer: {0}", expressionHarder.Interpret()));
        }
    }
}
