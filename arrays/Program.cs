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

string[] cities = {"New York", "Paris", "London", "Berlin"};

var result = cities[1..3];
Console.WriteLine(result[1]);

foreach(var city in cities){
    Console.WriteLine($"the city in cities: {city}");
}

foreach(var city in cities[2..]){
    Console.WriteLine($"the city in cities: {city[1..]}");
}

