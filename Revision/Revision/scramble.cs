using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class scramble
    {
        public string scrambledword;
        public string Quess1;
        public string Quess2;
        public string Quess3;
        public string Answer;

        public scramble(string ScrmWord,string quess1,string quess2,string quess3,string answer)
        {
            scrambledword = ScrmWord;
            Quess1 = quess1;
            Quess2 = quess2;
            Quess3 = quess3;
            Answer = answer;
        }
        public scramble()
        {

        }
    }

}
