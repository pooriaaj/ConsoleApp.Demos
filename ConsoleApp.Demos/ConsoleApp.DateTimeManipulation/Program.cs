using System.Globalization;

Console.WriteLine("*** DateTime Manipulation ***");

// Empty DateTime
DateTime dateTime = new DateTime(); // This will create a DateTime object with the default value of January 1, 0001 at 00:00:00

// Creat a DateTime from date and time components
var dateOfBirth = new DateTime(1990, 12, 1, 14, 56, 23);
Console.WriteLine($"Date of Birth: {dateOfBirth}");
Console.WriteLine($"Year: {dateOfBirth.Year}");
Console.WriteLine($"Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Time of day:{dateOfBirth.TimeOfDay}");
Console.WriteLine($"Tick:{dateOfBirth.Ticks}");
Console.WriteLine($"Kind:{dateOfBirth.Kind}");

// Create a DateTime from current time stamp
DateTime now = DateTime.Now; // This will create a DateTime object with the current date and time based on the system's local time zone
Console.WriteLine($"Current Date and Time: {now}");

// Create a DateTime from a string
Console.WriteLine($"What is your date of birth?");
string DOB = Console.ReadLine();
var userDOB = DateTime.Parse(DOB); // This will parse the input string and create a DateTime object if the format is valid
Console.WriteLine($"Year: {userDOB.Year}");
Console.WriteLine($"Week: {userDOB.DayOfWeek}");
Console.WriteLine($"Time of day:{userDOB.TimeOfDay}");
Console.WriteLine($"Tick:{userDOB.Ticks}");
Console.WriteLine($"Kind:{userDOB.Kind}");

// Change Format DateTime
Console.WriteLine($"Formatted Date: {userDOB.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDOB.ToString("MMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {userDOB.ToString("dddd-MMMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDOB.ToString("dddd, MMM dd, yyyy")}");


// Add Additional Time 
Console.WriteLine("One hour from now: " + now.AddHours(1));
Console.WriteLine("One day from now: " + now.AddDays(1));


// Ticks from Datetime 


Console.WriteLine("*** DateTime offset manipulation ***");
// UTC Cordinated Universal Time
var utcNow = DateTime.UtcNow; // This will create a DateTime object with the current date and time in Coordinated Universal Time (UTC)
Console.WriteLine($"Current UTC Date and Time: {utcNow}");
Console.WriteLine($"Current Local Date and Time: {DateTime.Now}");


// DateTimeOffset and TimeZoneInfo
var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"Current Time Zone Offset from UTC: {tz}");

var dto = new DateTimeOffset(utcNow, tz); // This will create a DateTimeOffset object that represents the current UTC time with the local time zone offset
Console.WriteLine($"Current Date and Time with Offset: {dto}");
Console.WriteLine.($"UTC Time of Action: {dto.UtcDateTime}");

Console.WriteLine("*** Date only and Time only manipualtion ***");

// DateOnly
var dateOnly = DateOnly.FromDateTime(DateTime.Now); // This will create a DateOnly object that represents the current date without the time component
Console.WriteLine($"Current Date Only: {dateOnly}");

Console.WriteLine("What is your date of birth? (Date only)");
string DOB2 = Console.ReadLine();

var userDOB2 = DateOnly.ParseExact(DOB2, "dd MMM yyyy", CultureInfo.InvariantCulture); // This will parse the input string and create a DateOnly object if the format is valid
Console.WriteLine($"Year: {userDOB2.Year}");

// TimeOnly
var timeOnly = TimeOnly.FromDateTime(DateTime.Now); // This will create a TimeOnly object that represents the current time without the date component
Console.WriteLine($"Current Time Only: {timeOnly}");