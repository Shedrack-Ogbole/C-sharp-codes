using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_class
{                                                                                                                                                                                      
    internal class Car_class
    {
        public string name;
        public string colour;
        public string speed;
        public int number_of_wheel;

        public Car_class(string Na,string Co,string Sp,int NOW)
        {
            name = Na;
            colour = Co;
            speed = Sp;
            number_of_wheel = NOW;
        }

        public Car_class()
        {

        }

    }
}
