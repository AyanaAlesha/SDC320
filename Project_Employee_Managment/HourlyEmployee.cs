

// Name: Ayana Aiken
// Date: November 2025
// HourlyEmployee - Derived class from Employee
// Demonstrates inheritance + polymorphism

public class HourlyEmployee : Employee
{
    public double HourlyWage { get; set; }

    public HourlyEmployee(string name, Address address, double wage)
        : base(name, address)
    {
        HourlyWage = wage;
    }

    public override double GetPay()
    {
        return HourlyWage * 40;  // Example
    }

    public override string ToString()
    {
        return "Hourly Employee:\n" +
               base.ToString() +
               $"\nHourly Wage: ${HourlyWage}\nWeekly Pay: ${GetPay()}";
    }
}
