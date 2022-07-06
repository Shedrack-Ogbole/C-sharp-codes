using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//csharp practice code for fieldandproperties
namespace fieldsandproperties
{
    internal class car
    {

        private int speed;
        private int wheels;
        public string color { get; set; }

        public int speedproperty
        {
            
            get { return speed; }
            set
            {
                if (value > 250)
                {
                    speed = 250;
                }
                else
                {
                    speed = value;
                }
            }

        }

        public int wheelsproperty
        {
            get { return wheels; }
            set
            {
                if(value > 4)
                {
                    wheels = 4;
                }
                else
                {
                    wheels = value;
                }
            }
        }
    }
}
