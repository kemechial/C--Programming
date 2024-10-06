
string testString = "This course is about C# programming.";

int count = testString.Length;

Console.WriteLine($"number of characters is: {count}");
Console.WriteLine(testString.ToLower());
Console.WriteLine(testString.StartsWith("."));
Console.WriteLine(testString.EndsWith("."));
Console.WriteLine(testString.IndexOf("C#"));
Console.WriteLine(testString.Contains("is"));
Console.WriteLine(testString.Replace("course","lecture"));

DateTime now_time =DateTime.Now;
Console.WriteLine(now_time);
Console.WriteLine(now_time.Year);
Console.WriteLine(now_time.Second);

DateTime dt_new = new DateTime(2045, 7, 5, 10, 12, 24);

Console.WriteLine(dt_new);
Console.WriteLine(dt_new.Month);