

namespace DiceRollGame.UserCommunication
{
    public static class ConsoleReader
    {
        //create a method which keep asking the users until they provide a valid number ==> the result is the user input
        public static int ReadUserInput(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
