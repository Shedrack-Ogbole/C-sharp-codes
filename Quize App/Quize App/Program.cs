// See https://aka.ms/new-console-template for more information

Console.WriteLine("                                      WELCOME TO GENIUS BIOLOGY QUIZE APP");
Console.WriteLine("YOU HAVE FROM QUESTION 1-5............LET GET STATED!!!");

List<int> score = new List<int>();
List<string> Reg = new List<string>();
Console.WriteLine("ENTER REGISTRATION NUMBER");
string regnumber = Console.ReadLine();
int attemptleft = 5;
while (true)
{

    Reg.Add("123");
    Reg.Add("456");
    Reg.Add("789");
    Reg.Add("225");
    for (int i = 1; i <= 5; i = i+1)
    {
     

        if (Reg.Contains(regnumber))
        {
            Console.WriteLine("YOU HAVE SUCCESSFULLY LOGED IN");



            List<string> question = new List<string>();
            question.Add("1. Bios means?....... (a)Earth (b) Life  (c) Death ");
            Console.WriteLine(question[0]);
            Console.WriteLine("Select an option");
            string ans = Console.ReadLine();
            if (ans == "b")
            {
                Console.WriteLine("Correct!... 2mrks");
                score.Add(2);
            }
            else if (ans == "a")
            {
                Console.WriteLine("Wrong!");
            }
            else if (ans == "c")
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }



            question.Add("2. What is Zoology?....... (a)Study of plants (b) Study of gene  (c) Study of animals ");
            Console.WriteLine(question[1]);
            Console.WriteLine("Select an option");
            string ans2 = Console.ReadLine();
            if (ans2 == "c")
            {
                Console.WriteLine("Correct!... 2mrks");
                score.Add(2);
            }
            else if (ans2 == "a")
            {
                Console.WriteLine("Wrong!");
            }
            else if (ans2 == "b")
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }




            question.Add("3. What is Botany?....... (a)Study of plants (b) Study of gene  (c) Study of animals ");
            Console.WriteLine(question[2]);
            Console.WriteLine("Select an option");
            string ans3 = Console.ReadLine();

            if (ans3 == "a")
            {
                Console.WriteLine("Correct!... 2mrks");
                score.Add(2);
            }
            else if (ans3 == "b")
            {
                Console.WriteLine("Wrong!");
            }
            else if (ans3 == "c")
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }


            question.Add("4. What is Anatomy?....... (a)Study of internal structure of living things " +
                "(b) Study of external structure of living things  (c) Study of the functions of the internal structure of plants and animals ");
            Console.WriteLine(question[3]);
            Console.WriteLine("Select an option");
            string ans4 = Console.ReadLine();

            if (ans4 == " a")
            {
                Console.WriteLine("Correct!... 2mrks");
                score.Add(2);
            }
            else if (ans4 == "b")
            {
                Console.WriteLine("Wrong!");
            }
            else if (ans4 == "c")
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }


            question.Add("5. One of this is not an organization of life....... (a) Cell (b) filament  (c) System ");
            Console.WriteLine(question[4]);
            Console.WriteLine("Select an option");
            string ans5 = Console.ReadLine();
            if (ans5 == "b")
            {
                Console.WriteLine("Correct!... 2mrks");
                score.Add(2);
            }
            else if (ans5 == "a")
            {
                Console.WriteLine("Wrong!");
            }
            else if (ans5 == "c")
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }


            Console.WriteLine("Your total score is " + score.Sum());

        }
        else
        {
            Console.WriteLine($"INVALID REGISGRATION NUMBER, YOU HAVE ");
            Console.WriteLine($"u  have { attemptleft = attemptleft - 1}");
        }
       
    }break;
    Console.WriteLine("blocked");
} 




