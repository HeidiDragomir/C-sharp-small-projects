using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int AllowedTries = 3;


        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            // roll dice and save the result in a variable
            var diceRollResult = _dice.Roll(); //we get the random number here

            // print the welcome message
            Console.WriteLine($"Dice rolled. Guess what number it shows in {AllowedTries} tries.");

            //create a variable that holds the number of tries left
            //it's initialized with the number of AllowedTries that is decreasing after each loop
            var triesLeft = AllowedTries;

            //loop to guess the number
            while (triesLeft > 0)
            {
                var message = "Enter a number: ";

                var guess = ConsoleReader.ReadUserInput(message);

                //here we check if the user input is equal with the generated dice number
                //if true ==> win, otherwise ==> lose
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }

                Console.WriteLine("Wrong number.");
                triesLeft--;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory ? "You win!" : "You lose! :(";

            Console.WriteLine(message);
        }
    }
}
