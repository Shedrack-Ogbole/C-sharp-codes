// See https://aka.ms/new-console-template for more information
while (true)
{
Console.WriteLine("Hello, World!");
string num1;
string num2;
string op;
Console.WriteLine("Enter two numbers");
num1 = Console.ReadLine();
num2 = Console.ReadLine();
Console.WriteLine("The operators are +,-,*,/,%");
op = Console.ReadLine();
if (op == "+")
{

    Console.WriteLine("The result is");
    Console.WriteLine(int.Parse(num1) + int.Parse(num2));

}
else if (op == "-")
{

    Console.WriteLine("The result is");
    Console.WriteLine(int.Parse(num1) - int.Parse(num2));

}
else if (op == "*")
{

    Console.WriteLine("The result is");
    Console.WriteLine(int.Parse(num1) * int.Parse(num2));

}
else if (op == "/")
{
    Console.WriteLine("The result is");
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));

}

else if (op == "^")
{

    int mum = (int.Parse(num1) + int.Parse(num2));
    Console.WriteLine("The result is");
    Console.WriteLine(Math.Sqrt(mum));

}
else if (op == "%")
{

    Console.WriteLine("The result is");
    Console.WriteLine(int.Parse(num1) % int.Parse(num2));

} 
else
{
    Console.WriteLine("Enter a valid operator");
}
}