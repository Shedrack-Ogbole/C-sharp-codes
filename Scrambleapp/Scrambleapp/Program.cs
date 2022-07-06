namespace Scrambleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                        SCRAMBLE QUIZ GAME");
            Console.WriteLine();
            List<Scramble> scramblequest = new List<Scramble>
            {
                new Scramble("1. Guess one correct word from elvo,","love"),
                new Scramble("2. Guess one correct word from ugalh","laugh")
            };
                Console.WriteLine();
                int total = 0; 

            foreach( var quest in scramblequest)
            {
                AskQuestion(quest);
                total += checkanswer(quest.Answer);
                for(int i = 0; i <= 2; i = i - 1)
                {
                    if (checkanswer(quest.Answer) == 0)
                    {
                        Console.Write("Try again");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            Console.WriteLine("Your total score is " + total++);

            static void AskQuestion(Scramble question)
            {
                Console.WriteLine(question.ScrambledWord);
                Console.WriteLine("Enter guess: ");
              
            }
            
            static int checkanswer(string correctanswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Correct! You got 1 point");
                    return 1;
                }

                else
                {
                    Console.WriteLine("Wrong!");
                    return 0;

                }
                
            }

            
        }
    }
}
