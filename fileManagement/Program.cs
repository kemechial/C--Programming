using System.Security.Cryptography;

StreamReader sr = File.OpenText("test.txt");

/*

var s="";

while((s=sr.ReadLine())!=null){
  Console.WriteLine(s);
}
*/

/*
string result = File.ReadAllText("test.txt");
Console.WriteLine(result);
*/

string[] result = File.ReadAllLines("test.txt");

Console.WriteLine(result[0]);

StreamWriter sw = File.CreateText("deneme.txt");

for(int i=0; i<20; i++){

   sw.WriteLine(i);
}

sw.Close();

// or 

using (StreamWriter sw2 = File.AppendText("deneme.txt")){


            for(int i=0; i<20; i++){

            sw2.WriteLine(2*i);
            }

}

using(StreamReader sr2 = File.OpenText("deneme.txt")){
   var s2="";
    while((s2 = sr2.ReadLine())!=null){
        Console.WriteLine(s2);
    }

}

File.WriteAllText("deneme.txt","final word.");
File.AppendAllText("deneme.txt","more words...");

Directory.CreateDirectory("newDirectory");
Directory.CreateDirectory("newDirectory/test");
Directory.CreateDirectory("newDirectory/test/test2");
Directory.CreateDirectory("newDirectory/test/test3");

if(Directory.Exists("newDirectory/test/test2"))
     Directory.Delete("newDirectory/test/test2");
else
   Console.WriteLine("Directory does not exist!");

string path = @"C:\Users\Lenovo\OneDrive - Ege Üniversitesi\BTKAkademi\C#Programming\test5";

Directory.CreateDirectory(path);


string path2 = Directory.GetCurrentDirectory();

Console.WriteLine("Current path is = > " + path2);

string[] dirs = Directory.GetDirectories(path2, "*", SearchOption.TopDirectoryOnly);

foreach(string dir in dirs){
   Console.WriteLine("Directory: " + dir);
}

string[] files = Directory.GetFiles(path2, "*", SearchOption.TopDirectoryOnly);

foreach(string file in files){
   Console.WriteLine("File: " + file);
}