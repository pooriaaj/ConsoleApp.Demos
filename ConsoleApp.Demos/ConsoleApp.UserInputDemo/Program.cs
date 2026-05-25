// Variable Declarations and Types
using System.Globalization;

const int retirementAge = 65;

string? name = string.Empty;
int age;
int minWorkingAge = 18;
DateOnly dob = new DateOnly();
decimal salary;
char gender = char.MinValue;
bool isEmployed = true;

// Promt the user for input
Console.Write("Please enter your name: ");
name = Console.ReadLine();

Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
age = DateOnly.FromDateTime(DateTime.Now).Year - dob.Year;

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(value: Console.ReadLine());

Console.Write("Are you working? (True or False): ");
isEmployed = Convert.ToBoolean(Console.ReadLine());

// Processing the data
int yearsWorking = age - minWorkingAge;
var estimatedRetirementYears = DateTime.Now.AddYears(yearsWorking);

// Output the results
Console.Write($"Hello {name}, you are {age} years old, and you have been working for {yearsWorking} years. Your salary is {salary.ToString("C")}, your gender is {gender}, and it is {isEmployed} that you are currently employed.");
Console.WriteLine($" Based on your current age, you are expected to retire in the year {estimatedRetirementYears.Year}, when you will be {retirementAge} years old.");