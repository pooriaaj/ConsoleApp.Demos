// For Loop

// Ask User for a number and show the multiplication table for that number

Console.WriteLine("Please enter a number to see its multiplication table:");

int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 0) // Check for negative numbers
{
    Console.WriteLine("Negative numbers are not allowed. Please enter a non-negative number.");
    return;
}

Console.WriteLine($"Multiplication Table for {Number}:");

for (int i = 0; i <= 10; i++)
{
    int result = Number * i;
    Console.WriteLine($"{Number} x {i} = {result}");
}

// While Loop

Console.WriteLine($"Please enter a number to see its multiplication table (using while loop): ");

int NewNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication Table for {NewNumber}:");

int counter = 0;
if (counter < 0) // Check for negative numbers
{
    Console.WriteLine("Negative numbers are not allowed. Please enter a non-negative number.");
    return;
}

while (counter <= 10)
{
    int NewResult = NewNumber * counter;
    Console.WriteLine($"{NewNumber} x {counter} = {NewResult}");

    counter++;
}

// Do-While Loop

Console.WriteLine($"Please enter a number to see its multiplication table (using do-while loop): ");

int Newcounter = 0;
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

if (ThirdNumber < 0) // Check for negative numbers
{
    Console.WriteLine("Negative numbers are not allowed. Please enter a non-negative number.");
    return;
}

do
{
    int ThirdResult = ThirdNumber * Newcounter;
    Console.WriteLine($"{ThirdNumber} x {Newcounter} = {ThirdResult}");
    Newcounter++;
} while (Newcounter <= 10);

        
// 1. FOR LOOP CHALLENGE

Console.WriteLine("Please enter a number to see its multiplication table (For Loop): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Negative numbers are not allowed. Skipping to While Loop...\n ");
    return; // Exits this method immediately and moves to Main()'s next line
}

Console.WriteLine($"Multiplication Table for {number}: ");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}
Console.WriteLine(); // Prints a blank line for clean spacing

// 2. WHILE LOOP CHALLENGE
Console.WriteLine("Please enter a number to see its multiplication table (While Loop): ");
int Newnumber = Convert.ToInt32(Console.ReadLine());

if (Newnumber < 0)
{
    Console.WriteLine("Negative numbers are not allowed. Skipping to Do-While Loop...\n ");
    return; // Exits this method immediately
}

Console.WriteLine($"Multiplication Table for {Newnumber}:");

// We can safely reuse the variable name 'i' here because it belongs to a new scope!
int counter2 = 0;
while (counter2 <= 10)
{
    Console.WriteLine($"{Newnumber} x {counter2} = {Newnumber * counter2}");
    counter2++;
}
Console.WriteLine();

// 3. DO-WHILE LOOP CHALLENGE

Console.WriteLine("Please enter a number to see its multiplication table (Do-While Loop): ");
int Newnumber2 = Convert.ToInt32(Console.ReadLine());

if (Newnumber2 < 0)
{
    Console.WriteLine("Negative numbers are not allowed. Exiting challenge tracker...\n");
    return; // Exits this method immediately
}

Console.WriteLine($"Multiplication Table for {Newnumber2}:");
int counter3 = 0;

do
{
    Console.WriteLine($"{Newnumber2} x {counter3} = {Newnumber * counter3}");
    counter3++;
} while (counter3 <= 10);
Console.WriteLine();