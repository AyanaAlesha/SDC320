
// Name: Ayana Aiken
// Date: November 2025
// Purpose: Week 1 Project - Demonstrate inheritance, composition,
//          user interface, and object creation for an Employee
//          Management Application.


using System;

public class Program
{
    static List<Employee> employees = new List<Employee>();   // Storage for composition demo

    public static void Main()
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("  Ayana Aiken - Week 1 Project - Employee Manager");
        Console.WriteLine("---------------------------------------------------\n");

        Console.WriteLine("Welcome! This application demonstrates inheritance,");
        Console.WriteLine("composition, and object-oriented design. Follow the menu below.\n");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Add Hourly Employee");
            Console.WriteLine("2. Add Salaried Employee");
            Console.WriteLine("3. View All Employees");
            Console.WriteLine("4. Exit");

            Console.Write("\nChoice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddHourlyEmployee();
                    break;
                case "2":
                    AddSalariedEmployee();
                    break;
                case "3":
                    DisplayAllEmployees();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("\nThank you for using the Employee Manager!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

  
    // Add Hourly Employee (demonstrates inheritance & composition)
   
    static void AddHourlyEmployee()
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter hourly wage: ");
        double wage = double.Parse(Console.ReadLine());

        // Composition → Employee HAS an Address
        Address address = CollectAddress();

        HourlyEmployee emp = new HourlyEmployee(name, address, wage);
        employees.Add(emp);

        Console.WriteLine("Hourly Employee Added!");
    }

    
    // Add Salaried Employee (demonstrates inheritance & composition)
   
    static void AddSalariedEmployee()
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter yearly salary: ");
        double salary = double.Parse(Console.ReadLine());

        Address address = CollectAddress();

        SalariedEmployee emp = new SalariedEmployee(name, address, salary);
        employees.Add(emp);

        Console.WriteLine("Salaried Employee Added!");
    }

    // Composition Helper: create Address object
   
    static Address CollectAddress()
    {
        Console.Write("Street: ");
        string street = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State: ");
        string state = Console.ReadLine();

        Console.Write("Zip: ");
        string zip = Console.ReadLine();

        return new Address(street, city, state, zip);
    }

    
    // View All Employees
  
    static void DisplayAllEmployees()
    {
        Console.WriteLine("\n----- Employee List -----");

        foreach (var emp in employees)
        {
            Console.WriteLine(emp.ToString());
            Console.WriteLine();
        }
    }
}
