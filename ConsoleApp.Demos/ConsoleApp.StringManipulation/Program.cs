// initalizing with a regular string literal
string regularString = "Hello, World!";
String interpolatedString = $"The regular string says: {regularString}"; // Using string interpolation to include the regular string in a new string
Console.WriteLine($"{nameof(regularString)}: {regularString}"); // Using nameof to get the variable name and print it along with its value

// Declare without initializing (possible null exception)
string uninitializedString; // This will cause a compile-time error if we try to use it without initializing
//Console.WriteLine($"{nameof(uninitializedString)}: {uninitializedString}"); // This will cause a compile-time error because uninitializedString is not assigned a value

// Initilize to null
string? nullableString = null; // This is allowed because of the nullable reference type
Console.WriteLine($"{nameof(nullableString)}: {nullableString}"); // This will print "nullableString: " because the value is null

// Initialize as an empty string
string emptyString = string.Empty; // This is a valid string, but it contains no characters
string anotherEmptyString = ""; // This is also a valid empty string
Console.WriteLine($"{nameof(emptyString)}: '{emptyString}'"); // This will print "emptyString: ''" to show that it is an empty string
Console.WriteLine($"{nameof(anotherEmptyString)}: '{anotherEmptyString}'"); // This will also print "anotherEmptyString: ''" to show that it is an empty string

// Escape sequences and characters
string sentence = "She said, \"I have your phone number.\""; // Using escape sequences to include double quotes in the string
string filePath = "C:\\Users\\Username\\Documents\\file.txt"; // Using escape sequences to include backslashes in the string
string multiLineString = "This is a multi-line string.\r\nIt spans multiple lines.\nEach line is separated by a newline character."; // Using escape sequences to create a multi-line string
Console.WriteLine($"{nameof(sentence)}: {sentence}");
Console.WriteLine($"{nameof(filePath)}: {filePath}");
Console.WriteLine($"{nameof(multiLineString)}: {multiLineString}");

// Verbatim string literal
string path = @"C:\Users\Username\Documents\file.txt"; // Using a verbatim string literal to avoid the need for escape sequences
string path2 = "C:\\Users\\Username\\Documents\\file.txt"; // Using a regular string literal with escape sequences to represent the same path
Console.WriteLine($"{nameof(path)}: {path}");
Console.WriteLine($"{nameof(path2)}: {path2}");

// Use a const string to prevent modification with a string 
const string path3 = @"C:\Users\Username\Documents\file.txt"; // Using a const string to represent a file path that should not be modified
Console.WriteLine($"{nameof(path3)}: {path3}"); // This will print the value of path3, which is a constant string

// Raw string literals (C# 14.0 feature)
string rawString = """
    This is a raw string literal.
    It can span multiple lines without needing escape sequences.
    You can include "quotes" and \backslashes\ without escaping them.
    """;
Console.WriteLine($"{nameof(rawString)}: {rawString}");

// Review concatenation and interpolation
string s1 = "10";
string s2 = "20";
s1 += s2; // Concatenation using the += operator, s1 now becomes "1020"
string newString = $"{s1} {s2} Some random literal text"; // Using string interpolation to create a new string that includes s1 and s2
string newString2 = s1 + $"{s1} {s2} Some random literal text "; // Using concatenation and interpolation together to create a new string
string newString3 = string.Format("Literal string {0} {1} {2}", s1, s2, "Some random literal text"); // Using string.Format to create a new string with placeholders for s1, s2, and a literal text
Console.WriteLine(newString);
Console.WriteLine(newString2);
Console.WriteLine(newString3);

/* String manipulation methods */


// Null or empty checks
// Find the length of a string 

Console.WriteLine($"{nameof(newString)} has a length of {newString.Length}"); // Using the Length property to find the length of newString
Console.WriteLine($"{nameof(emptyString)} has a length of {emptyString.Length}"); // Using the Length property to find the length of emptyString, which will be 0
// Console.WriteLine($"{nameof(nullableString)} has a length of {nullableString.Length}");

// Using string.IsNullOrEmpty to check if nullableString is null or empty, which will return true
if (!string.IsNullOrEmpty(nullableString))
{
    Console.WriteLine($"{nameof(nullableString)} is not null or empty and has a length of {nullableString.Length}");
    Console.WriteLine($"{nameof(emptyString)} has a length of {emptyString}"); // This will print the length of emptyString, which is 0
}

// Substrings 
string substring = newString.Substring(0, 5); // Using the Substring method to get a substring of newString starting at index 0 and with a length of 5
Console.WriteLine($"{nameof(substring)} has a length of {substring}"); // This will print "Literal" which is the first 5 characters of newString

// Splitting a string 
var splitString = regularString.Split(' ');
for (int i = 0; i < splitString.Length; i++)
{
    Console.WriteLine($"Split part {i}: {splitString[i]}"); // This will print each part of the regularString that was split by the space character
}

// Replace
string replacedString = regularString.Replace("World", "C#"); // Using the Replace method to replace "World" with "C#" in regularString
Console.WriteLine($"{nameof(replacedString)}: {replacedString}"); // This will print "Hello, C#!"

// Convert to String
string numberString = 123.ToString(); // Using the ToString method to convert an integer to a string
Console.WriteLine($"{nameof(numberString)}: {numberString}"); // This will print "123" as a string

// Changing Formatting
string upperCaseString = regularString.ToUpper(); // Using the ToUpper method to convert regularString to uppercase
string lowerCaseString = regularString.ToLower(); // Using the ToLower method to convert regularString to lowercase
string trimmedString = "   Hello, World!   ".Trim(); // Using the Trim method to remove leading and trailing whitespace from the string
string trimmedStartString = "   Hello, World!   ".TrimStart(); // Using the TrimStart method to remove leading whitespace from the string
string trimmedEndString = "   Hello, World!   ".TrimEnd(); // Using the TrimEnd method to remove trailing whitespace from the string
string paddedString = "Hello".PadLeft(10, '*'); // Using the PadLeft method to pad the string with '*' characters on the left until it reaches a total length of 10

Console.WriteLine($"{nameof(upperCaseString)}: {upperCaseString}"); // This will print "HELLO, WORLD!"
Console.WriteLine($"{nameof(lowerCaseString)}: {lowerCaseString}"); // This will print "hello, world!"
Console.WriteLine($"{nameof(trimmedString)}: '{trimmedString}'"); // This will print "Hello, World!" without the leading and trailing spaces
Console.WriteLine($"{nameof(trimmedStartString)}: '{trimmedStartString}'"); // This will print "Hello, World!   " with the leading spaces removed
Console.WriteLine($"{nameof(trimmedEndString)}: '{trimmedEndString}'"); // This will print "   Hello, World!" with the trailing spaces removed
Console.WriteLine($"{nameof(paddedString)}: '{paddedString}'"); // This will print "*****Hello" with 5 '*' characters padding the left side of "Hello"

// String Comparison
string salary = "50000";
int value = 50000;
Console.WriteLine($"{nameof(salary)} equals '50000': {salary.Equals("50000")}"); // Using the Equals method to compare salary with "50000", which will return true}")
Console.WriteLine($"{nameof(salary)} equals '50000' (case-insensitive): {salary.Equals("50000", StringComparison.OrdinalIgnoreCase)}"); // Using the Equals method with StringComparison.OrdinalIgnoreCase to compare salary with "50000" in a case-insensitive manner, which will return true
Console.WriteLine($"{nameof(salary)} equals '50000' (ordinal comparison): {salary.Equals("50000", StringComparison.Ordinal)}"); // Using the Equals method with StringComparison.Ordinal to compare salary with "50000" in an ordinal manner, which will return true
Console.WriteLine(nameof(salary) + ": " + value.ToString("C"));