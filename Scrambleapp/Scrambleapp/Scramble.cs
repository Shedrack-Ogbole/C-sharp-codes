using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambleapp
{
    internal class Scramble
    {
        public string ScrambledWord;
        public string Answer;

        

        public Scramble(string scrambleword, string answer)
        {
            ScrambledWord = scrambleword;

            Answer = answer;

        }

        public Scramble()
        {

        }
    }


    
}
