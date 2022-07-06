using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fieldsandpropertyclasswork
{
    internal class Human
    {
        private int eye;
        private int leg;
        private int teeth;
        public string color { get; set; }

        public int eyeproperty
        {
            get { return eye; }
            set
            {
                if ( value < 2)
                {
                    eye = 2;
                }
                else if(value > 2)
                {
                    eye = 2;
                }
                else
                {
                    eye = value;
                }

            }

        }

        public int legproperty
        {
            get { return leg; }
            set
            {
                if(value < 2)
                {
                    leg = 2;
                }
                else if(value > 2)
                {
                    leg = 2;
                }
                else
                {
                    eye = value;
                }
            }
        }

        public int teethproperty
        {
            get { return teeth; }
            set
            {
                if(value > 32)
                {
                    teeth = 32;
                }
                else
                {
                    teeth = value;
                }
            }
        }
    }
}
