using System;

namespace csharpProgram
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("------- Welcome to this Rock Paper Scissor Game -------");
            Console.WriteLine("----------------- Starting the game -------------------");
            Console.WriteLine();

            Random random = new Random();
            int robot = random.Next(1, 4);
            String Srobot = "";
            Console.Write("Your turn :  ");
            String input = Console.ReadLine();
            bool win = true;
            bool wantToPlay = true;
            String WantToPlay = "";
            String UpperWantTo = "";

            switch (input)
            {
                case "1": input = "Rock"; break;
                case "2": input = "Paper"; break;
                case "3": input = "Scissors"; break;
            }

            switch (robot)
            {
                case 1: Srobot = "Rock"; break;
                case 2: Srobot = "Paper"; break;
                case 3: Srobot = "Scissors"; break;
            }

            Console.WriteLine();
            Console.WriteLine("Robot's choice: " + Srobot);
            Console.WriteLine("Your choice: " +  input);
            Console.WriteLine();

            if (input == "Rock" && Srobot == "Rock")
            {
                win = false;
                Console.WriteLine("It's a draw");
                Console.WriteLine();

            }
            else if (input == "Paper" && Srobot == "Paper")
            {
                win = false;
                Console.WriteLine("It's a draw");
                Console.WriteLine();

            }
            else if (input == "Scissors" && Srobot == "Scissors")
            {
                win = false;
                Console.WriteLine("It's a draw");
                Console.WriteLine();

            }
            else if (input == "Rock" && Srobot == "Paper")
            {
                win = false;
                Console.WriteLine("You loose");
                Console.WriteLine();

            }
            else if (input == "Paper" && Srobot == "Rock")
            {
                win = true;
                Console.WriteLine("You win");
                Console.WriteLine();

            }
            else if (input == "Paper" && Srobot == "Scissors")
            {
                win = false;
                Console.WriteLine("You loose");
                Console.WriteLine();

            }
            else if (input == "Scissors" && Srobot == "Paper")
            {
                win = true;
                Console.WriteLine("You win");
                Console.WriteLine();

            }
            else if (input == "Rock" && Srobot == "Scissors")
            {
                win = true;
                Console.WriteLine("You win");
                Console.WriteLine();

            }
            else if (input == "Scissors" && Srobot == "Rock")
            {
                win = false;
                Console.WriteLine("You loose");
                Console.WriteLine();

            } 
            else
            {
                win = false;
                Console.WriteLine("Invalid Input");
                Console.WriteLine();
            }

            if (win == false)
            {
                Main();
            }
            else
            {
                Console.Write("Want to play again (Y/N) : ");

                WantToPlay = Console.ReadLine();
                if(WantToPlay.ToUpper() == "Y")
                {
                    Main();
                }
                else if (WantToPlay.ToUpper() == "N")
                {
                    Console.WriteLine("Thank you!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid Inpute..Leaving program");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            


        }
    }
}
