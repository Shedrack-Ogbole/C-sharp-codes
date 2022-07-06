// See https://aka.ms/new-console-template for more information
namespace Classes

{
    class Program
    {
        static void Main(string[] args)
            //storing quiz question in a list
        {
            List<Quizquestion> listquest = new List<Quizquestion>
            {
                new Quizquestion("What is the function of the red blood cells in the body","Transportation of oxygen","fight agains invaders","Enable clotting of blood","Generats energy for the cell","A"),
                new Quizquestion("One of this has both plant and animal characteristics","chlamydomonas","Amoeba","Euglena","Paramecium","C"),
                new Quizquestion("Which among this organisms is unicellular", "spirogyra", "hydra", "euglena", "volvox", "C")
            };

            //intitializing 
            int totalgrade = 0;

            //looping through our quiz question to display th quiz questions and also call the checkanswer method
            foreach(var quest in listquest)
            {
                AskQuestion(quest);
                totalgrade += CheckAnswer(quest.Answer);
            }

            static void AskQuestion(Quizquestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("(A)" + question.OptionA);
                Console.WriteLine("(B)" + question.OptionB);
                Console.WriteLine("(C)" + question.OptionC);
                Console.WriteLine("(D)" + question.OptionD);
                Console.WriteLine("Enter option:");
            }


            Console.WriteLine("Your total score is " + totalgrade);

            static int CheckAnswer( string correctanswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("PASS! You have 1 point");
                    return 1;
                }
                else
                {
                    Console.WriteLine("FAILED");
                    return 0;
                }
            }

           
            //static void AskQuestion(Quizquestion question)
            //{
            //    Console.WriteLine(question.Question);
            //    Console.WriteLine("(A)" + question.OptionA);
            //    Console.WriteLine("(B)" + question.OptionB);
            //    Console.WriteLine("(C)" + question.OptionC);
            //    Console.WriteLine("(D)" + question.OptionD);
            //    Console.WriteLine("Enter option:");
            //}
            

            //Quizquestion quistion1 = new Quizquestion();
            //quistion1.Question = "What is the function of the red blood cells in the body";
            //quistion1.OptionA = "Transportation of oxygen";
            //quistion1.OptionB = "fight agains invaders";
            //quistion1.OptionC = "Enable clotting of blood";
            //quistion1.OptionA = "Generats energy for the cell";

            //Quizquestion quistion2 = new Quizquestion();
            //quistion2.Question = "One of this has both plant and animal characteristics";
            //quistion2.OptionA = "chlamydomonas";
            //quistion2.OptionB = "Amoeba";
            //quistion2.OptionC = "Euglena";
            //quistion2.OptionA = "Paramecium";

            //Quizquestion Question3 = new Quizquestion("Which among this organisms is unicellular", "spirogyra", "hydra", "euglena", "volvox", "euglena");


        }


    }
}
