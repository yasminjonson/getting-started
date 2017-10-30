using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticTester
{
    class DiagnosticTester
    {
        static void Main(string[] args)
        {

        public String question;
        public String[] answers;
        public int correctAnswer;

        public int category;
        public int level;

        public Question(int category, int level, String q, String[] a, int correct)
        {
            this.category = category;
            this.question = q;
            this.level = level;

            this.answers = a;
            this.correctAnswer = correct;
        }

        private List<Question> questions = new List<Question>();
        {
          

        }
    Random rnd = new Random();

    List<Question> possible = this.question.Where(n => n.category == categoryNum && n.level == levelNum).ToList();

    int qnum = 0;

    for (int i = 0; i< 300; i++ )
        {
          qnum = rnd.Next(0, possible.Count - 1);
          Question q = possible[qnum];
          possible.RemoveAt(qnum);
          possible.Add(q);

        }

qnum = 0;
    while(true)
    {
     Question q = possible[qnum];

     Console.writeLine(Queryable.question);

     foreach(String answer in q.answers)
     {Console.writeLine(answer);}

     Console.writeLine("What is your answer?: ");
     String choice = Console.ReadLine().ToUpper();
     interface answerIndex = choice[0] - 'A';

     qnum++;
     if (qnum == possible.Count)
         qnum = 0;
    
    }





















        }
    }
}
