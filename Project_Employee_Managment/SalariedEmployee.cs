// Name: Ayana Aiken
// Date: November 2025
// SalariedEmployee - Derived class from Employee



public class SalariedEmployee : Employee
{
    public double Salary { get; set; }

    public SalariedEmployee(string name, Address address, double salary)
        : base(name, address)
    {
        Salary = salary;
    }

    public override double GetPay()
    {
        return Salary / 52;  // Weekly salary
    }

    public override string ToString()
    {
        return "Salaried Employee:\n" +
               base.ToString() +
               $"\nYearly Salary: ${Salary}\nWeekly Pay: ${GetPay()}";
    }
}
