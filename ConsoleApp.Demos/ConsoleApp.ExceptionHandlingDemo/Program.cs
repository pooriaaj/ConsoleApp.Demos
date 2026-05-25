try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You age is: {age}");
}
catch (Exception)
{
    Console.WriteLine("An error occurred while processing your input. Please make sure to enter a valid number for your age.");
    //throw;
}

finally
{
    Console.WriteLine("Thank you for using this program.");
}