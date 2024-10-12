using System;
using System.IO;

namespace classExercise{
    class Program {

        static void Main(string[] args)
        {
           Console.WriteLine("Hello"); 

           Student st1 = new Student();

           st1.StudentNo = "436423";
           st1.Name = "Jack";
           st1.Branch = "3-F";

         Student st2 = new Student();

           st2.StudentNo = "431974";
           st2.Name = "Jane";
           st2.Branch = "3-W";

           Student st3 = new Student()
           {StudentNo = "4532", Name = "Brown",
           Branch = "4-D"};


           Console.WriteLine($"Student 1: name: {st1.Name}");
           Console.WriteLine(st3.printInfo());
        }

    }

     class Student{

        public string StudentNo { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public string printInfo()
        {
          
         //  Console.WriteLine($"Student 1: name: {this.Name}");
              return $"Student 1: name: {this.Name}";
        }

        }

}

