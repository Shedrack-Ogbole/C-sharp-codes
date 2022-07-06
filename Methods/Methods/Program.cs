// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*static void mymethod()
{
    Console.WriteLine("Ogbole Shedrack");
 
}
mymethod();
mymethod();
mymethod();
mymethod();
mymethod();
static void imethod()
{
    Console.WriteLine("How are you");
}
imethod();
imethod();
imethod();
imethod();
imethod();*/

/*static void Addmethod(int num1, int num2, int num3)
{
    Console.WriteLine(num1 + num2 + num3 );
}
Addmethod(2, 50, 10);*/
/*int num = 7;
double num1 = 77.6;
char myinitials = 'S';
string greetings = "77";*/
//Console.WriteLine("To my students, " + greetings + " I'm " + num + " years old. I am " + myheight +  " metre tall");
//Console.WriteLine($"To my students, {greetings} im {num} years old. i am {myheight} meter tall");
//Console.WriteLine(num1.ToString()+greetings);
/*Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("%");
string num2 = Console.ReadLine();
Console.WriteLine("the result is");
Console.WriteLine(Math.Sqrt (int.Parse(num1) % int.Parse(num2)));
static int mymethod(int num1,int num2, int num3)
{
    return num1 % num2 * num3;
}
Console.WriteLine(mymethod(10,3,5));*/
//string[] cars = { "mercedes benz", "toyota","jeep", "carmry" };
/*foreach(string a in cars)
{
    Console.WriteLine(a);
}
Array.Sort(cars);
foreach (string a in cars)
{
    Console.WriteLine(a);
}
int[] num = { 2, 1, 6, 8, };
Array.Sort(num);
foreach(int a in num)
{
    Console.WriteLine(a);
}
string[] cars = new string[] {"car ","hg ","tyu ","tyi "};
Array.Sort(cars);
foreach (string i in cars) 
{
    Console.Write(i);
}*/
//creating a list
List<string> names = new List<string>();
names.Add("ochoche");
names.Add("joy");
names.Add("adams");
names.Add("gift");

names.Remove("joy");
//Console.WriteLine(names[0]);
foreach (var a in names)
{
    Console.WriteLine(a);
}
