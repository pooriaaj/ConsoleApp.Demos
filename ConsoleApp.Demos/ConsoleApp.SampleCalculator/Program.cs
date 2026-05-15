// Show calculator options / Show menu
Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double answer = 0;

if (num1 == 0 || num2 == 0)
{
    Console.WriteLine("One of the numbers is zero, please enter a non-zero number.");
}
else
{
    switch (choice)
    {
        case 1:
            answer = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {answer}");
            break;
        case 2:
            answer = num1 - num2;
            Console.WriteLine($"The difference between {num1} and {num2} is: {answer}");
            break;
        case 3:
            answer = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is: {answer}");
            break;
        case 4:
            answer = (double)num1 / num2; // Cast to double for accurate division
            Console.WriteLine($"The quotient of {num1} and {num2} is: {answer}");
            break;
        default:
            Console.WriteLine("Invalid choice, please select a valid operation.");
            break;
    }
}