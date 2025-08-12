// Operators

// Arithmetic Operators +, -, *, /, %, ++, --

var firstnumber = 100.00;
var secondnumber = 40.00;

Console.WriteLine($"second number = {secondnumber}, next line will show you if the first and second numbers are equal or not");

// Comparison Operators ==, !=, >, <, >=, <=

if (firstnumber == secondnumber)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine("The numbers are not equal");
}

if (firstnumber > secondnumber)
{
    Console.WriteLine("The first number is greater than the second number");
}
else
{
    Console.WriteLine("The first number is not greater than the second number");
}

// Assignment Operators =, +=, -=, *=, /=, %=

var people = 11;

people *= 6; // people = people * 6

Console.WriteLine($"There are about {people} people in this house");

// Logical Operators &&, ||, !

// && - both conditions have to be true

// || - one of the conditions have to be true

// ! - NOT operator (reverses boolean value)

if (firstnumber > secondnumber && secondnumber > 0)
{
    Console.WriteLine(100);
}

if (firstnumber != secondnumber || secondnumber > 0)
{
    Console.WriteLine(200);
}