using System;

namespace DesignPatterns.Patterns.Behavioural.Interpreter
{
    /// <summary>
    /// Example of a non-terminal addition expression, which adds the result of two
    /// expressions together.
    /// </summary>
    class ExpressionPlus : Expression
    {
        public Expression left;
        public Expression right;

        public ExpressionPlus(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpret(params Expression[] expression)
        {
            Console.WriteLine("Expression: Plus");
            return this.left.Interpret(expression) + this.right.Interpret(expression);
        }
    }
}
