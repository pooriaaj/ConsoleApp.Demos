Console.WriteLine("*** Classes and Objects ***");
Person person;

Person baby = new Person();

Console.WriteLine("Enter your first name: ");
baby.FirstName = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter your last name: ");
baby.LastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Enter your date of birth (yyyy-mm-dd): ");
baby.DateOfBirth = Console.ReadLine() is string dobInput && DateOnly.TryParse(dobInput, out DateOnly dob) ? dob : default;


baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine("Your tax number is: " + taxNumber);