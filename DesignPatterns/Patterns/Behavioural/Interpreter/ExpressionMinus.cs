using System;

namespace DesignPatterns.Patterns.Behavioural.Interpreter
{
    /// <summary>
    /// Example of a a non-terminal subtraction expression, which minuses the result of one
    /// expression from the result of another.
    /// </summary>
    public class ExpressionMinus : Expression
    {
        public Expression left;
        public Expression right;

        public ExpressionMinus(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpret(params Expression[] expression)
        {
            Console.WriteLine("Expression: Minus");
            return this.left.Interpret(expression) - this.right.Interpret(expression);
        }
    }
}
