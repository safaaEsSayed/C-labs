using System.Net;
using System.Xml.Linq;

namespace lab06
{
    #region Question Class
    abstract class question
    {

        public int num { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
        public abstract void show();
        public question()
        {
            num = 1;
            body = string.Empty;
            mark = 1;

        }

        public question(int num) : this()
        {
            this.num = num;

        }

        public question(int num, string body) : this()
        {
            this.num = num;
            this.body = body;
        }
        public question(int num, string body, int mark) : this()
        {
            this.num = num;
            this.body = body;
            this.mark = mark;
        }
       

    }
    #endregion

    #region MCQ Class
    class mcq : question
        {
        public string[] choices{ get; set; }
        public mcq(int mark, string body, string[] choices) : base(mark, body)
        {
            this.choices = choices;
        }
        public mcq():base()
        {
            choices = new string[] { "" };
        }
        public override void show()
        {
            Console.WriteLine($"MC Question Number \"{num} \" : \n {body} \t Mark: {mark}\n ");
            for(int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"_ {choices[i]}");
            }
        }
    }
    #endregion

    #region true and false Class
    class tOrF : question
    {
        public tOrF(int num, string body, int mark) : base(num, body, mark)
        {

        }
        public override void show()
        {
            Console.WriteLine($"true or False Question Number \"{num} \" : \n {body} \t Mark: {mark}\n -\"true\" \n -\"false\" ");
        }
    }
    #endregion



    internal class Program
        {
            static void Main(string[] args)
            {
            mcq q1 = new mcq();
            Console.WriteLine("Enter Question");
            q1.body = Console.ReadLine();
            Console.WriteLine("Enter Mark");
            q1.mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of choices");
            int numOfChoices = int.Parse(Console.ReadLine());
            q1.choices = new string[numOfChoices];
            for(int i =0;i<q1.choices.Length;i++)
            {
                Console.WriteLine($"Enter choices {i+1}");
                q1.choices[i] = Console.ReadLine();
            }
            q1.show();

            Console.WriteLine("___________________________________");

            tOrF q2 = new tOrF(9, "Validate output t or f ?", 25);
            q2.show();
        }
        }
    }
