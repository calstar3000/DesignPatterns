using System;

namespace DesignPatterns.Patterns.Behavioural.Interpreter
{
    /// <summary>
    /// Example of a terminal expression, in this case just the number.
    /// </summary>
    public class ExpressionNumber : Expression
    {
        public int number;

        public ExpressionNumber(int number)
        {
            this.number = number;
        }

        public override int Interpret(params Expression[] expression)
        {
            Console.WriteLine(string.Format("Expression: {0}", number));
            return number;
        }
    }
}
