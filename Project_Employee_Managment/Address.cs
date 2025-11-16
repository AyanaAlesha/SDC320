// Name: Ayana Aiken
// Date: November 2025
// Address Class - Used to demonstrate composition
// Employee HAS AN Address


public class Address
{
    public string Street { get; set; }
    public string City   { get; set; }
    public string State  { get; set; }
    public string Zip    { get; set; }

    public Address(string street, string city, string state, string zip)
    {
        Street = street;
        City   = city;
        State  = state;
        Zip    = zip;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {Zip}";
    }
}
