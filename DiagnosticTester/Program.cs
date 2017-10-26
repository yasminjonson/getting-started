using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticTester
{
    class Program
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


























        }
    }
}
