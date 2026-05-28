Console.WriteLine("*** Lists ***");

// Declare a List
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
string studentName = string.Empty;
int @continue; 
int gradeCount = 0;


// Add values to List
//grades.Add(45);
//Console.WriteLine(grades[0]);
do
{
    gradeCount += 1;
    Console.WriteLine("Enter a student name: ");
    studentName = Console.ReadLine() ?? string.Empty;
    students.Add(studentName);

    Console.WriteLine("Enter a grade: ");
    grade = Convert.ToInt32(Console.ReadLine());

    if (grade != -1) 
    {
        grades.Add(grade);
    }

    Console.WriteLine("Do you wish to continue? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());
} while (@continue == 1);

// Print values of List for loop
Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]} : {grades[i]}");
}

// Print values of List
Console.WriteLine("Print values of list - for loop");
for (int i = 0; i < grades.Count; i++)
{
    Console.WriteLine(grades[i]);
}

// Print values of list - for each loop
Console.WriteLine("Print values of list - foreach loop");
foreach (int g in grades)
{
    Console.WriteLine(g);
}