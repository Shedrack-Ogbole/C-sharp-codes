// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 1; i <= 200; i=i + 1)
{
    if (i % 2 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 2 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
/*string name = "Mr. Samuel";
Console.WriteLine(name);
const int age = 20;*/



