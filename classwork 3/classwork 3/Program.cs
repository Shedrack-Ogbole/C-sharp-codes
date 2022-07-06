// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string num1;
Console.WriteLine("Enter a number");
num1 = Console.ReadLine();
if (int.Parse(num1) > 10)
{
    Console.WriteLine("The number you entered is greater than 10");
}
else if (int.Parse(num1) == 0)
{
    Console.WriteLine("The number you entered is 0");
}
else if (int.Parse(num1) == 2)
    Console.WriteLine("The number you entered is 2");
else
{
    Console.WriteLine("The number you entered is less than 10");
}
