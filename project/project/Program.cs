// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string userinput;
userinput = Console.ReadLine();
Console.Write("the user intered: " + userinput);
Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("enter second number");
string num2 = Console.ReadLine();
Console.WriteLine($"Your answer is {int.Parse(num1) + int.Parse(num2)}");


