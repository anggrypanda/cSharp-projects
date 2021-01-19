using System;

namespace cSharp_rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            string result;
            int countUser = 0;
            int countComputer = 0;

            Console.WriteLine("Welcome to RPS game");

            while (answer != "NO")
            {
                Console.WriteLine("Select any one:\nROCK\nPAPER\nSCISSORS");
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSORS" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);

                Console.WriteLine("\nEnter your choice: ");
                string userInput = Console.ReadLine().ToUpper();

                if (userInput.Equals("rock", StringComparison.InvariantCultureIgnoreCase) ||
                    userInput.Equals("paper", StringComparison.InvariantCultureIgnoreCase) ||
                    userInput.Equals("scissors", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("\nComputer: " + choices[n]);

                    if (userInput == "ROCK" && choices[n] == "SCISSORS")
                    {
                        result = "User wins";
                        countUser += 1;
                    }
                    else if (userInput == "ROCK" && choices[n] == "PAPER")
                    {
                        result = "Computer wins";
                        countComputer += 1;
                    }
                    else if (userInput == "PAPER" && choices[n] == "ROCK")
                    {
                        result = "User wins";
                        countUser += 1;
                    }
                    else if (userInput == "PAPER" && choices[n] == "SCISSORS")
                    {
                        result = "Computer Wins";
                        countComputer += 1;
                    }
                    else if (userInput == "SCISSORS" && choices[n] == "ROCK")
                    {
                        result = "Computer Wins";
                        countComputer += 1;
                    }
                    else if (userInput == "SCISSORS" && choices[n] == "PAPER")
                    {
                        result = "User wins";
                        countUser += 1;
                    }
                    else
                    {
                        result = "Draw";
                    }

                    Console.WriteLine("\nResult: " + result);
                }
                else
                    Console.WriteLine("\nPlease choose one of the 3 options ");

                Console.WriteLine("\nDo you want to continue? (YES/NO)");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("User wins " + countUser + " times");
            Console.WriteLine("Computer wins " + countComputer + " times");
        }
    }
}