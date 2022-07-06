using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Quizquestion
    {
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }

        public Quizquestion(string quest, string opA,string opB,string opC,string opD,string ans)
        {
            Question = quest;
            OptionA = opA;
            OptionB = opB;
            OptionC = opC;
            OptionD = opD;
            Answer = ans;
        }

       public Quizquestion()
        {

        }
    }
   
}
