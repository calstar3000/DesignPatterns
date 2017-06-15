using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    /// <summary>
    /// This is the Adaptee, or the class that is joined onto the Target class
    /// via the Adapter class.
    /// </summary>
    public class ExtraEmployeeInfoAdaptee
    {
        private Dictionary<int, int> _annualCoffeeConsumptionDatabase;

        public ExtraEmployeeInfoAdaptee()
        {
            _annualCoffeeConsumptionDatabase = new Dictionary<int, int> { { 1, 53 }, { 2, 619 }, { 3, 329 } };
        }

        public int GetEmployeeAnnualCoffeeConsumption(int id)
        {
            return _annualCoffeeConsumptionDatabase[id];
        }
    }
}
