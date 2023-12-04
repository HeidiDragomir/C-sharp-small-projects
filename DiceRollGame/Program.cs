using DiceRollGame.Game;


var random = new Random();

var dice = new Dice(random);

var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();

GuessingGame.PrintResult(gameResult);


Console.ReadKey();




// THE FIRST VERSION OF THE GAME WITHOUT CLASSES

//int randomNumber = new Random().Next(1, 7);

//Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries. ");

//var wrongGuesses = 0;
//var shallExit = false;

//while (wrongGuesses < 3 && !shallExit)
//{
//    Console.WriteLine("Enter a number:");

//    var userInput = Console.ReadLine();
//    bool result = int.TryParse(userInput, out int number);


//    if (number == randomNumber)
//    {
//        Console.WriteLine("You win!");
//        shallExit = true;
//    }
//    else if (number != randomNumber && number != 0)
//    {
//        wrongGuesses++;
//        Console.WriteLine("Wrong number.");
//        Console.WriteLine("Number of guesses: " + wrongGuesses);

//        if (wrongGuesses == 3)
//        {
//            Console.WriteLine("You lose!");
//            shallExit = true;
//        }
//    }
//    else if (number == 0 || userInput.Length == 0)
//    {
//        Console.WriteLine("Wrong Input.");
//    }

//}


//Console.WriteLine("The game is finished!");
//Console.ReadKey();
