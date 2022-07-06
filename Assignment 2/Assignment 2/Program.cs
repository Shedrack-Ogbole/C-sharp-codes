// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter first number");
string num1 = Console.ReadLine();

Console.WriteLine("Enter second number");
string num2 = Console.ReadLine();

Console.WriteLine("Multiply(*)");
string num3 = Console.ReadLine();

Console.WriteLine("Subtracte(-)");
string num4 = Console.ReadLine();

Console.WriteLine("Divide(/)");
string num5 = Console.ReadLine();

int add = int.Parse(num1) + int.Parse(num2);
int multiply = add * int.Parse(num3);

int subtract = multiply - int.Parse(num4);

Console.WriteLine("Final Ans = " + subtract / int.Parse(num5));
