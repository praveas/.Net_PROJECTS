using System; 

namespace NumberGuesser //namespace is like a container for class and functions
{
    //Main Class
    class Program
    {
        //Entry Point Method
        //not gonna be any return
        //static means refering to function itself
        static void Main(string[] args)//void is a return type of this method    
        {
            GetAppInfo(); // Run GetAppInfo func to get info


            GreetUser(); // Ask for users name and greet

            while (true) {
                // Init correct number
                //int correctNumber = 7;

                // Create a new Random Object
                Random random = new Random();

                // Gives random number from 1 to 10
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");


                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message
                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N"){
                    return;
                }
                else
                {
                    return;
                }

            }


        }

        // Get and Display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Prabesh Pokharel";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther); //using placeholder

            // Reset text color
            Console.ResetColor();
        }

        //Ask User name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message); //using placeholder

            // Reset text color
            Console.ResetColor();

            //end of the code
        }
    }
}
