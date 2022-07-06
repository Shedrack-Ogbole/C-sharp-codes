using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    internal class Car
    {

        public static int number_of_cars;

        public Car()
        {
            number_of_cars ++;
        }

        static p carmethod()
        {
            Console.WriteLine("The race has stated");
        }

    }
}
