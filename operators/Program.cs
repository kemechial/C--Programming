using System.IO.Compression;

int? a = null; // ? means a null value can be assigned to a.

int b = 20;

var result =(a ?? 0) + b;

Console.WriteLine(result);
a= 7;
Console.WriteLine(b/a);
Console.WriteLine(((double) b) / a);
a=b--;
Console.WriteLine(a);
Console.WriteLine(b);
Console.Write("input a number: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(num % 2);
Console.Write("input another number: ");
int num2 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.WriteLine(num2 % 3);

//ternary operator

Console.WriteLine(a>b ? "a>b" : "a<=b");

Random rnd = new Random();

int num3 = rnd.Next(20,100);

Console.WriteLine(num3);