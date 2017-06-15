using System;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    /// <summary>
    /// This is the Target of the adapter pattern, ie. the class that is
    /// inherited from / extended.
    /// </summary>
    public class LegacyEmployeeInfoTarget
    {
        protected int id;
        protected string name;
        protected int salary;

        public LegacyEmployeeInfoTarget(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public virtual void Display()
        {
            Console.WriteLine(string.Format("Employee: {0}, Salary: {1}", name, salary));
        }
    }
}
