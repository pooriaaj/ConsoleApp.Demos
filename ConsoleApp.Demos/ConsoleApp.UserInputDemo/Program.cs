string? name = string.Empty;
int age;
int minWorkingAge = 18;
decimal salary;
char gender;
bool isEmployed = true;

Console.Write("Please enter your name: ");
name = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(value: Console.ReadLine());

Console.Write("Are you working? (True or False): ");
isEmployed = Convert.ToBoolean(Console.ReadLine());


int yearsWorking = age - minWorkingAge;

Console.Write($"Hello {name}, you are {age} years old, and you have been working for {yearsWorking} years. Your salary is {salary:C}, your gender is {gender}, and it is {isEmployed} that you are currently employed.");
