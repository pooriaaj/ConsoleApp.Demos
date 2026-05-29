using System.Security.Cryptography;

public class Person
{
    // Properties / Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field Members
    private string _taxNumber;

    // Method
    public void PrintFullName()
    {
        Console.WriteLine($"Hello, my fisr name is {FirstName}, my last name is {LastName} and I am {DateOfBirth} years old.");
    }
    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var secondInitial = LastName[0];
        Console.WriteLine($"My initials are {FirstName[0]}.{LastName[0]}.");
    }

    public void GenerateTaxNumber()
    {
        _taxNumber = RandomNumberGenerator.GetInt32(100000000, 999999999).ToString();
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public 
}