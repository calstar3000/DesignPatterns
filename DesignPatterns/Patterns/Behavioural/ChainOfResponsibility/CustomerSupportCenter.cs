
namespace DesignPatterns.Patterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// This class simulates a customer support center with three levels of representatives,
    /// responsible for handling requests of different severity levels. Each representative
    /// has a successor to whom they can pass on the request if they can't handle it themselves.
    /// </summary>
    public class CustomerSupportCenter
    {
        public void SetUp()
        {
            var seniorCSR = new SeniorCSR("Anne");
            var intermediateCSR = new IntermediateCSR("Beth");
            var juniorCSR = new JuniorCSR("Carl");

            juniorCSR.SetSuccessor(intermediateCSR);
            intermediateCSR.SetSuccessor(seniorCSR);

            var lowSeverityRequest = new SupportRequest(SeverityLevel.Low);
            juniorCSR.HandleRequest(lowSeverityRequest);
            intermediateCSR.HandleRequest(lowSeverityRequest);
            seniorCSR.HandleRequest(lowSeverityRequest);

            var mediumSeverityRequest = new SupportRequest(SeverityLevel.Medium);
            juniorCSR.HandleRequest(mediumSeverityRequest);
            intermediateCSR.HandleRequest(mediumSeverityRequest);
            seniorCSR.HandleRequest(mediumSeverityRequest);

            var highSeverityRequest = new SupportRequest(SeverityLevel.High);
            juniorCSR.HandleRequest(highSeverityRequest);
            intermediateCSR.HandleRequest(highSeverityRequest);
            seniorCSR.HandleRequest(highSeverityRequest);

            var criticalSeverityRequest = new SupportRequest(SeverityLevel.Critical);
            juniorCSR.HandleRequest(criticalSeverityRequest);
        }
    }
}
