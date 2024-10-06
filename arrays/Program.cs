var courseName="C# programming lessons";
Console.WriteLine(courseName[4]);

var words=courseName.Split(" ");
Console.WriteLine(words[2]);

string[] names = new string[4];

names[2]="dog";
names[0]="cat";

Console.WriteLine(names[2]);
Console.WriteLine(names[1]);

int[] numbers = new int[20];

string[] names2 = {"fish","elephant"};

names.SetValue("bird",1);
Console.WriteLine(names[1]);
Console.WriteLine(names.GetValue(2));