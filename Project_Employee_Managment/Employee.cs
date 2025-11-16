
// Name: Ayana Aiken
// Date: November 2025
// Purpose: Employee base class for inheritance demonstration


public abstract class Employee   // ABSTRACT Base Class
{
    public string Name { get; set; }

    // Composition → Employee HAS AN Address
    public Address Address { get; set; }

    public Employee(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public abstract double GetPay();   // Polymorphism demo

    public override string ToString()
    {
        return $"Name: {Name}\nAddress: {Address}";
    }
}
