Console.WriteLine("*** Methods ***");

// Void methods - Complete a task but do not return a value
Console.WriteLine("Enter your name:");

// ?? means: if Console.ReadLine() returns null, use "" instead.
// This prevents UserName from becoming null.
string UserName = Console.ReadLine() ?? "";

void PrintName()
{
    Console.WriteLine($"Welcome to C# {UserName}");
}

PrintName();

int TodayYear = DateTime.Now.Year;

// Value-returning methods - Perform a task and return a value after completion
Console.WriteLine("How many years you want to go forward or go back? (+year or -year)");
int TimeTravelYear = int.Parse(Console.ReadLine() ?? "0");

string TimeTravel()
{

    // This is a ternary operator:
    // condition ? value_if_true : value_if_false
    // If TimeTravelYear is 0, return the current-year message.
    // Otherwise, return the travelled-year message.
    return TimeTravelYear == 0
        ? "You are in the current year."
        : $"You have time travelled to the year {TodayYear + TimeTravelYear}.";
}

Console.WriteLine(TimeTravel());

// methods with parameters - Accept input values to perform a task and represents data being passed into a method when it is called
Console.WriteLine("How many years you want to go forward or go back? (+year or -year)");
int NewTimeTravelYear = int.Parse(Console.ReadLine() ?? "0");

string TimeTravelWithParameter(int NewTimeTravelYear)
{

    // Ternary operator:
    // If NewTimeTravelYear is 0, return the first message.
    // Otherwise, return the second message after adding the year difference.
    return NewTimeTravelYear == 0
        ? "You are in the current year."
        : $"You have time travelled to the year {TodayYear + NewTimeTravelYear}.";
}

Console.WriteLine(TimeTravelWithParameter(NewTimeTravelYear));

// methods with optional parameters - Allow callers to omit arguments for some parameters
Console.WriteLine("Enter the year you want to travel to:");
int HowManyYearsToTravel = int.Parse(Console.ReadLine() ?? "0");

string DifferenceInYears(int HowManyYearsToTravel = 0)
{
    if (HowManyYearsToTravel == 0)
    {
        HowManyYearsToTravel = TodayYear;
    }

    int difference = Math.Abs(HowManyYearsToTravel - TodayYear);

    if (HowManyYearsToTravel > TodayYear)
    {
        return $"The year {HowManyYearsToTravel} will be {difference} years from now.";
    }

    if (HowManyYearsToTravel < TodayYear)
    {
        return $"The year {HowManyYearsToTravel} was {difference} years ago.";
    }

    return "This is the current year.";
}

Console.WriteLine(DifferenceInYears(HowManyYearsToTravel));

// methods with nullable parameters - Handle cases where a parameter may not have a value
Console.WriteLine("How many years you want to go forward or go back? Press Enter if you do not know:");
string? NullableTimeTravelInput = Console.ReadLine();
int? NullableTimeTravelYear = null;

if (!string.IsNullOrWhiteSpace(NullableTimeTravelInput))
{
    NullableTimeTravelYear = int.Parse(NullableTimeTravelInput);
}

string TimeTravelWithNullableParameter(int? NullableTimeTravelYear)
{
    if (NullableTimeTravelYear == null)
    {
        return "You did not enter a year. You are in the current year.";
    }
    if (NullableTimeTravelYear == 0)
    {
        return "You are in the current year.";
    }

    int TravelledYear = TodayYear + NullableTimeTravelYear.Value;
    return $"You have time travelled to the year {TravelledYear}.";
}
Console.WriteLine(TimeTravelWithNullableParameter(NullableTimeTravelYear));


/* function calls */