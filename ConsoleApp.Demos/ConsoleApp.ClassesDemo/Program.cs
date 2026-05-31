using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

Console.WriteLine("*** Classes and Objects ***");

Person baby = new Person();
DateTime currentDate = DateTime.Now;

Console.WriteLine("Enter your first name: ");
baby.FirstName = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter your last name: ");
baby.LastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter your date of birth (yyyy-mm-dd): ");
baby.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
baby.Age = currentDate.Year - baby.DateOfBirth.Year;
baby.GenerateTaxNumber();
var babyTaxNumber = baby.GetTaxNumber();

baby.PrintFullName();
baby.PrintInitials();
Console.WriteLine($"Your tax number is: {babyTaxNumber}");

Teacher teacher = new();

Console.WriteLine("Enter teacher's first name: ");
teacher.FirstName = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Enter teacher's last name: ");
teacher.LastName= Console.ReadLine() ?? string.Empty;

teacher.PrintFullName();
teacher.PrintInitials();

teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine($"Teacher's tax number is: {teacherTaxNumber}");

teacher.GenerateIdNumber();
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine($"Teacher's ID number is: {teacherIdNumber}");

Student student = new();
Console.WriteLine("Enter student's first name: ");
student.FirstName = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Enter student's last name: ");
student.LastName = Console.ReadLine() ?? string.Empty;

student.PrintFullName();
student.PrintInitials();

student.GenerateTaxNumber();   
var studentTaxNumber = student.GetTaxNumber();
Console.WriteLine($"Student's tax number is: {studentTaxNumber}");

student.GenerateIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine($"Student's ID number is: {studentIdNumber}");

Rectangle rectangle = new(5, 10);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Area of the rectangle is: {rectangleArea}");

Square square = new(5);
var squareArea = square.Area();
Console.WriteLine($"Area of the square is: {squareArea}");

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidPerimeter = cuboid.Perimeter();
var cuboidVolume = cuboid.Volume();

Console.WriteLine($"Area of the cuboid is: {cuboidArea}");
Console.WriteLine($"Perimeter of the cuboid is: {cuboidPerimeter}");
Console.WriteLine($"Volume of the cuboid is: {cuboidVolume}");

Sphere sphere = new(5);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();

Console.WriteLine($"The Circumference of the Sphere is: {sphereCircumference}");
Console.WriteLine($"Volume of the Sphere is: {sphereVolume}");