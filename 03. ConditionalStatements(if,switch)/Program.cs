// Conditional Statements

// Control flow

var age = 18;

// if statement
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else if (age >= 13)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are a child.");
}

// Switch statement (C# 8.0)
Console.WriteLine(age switch
{
    >= 18 => "You are an adult.",
    >= 13 => "You are a teenager.",
    _ => "You are a child."
});

// Traditional switch statement with numbers, case and default
switch (age)
{
    case int n when (n >= 18):
        Console.WriteLine("You are an adult.");
        break;
    case int n when (n >= 13 && n <= 18):
        Console.WriteLine("You are a teenager.");
        break;
    default:
        Console.WriteLine("You are a child.");
        break;
}