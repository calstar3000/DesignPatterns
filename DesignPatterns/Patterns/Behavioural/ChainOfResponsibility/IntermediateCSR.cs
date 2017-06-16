using System;

namespace DesignPatterns.Patterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// An intermediate CSR, capable of handling requests of the two lowest severity levels.
    /// More severe requests are passed of to a senior CSR to handle.
    /// </summary>
    public class IntermediateCSR : CustomerSupportRepresentative
    {
        public IntermediateCSR(string name)
            : base(name)
        {
        }

        public override void HandleRequest(SupportRequest request)
        {
            if (request.SeverityLevel <= SeverityLevel.Medium)
            {
                Console.WriteLine(string.Format("Request of {0} severity handled by intermediate CSR {1}.", request.SeverityLevel.ToString().ToLower(), _name));
            }
            else
            {
                Console.WriteLine(string.Format("Request of {0} severity not handled by intermediate CSR {1}. Escalating request...", request.SeverityLevel.ToString().ToLower(), _name));

                _successor.HandleRequest(request);
            }
        }
    }
}
