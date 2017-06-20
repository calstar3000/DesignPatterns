
namespace DesignPatterns.Patterns.Behavioural.Interpreter
{
    /// <summary>
    /// The template for the expression. All the expression needs to do
    /// is interpret another expression (which may be terminal ie. a number,
    /// or non-terminal ie. another expression).
    /// </summary>
    public abstract class Expression
    {
        public abstract int Interpret(params Expression[] expression);
    }
}
