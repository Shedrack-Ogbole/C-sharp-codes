// See https://aka.ms/new-console-template for more information

//static int squaremethod(int num1)
//{
//    return num1 * num1;
//}
//Console.WriteLine(squaremethod(1));

//static void method()
//{
//    DateTime now = DateTime.Now;
//    Console.WriteLine("Today is " + (now.ToString("dddd") + " the time is " + now.ToString("hh:mm:tt") + " and we are in the year " + now.ToString("yyyy")));
//}
//method();
static int MaxMethod(int num1, int num2)

{
    if (num1 > num2)
    {
        return (num1);
    }
    else if (num2 > num1)
    {
        return (num2);
    }
    else
    {
        return num1=num2;
    }
}
Console.WriteLine(MaxMethod(7, 20));



