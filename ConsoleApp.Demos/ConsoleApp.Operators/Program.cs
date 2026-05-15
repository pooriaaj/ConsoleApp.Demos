// getting number from user in two different ways

Console.WriteLine("Please enter your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = (int)(num1 + num2);
int multiplication = (int)(num1 * num2);
int division = (int)(num1 / num2);
int subtraction = (int)(num1 - num2);
int modulus = (int)(num1 % num2);

Console.WriteLine("********************* Math Results *********************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Multiplication: {multiplication}");
Console.WriteLine($"Division: {division}");
Console.WriteLine($"Subtraction: {subtraction}");
Console.WriteLine($"Modulus: {modulus}");

/* Logic Operators */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isNotEqualTo = num1 != num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;

Console.WriteLine("********************* Logic Results *********************");

Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is num1 greater than num2 AND is num1 less than 100: {isGreaterThan && num1 < 100}");
Console.WriteLine($"Is num1 greater than num2 OR is num1 less than 100: {isGreaterThan || num1 < 100}");

Console.WriteLine("End of program.");
Console.WriteLine();

// Assignment Operators // 

num1 += 5;
num1 -= 3;
num1 /= 2;
num1 %= 2;
num1 *= 10;

Console.WriteLine($"Num1 now is {num1}"); 