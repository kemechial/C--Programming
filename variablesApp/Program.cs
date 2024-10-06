
long l_num = 456;
int number = (int) l_num;
string name = "Edward";
Boolean test = true;
byte some_number = 252;
char initial = 'K';

var sum = number+name+test+some_number+initial;
Console.WriteLine(sum);
//type casting
Console.Write("Input first number: ");
string first_num = Console.ReadLine();
Console.Write("Input second number: ");
string second_num = Console.ReadLine();

var num1 = Convert.ToInt32(first_num);
var num2 = Convert.ToInt32(second_num);

Console.WriteLine(num1+num2);

int? empty = null;

Console.WriteLine(empty.HasValue);
Console.WriteLine(empty.GetValueOrDefault());

int? test1=default;
bool? isActive=null;