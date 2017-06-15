using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Adapter;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of an adapter pattern. In this example, it is a legacy system
    /// for displaying empolyee salary info. The new system combines this with
    /// annual coffee consumption, by using an adpater to get that infomation from
    /// another source and combine it.
    /// </summary>
    public class AdapterPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Adapter pattern"; }
        }

        public void Run()
        {
            var employee1 = new LegacyEmployeeInfoTarget(1, "Bob", 100000);
            var employee2 = new LegacyEmployeeInfoTarget(2, "Anne", 120000);
            var employee3 = new LegacyEmployeeInfoTarget(3, "Joe", 75000);

            // Legacy dislay
            employee1.Display();
            employee2.Display();
            employee3.Display();

            employee1 = new NewEmployeeInfoAdapter(1, "Bob", 100000);
            employee2 = new NewEmployeeInfoAdapter(2, "Anne", 120000);
            employee3 = new NewEmployeeInfoAdapter(3, "Joe", 75000);

            // New display
            employee1.Display();
            employee2.Display();
            employee3.Display();
        }
    }
}
