// See https://aka.ms/new-console-template for more information
// primitive datatypes
////int, string, char, bool

// Object Oriented Programming - Creating your own datatype
// class - blueprint

// Single Responsibility Priniciple

public class Person
{
    // Properties when public
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    // Fields
    private double Salary { get; set; }

    public void setSalary(double salary)
    {
        Salary = salary;
    }

    public double getSalary()
    {
        return Salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}