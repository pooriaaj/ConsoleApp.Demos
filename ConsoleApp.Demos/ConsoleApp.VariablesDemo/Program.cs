string name = "Pooria";
Console.WriteLine(name);
Console.WriteLine("Hello " + name); // string concatenation
Console.WriteLine($"Hello {name}"); // string interpolation, available since C# 6.0, allows you to embed expressions directly in string literals
Console.WriteLine("Hello {0}", name); // string formatting, available since C# 1.0, allows you to format strings using placeholders and arguments   

int Age = 28;
int OrAge = 29;
float avgAge = ((OrAge + Age) / 2);
Console.WriteLine($"I am {Age} or {OrAge} years old. So the avg is {avgAge}");