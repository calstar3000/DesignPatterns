
namespace DesignPatterns.Patterns.Behavioural
{
    /// <summary>
    /// The basis for a given CSR, who has a name and a successor (another CSR
    /// whoe will handle any request this CSR can't handle. How each CSR type
    /// handles a request is up to them to implement.
    /// </summary>
    public abstract class CustomerSupportRepresentative
    {
        protected string _name;
        protected CustomerSupportRepresentative _successor;

        public CustomerSupportRepresentative(string name)
        {
            _name = name;
        }

        public void SetSuccessor(CustomerSupportRepresentative successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(SupportRequest request);
    }
}
