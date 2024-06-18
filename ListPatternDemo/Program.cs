// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3 };

if (numbers is [_, 2, _])  // Discard first and last elements
{
    Console.WriteLine("Discard Pattern (Ignoring Elements):");
    Console.WriteLine("The second element is 2!");
}


string[] colors = { "red", "green", "blue" };

if (colors is ["red", .., "blue"])  // Match "red" to "blue"
{
    Console.WriteLine();
    Console.WriteLine("Range Pattern (Matching Specific Subsets):");
    Console.WriteLine("The list starts with 'red' and ends with 'blue'");
}


string[] greetings = { "Hello", "world" };

if (greetings is [var first, var second])
{
    Console.WriteLine();
    Console.WriteLine("Var Pattern (Deconstructing Specific Elements):");
    Console.WriteLine($"First greeting: {first}");
    Console.WriteLine($"Second greeting: {second}");
}


Console.ReadKey();