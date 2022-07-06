namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<scramble> scramblequestion = new List<scramble>()
            {
                new scramble("mcrsbela","cram","able","am","cram,able,am"),
                new scramble("eonsdryca","second","cry","one","second,cry,one")
            };

            int total = 0;
            foreach(var question in scramblequestion)
            {
                AskQuestion(question);
                total += checkanswer(question.Answer);
            }
             
            static void AskQuestion(scramble question)
            {
                Console.WriteLine(question.scrambledword);
                Console.WriteLine("Enter guess");
            }
            
            static int checkanswer(string correctanswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("correct! You got one point");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Wrong");
                    return 0;
                }
                
            }
            Console.WriteLine($"Your total is {total++}");
        }
    }
}
