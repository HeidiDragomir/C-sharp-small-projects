
namespace GameDataParse.UserInteraction
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadValidFilePath()
        {
            bool isFilePathValid = false;
            var fileName = default(string);
            do
            {
                Console.WriteLine("Enter the name of the file you want to read:");

                fileName = Console.ReadLine();

                if (fileName is null)
                {
                    Console.WriteLine("File name cannot be null.");
                }
                else if (fileName == string.Empty)
                {
                    Console.WriteLine("File name cannot be empty.");
                }
                else if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found.");
                }
                else
                {
                    isFilePathValid = true;
                }
            }
            while (!isFilePathValid);
            return fileName;
        }


    }
}
