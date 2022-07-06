// See https://aka.ms/new-console-template for more information
namespace Fieldsandpropertyclasswork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.eyeproperty = 1;
            human.legproperty = 1;
            human.teethproperty = 50;

            Console.WriteLine(human.eyeproperty);
            Console.WriteLine(human.legproperty);
            Console.WriteLine(human.teethproperty);
        }
    }
}
