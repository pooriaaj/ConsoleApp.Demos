// Prompt for input
using System.Diagnostics;

Console.Write("Please enter student's grade: ");
// Global variable or global scope to store the grade
int grade = Convert.ToInt32(Console.ReadLine());

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid grade entered.");
} 
if (grade >= 50 && grade <= 100)
{
    Console.WriteLine("Congratulations! You have Passed.");
}


// Decide to print pass or fail based on the grade
if (grade < 50 && grade > 0)
{
    Console.WriteLine("Student has failed - F");
}
else if(grade >= 50 && grade <= 64)
{ 
    Console.WriteLine("Student has passed with a D-");
}
else if (grade == 65)
{
    Console.WriteLine("Student has passed with a D");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("Student has passed with a C-");
}
else if (grade == 75)
{
    Console.WriteLine("Student has passed with a C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("Student has passed with a B-");
}
else if (grade == 85)
{
    Console.WriteLine("Student has passed with a B");
}
else if (grade >= 85 && grade <= 94)
{
    Console.WriteLine("Student has passed with a A-");
}
else if (95 <= grade && grade <= 99)
{
    Console.WriteLine("Student has passed with an A");
}
else
{
    Console.WriteLine("A+");
}

// Switch statement to evaluate a value and take an action based on that value
Console.WriteLine("Please enter the day of the week");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch(dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        Console.WriteLine("It's the middle of the week!");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        Console.WriteLine("It's the weekend!");
        break;
    case 7: Console.WriteLine("Sunday");
        Console.WriteLine("It's the weekend!");
        break;
    default:
        Console.WriteLine("Invalid day of the week entered.");
        break;
}
