
namespace fieldsandproperties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            car car1 = new car();
            car1.speedproperty = 5000;
            car1.wheelsproperty = 65;
            car1.color = "yellow";

           
            Console.WriteLine(car1.wheelsproperty);
            Console.WriteLine(car1.color);
        }
    }
}
