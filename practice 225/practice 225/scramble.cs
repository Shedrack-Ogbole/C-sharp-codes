using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_225
{
    internal class scramble
    {
        public string Question;
        public string Quess1;
        public string Quess2;
        public string Quess3;
        public string Quess4;
      


        public scramble(string Quest,string G1,string G2,string G3,string G4)
        {
            Question = Quest;
            Quess1 = G1;
            Quess2 = G2;
            Quess3 = G3;
            Quess4 = G4;
        }

        public scramble()
        {

        }
    }

}
