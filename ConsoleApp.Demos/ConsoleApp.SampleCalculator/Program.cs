// Variable declaration
int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu
while (choice != -1)
{
    try
    {
        // Welcome Message
        Console.Write("Please select an operation (1-5) or -1 to exit:");
        PrintMenu();

        if (choice == -1)
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            break; // Exit the loop and end the program
        }
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        double answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                Console.WriteLine($"The sum of {num1} and {num2} is: {answer}");
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                Console.WriteLine($"The difference between {num1} and {num2} is: {answer}");
                break;
            case 3:
                answer = MultiplyNumbers(num1, num2);
                Console.WriteLine($"The product of {num1} and {num2} is: {answer}");
                break;
            case 4:
                answer = DevideNumbers(num1, num2); // Cast to double for accurate division
                    Console.WriteLine($"The quotient of {num1} and {num2} is: {answer}");
                break;
            case 5:
                answer = Fibonacci(num1, num2);
                Console.WriteLine($"The Fibonacci result from {num1} to {num2} is: {answer}");
                break;
            default:
                throw new Exception("Invalid choice, please select a valid operation.");
    }
    // print output 
    Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
    Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
    Console.WriteLine(ex.Message);
    }
    finally
    {
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
    }
}

    Console.WriteLine("******** - Thank you for using the sample calculator! - ********");

// Methods Definitions

int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}
int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}
int MultiplyNumbers(int num1, int num2)
{
    return num1 * num2;
}
double DevideNumbers(int num1, int num2)
{
    return num1 / num2;
}

int Fibonacci(int num1, int num2)
{
    int answer = 0;

    int firstNumber = 0;
    int secondNumber = 1;

    while (firstNumber <= num2)
    {
        if (firstNumber >= num1)
        {
            answer += firstNumber;
        }

        int nextNumber = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }

    return answer;
}
void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Please select an operation (-1 to exit the program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");
    choice = Convert.ToInt32(Console.ReadLine());
}