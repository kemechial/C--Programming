using System;
using System.IO;

namespace classExercise{
    class Program {
   

        static void Main(string[] args)
        {

          Question q1 = new Question()
          {Query = "What is your name?",
          Options = new string[4] {"NoYB", "Nobody", "someone","cat"},
          Answer = "Yes"
          };

          
          Question q2 = new Question(4)
          {Query = "What is your name?",
          Options = new string[4] {"NoYB", "Nobody", "someone","cat"},
          Answer = "Yes"
          };
          

          Console.WriteLine(q1.ask());
          foreach(string op in q1.Options){
            Console.WriteLine(op);

          }
          Console.Write("Your answer? ");
          if(q1.check(Console.ReadLine()))
             Console.WriteLine("Correct!");
             else
            Console.WriteLine("False!");
        Console.WriteLine(Question.helper("test this"));
          
        }

    }

     class Question{


        public Question()
        {
          Console.WriteLine("This is constructor 1.");
          this.q_id = (new Random()).Next(1000,9000);
        }

          public Question(int s)
        {
          Console.WriteLine("This is constructor 2.");
          this.q_id = s;
        }
        
        public int QuestionID()
        {
          return this.q_id;
        }

        private int q_id { get; set; }

        public static int create_num  { get; set; }

        public string Query { get; set; }
        public string[] Options { get; set; }
        public string Answer { get; set; }

        public string ask()
        {
          return Query;
         
        }

        public string[] giveOptions(){
          return Options;
        }

        public bool check(string ans){
          return Answer.ToLower() == ans.ToLower();
        }

        public static string helper(string  text)
        {
          return text.ToUpper();
        }
 
        }

}

