Certainly! C# provides a wide range of string operations for manipulating and working with strings. Here are some common string operations in C#:

Concatenation: Combining two or more strings together.
csharp

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName); // Output: "John Doe"

----------------------------------------------------------------------------------------
Length: Getting the length (number of characters) of a string.
csharp

string text = "Hello, World!";
int length = text.Length;
Console.WriteLine(length); // Output: 13

----------------------------------------------------------------------------------------
Substring: Extracting a portion of a string.
csharp

string text = "Hello, World!";
string sub = text.Substring(0, 5); // Start at index 0, take 5 characters
Console.WriteLine(sub); // Output: "Hello"

----------------------------------------------------------------------------------------
ToUpper and ToLower: Changing the case of a string.
csharp

string text = "Hello, World!";
string upperCase = text.ToUpper();
string lowerCase = text.ToLower();
Console.WriteLine(upperCase); // Output: "HELLO, WORLD!"
Console.WriteLine(lowerCase); // Output: "hello, world!"

----------------------------------------------------------------------------------------
Split: Splitting a string into an array of substrings based on a delimiter.
csharp

string names = "John,Jane,Jim";
string[] nameArray = names.Split(',');
foreach (string name in nameArray)
{
    Console.WriteLine(name);
}
// Output:
// "John"
// "Jane"
// "Jim"

----------------------------------------------------------------------------------------
Replace: Replacing a substring with another substring.
csharp

string sentence = "C# is a great language.";
string modified = sentence.Replace("great", "awesome");
Console.WriteLine(modified); // Output: "C# is a awesome language."

----------------------------------------------------------------------------------------
Trim: Removing leading and trailing whitespace.
csharp

string input = "  Trim me  ";
string trimmed = input.Trim();
Console.WriteLine(trimmed); // Output: "Trim me"

----------------------------------------------------------------------------------------
String Interpolation: Embedding expressions within a string.
csharp

string name = "Alice";
int age = 30;
string message = $"My name is {name} and I am {age} years old.";
Console.WriteLine(message);
// Output: "My name is Alice and I am 30 years old."
These are just some of the many string operations you can perform in C#. Strings in C# are versatile and offer a wide range of methods and functionalities for working with text data.
