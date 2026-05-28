Console.WriteLine("*** Arrays ***");

// Tell me how many grades you want to enter
Console.WriteLine("How many grades do you want to enter? ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Declare Fixed-Size Array 
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// 5 space addresses/indexes - 0,1,2,3,4
// If n is the size of the array, then your array has addresses between 0 and n-1. So, for an array of size 5, the valid indexes are 0 to 4.

// Add values to fixed-size array
// grades[0] = 45;
// grades[1] = 25;
// grades[2] = 38;
// grades[3] = 45;
// grades[4] = 54;

for (int i=0; i<numberOfGrades; i++)
{
    Console.WriteLine("Enter students names: ");
    students[i] = Console.ReadLine() ?? string.Empty; // Handle potential null input

    Console.WriteLine("Enter a grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values of fixed-size array
Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{students[i]} : {grades[i]}");
}

// Print values in list - foreach loop
foreach (int g in grades)
{
    Console.WriteLine(g);
}

// Declare Variable Size Array
string[] studentNames = {"Newton", "Joshua", "etc..."};

// Add values to variable size array
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine("Enter a student name: ");
    string? input = Console.ReadLine();

    if (input is null)
    {
        // input was null (e.g. EOF). Keep the existing array value (or assign a fallback).
        // studentNames[i] = studentNames[i]; // no-op, shown for clarity
        // Or assign a fallback instead:
        // studentNames[i] = string.Empty;
    }
    else
    {
        studentNames[i] = input;
    }
}

// Print values of variable size array
Console.WriteLine("The student names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}