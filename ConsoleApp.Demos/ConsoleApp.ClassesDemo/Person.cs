using System.Security.Cryptography;

public class Person
{
    public Person(string firstName, string lastName, DateTime dateOfBirth, int Age)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Age = GetAge(dateOfBirth);
    }
    public Person(string firstName, string lastName, int dateOfBirth, int Age)
    {
        FirstName = firstName;
        LastName = lastName;
        this.dateOfBirth = dateOfBirth;
        this.Age = Age;
    }

    public Person()
    {
    }

    // Properties / Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }
    public int dateOfBirth { get; set; }
    public string IdNumber { get; set; }

    // Field Members
    private string _taxNumber = string.Empty;
    protected string _idNumber = "N/A";
    // Method
    public void PrintFullName()
    {
        Console.WriteLine($"Hello, My name is {FirstName} {LastName} and I was born {Age} years ago :).");
    }
    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var secondInitial = LastName[0];
        Console.WriteLine($"My initials are {FirstName[0]}.{LastName[0]}.");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = GetRandomNumber();
        }
        else
        {
            Console.WriteLine("Tax number already generated.");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }
    public int GetAge(DateTime dateOfBirth)
    {
        int age = DateTime.Now.Year - dateOfBirth.Year;
        return age;
    }
    public string GetIdNumber()
    {
        return _idNumber;
    }
    protected string GetRandomNumber()
    {
        return RandomNumberGenerator.GetInt32(100000, 999999).ToString();
    }
}