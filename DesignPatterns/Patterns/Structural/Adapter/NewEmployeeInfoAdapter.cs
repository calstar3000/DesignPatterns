using System;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    /// <summary>
    /// This is the inherited class, or the extension of the Target class,
    /// which has adapted to fit both the Target and Adaptee classes.
    /// </summary>
    public class NewEmployeeInfoAdapter : LegacyEmployeeInfoTarget
    {
        public NewEmployeeInfoAdapter(int id, string name, int salary)
            : base(id, name, salary)
        {
        }

        public override void Display()
        {
            int annualCoffeeConsumption = new ExtraEmployeeInfoAdaptee().GetEmployeeAnnualCoffeeConsumption(id);

            Console.WriteLine(string.Format("Employee: {0}, Salary: {1}, Coffee consumption: {2}", name, salary, annualCoffeeConsumption));
        }
    }
}
