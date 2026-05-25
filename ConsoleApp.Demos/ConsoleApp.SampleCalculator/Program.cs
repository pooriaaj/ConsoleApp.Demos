// Variable declaration
int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu
while (choice != -1)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Please select an operation (-1 to exit the program) ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci Sequence");
        choice = Convert.ToInt32(Console.ReadLine());

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
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i; // This will calculate the sum of the Fibonacci sequence from num1 to num2
                }
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
    Console.WriteLine("Press any key to continue.");
    Console.ReadLine();
}
}

Console.WriteLine("******** - Thank you for using the sample calculator! - ********");