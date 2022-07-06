// See https://aka.ms/new-console-template for more information
while (true)
{

Console.WriteLine("Hello, World!");
Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("Enter second number");
string num2 = Console.ReadLine();
Console.WriteLine("multiplying");
string num3 = Console.ReadLine(); 
int total = int.Parse(num1) + int.Parse(num2);
Console.WriteLine("Answer is " + total * int.Parse(num3));

Console.WriteLine("enter first number");
string num4 = Console.ReadLine();
Console.WriteLine("Modulor(%)");
string num5 = Console.ReadLine();
Console.WriteLine("Remainder " + int.Parse(num4) % int.Parse(num5));
}






