// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

//char Gender = 'M';
string? name = "John"; // ? means it is nullable
string? surname = "Kendrick";

Console.Write("name: ");
name = Console.ReadLine();
Console.Write("surname: ");
surname = Console.ReadLine();

string summation = name + surname;
Console.WriteLine(summation);

//string interpolation
summation = $"{name} {surname} has a dog.";

Console.WriteLine(summation);
int count = summation.Length;
Console.Write($"The number of characters in this sentence is: {count}");
Console.WriteLine("\n"+summation.ToUpper());
var words = summation.Split(" ");
Console.WriteLine(words);


