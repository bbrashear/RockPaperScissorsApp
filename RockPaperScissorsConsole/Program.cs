using System;

namespace RockPaperScissorsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine("Let's play Rock Paper Scissors! Are you ready?");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("Okay! Rock. Paper. Scissors...");
                }
                else
                {
                    Console.WriteLine("Okay, I'll wait a second.");
                    Console.ReadLine();
                }
            } while (answer.ToLower() == "no");

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("*Please type your choice of Rock, Paper, or Scissors*");
                string userChoice = Console.ReadLine();
                Console.WriteLine();
                string compChoice = MakeCompChoice();
                Console.WriteLine($"Computer Choice: {compChoice}");
                Console.WriteLine();
                Console.WriteLine(WhoWins(userChoice, compChoice));
            }

        }

        public static string WhoWins(string userChoice, string compChoice)
        {
            switch(userChoice.ToLower())
            {
                case "rock":
                    return compChoice.ToLower() == "scissors" ? 
                        "You win!" : compChoice.ToLower() == "rock" ? "It's a tie" : "The Computer wins!";
                    break;
                case "paper":
                    return compChoice.ToLower() == "rock" ?
                        "You win!" : compChoice.ToLower() == "paper" ? "It's a tie" : "The Computer wins!";
                    break;
                case "scissors":
                    return compChoice.ToLower() == "paper" ?
                        "You win!" : compChoice.ToLower() == "scissors" ? "It's a tie" : "The Computer wins!";
                    break;
                default:
                    return "Idk how you got here";
                    break;
            }
        }

        public static string MakeCompChoice()
        {
            var rand = new Random();
            int rps = rand.Next(1, 4); 
            switch(rps)
            {
                case 1:
                    return "Rock";
                    break;
                case 2:
                    return "Paper";
                    break;
                case 3:
                    return "Scissors";
                    break;
                default:
                    return "IDK??";
                    break;
            }
        }
    }
}
