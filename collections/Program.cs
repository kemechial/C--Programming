using System;
using System.IO;
using System.Collections;

namespace classExercise{
    class Program {
   

        static void Main(string[] args)
        {

          ArrayList a_list = new ArrayList();

          a_list.Add(6);
          a_list.Add("test");
          a_list.Add(true);

          var list2 = new ArrayList() {
            7, "test", "fdgdgfd", true, 8
          };

          int[] nums = {5, 8, 9};

          list2.AddRange(nums);

          list2.Insert(3, "added");

          foreach (var e in list2) {
            Console.WriteLine(e);
          }

          List<int> nums2 = new List<int>();

          nums2.Add(5);

          nums2.Add(7);

          List<Question> qlist = new List<Question>();



        Dictionary<int, string> registerations = new Dictionary<int, string>();

        registerations.Add(4, "test");
        registerations.Add(3,"another");

        Console.WriteLine(registerations[3]);



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


