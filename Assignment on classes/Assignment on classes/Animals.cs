using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_on_classes
{
    internal class Animals
    {
        public string name { get; set; }
        public string scientific_name { get; set; }
        public string habitat { get; set; }
        public string pair_of_limb { get; set; }
        public string class_of_animal { get; set; }
        public string collective_name { get; set; }
        public bool regurgitate { get; set; }

        
        public Animals (string Na, string Sname, string H, string POF, string COA, string CN, bool Re)
        {
            name = Na;
            scientific_name = Sname;
            habitat = H;
            pair_of_limb = POF;
            class_of_animal = COA;
            collective_name = CN;
            regurgitate = Re;
        }

        public Animals()
        {

        }




    }
    
}







