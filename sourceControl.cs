namespace sourceControl
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            GameSelect();
        }

        public static void GameSelect()
        {
            while (true)
            {
                Console.WriteLine("Select a game: \n1. Number Game \n2. Word Game \n3. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        NumberGame();
                        break;
                    case "2":
                        WordGame();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            }
        }

        public static void NumberGame()
        {
            Console.WriteLine("Pick a random letter, type \'stop\' to stop");

            Boolean stop = false;
            while (!stop)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    Console.WriteLine("Stopping...");
                    stop = true;
                }

                if (input == "")
                {
                    Console.WriteLine("You picked nothing");
                }

                else
                {
                    Console.WriteLine("You picked: " + input);
                }
                //TODO: Add random number generator to guess the number
                //      Add handling for invalid input (non numbers)
            }
        }

        public static void WordGame()
        {
            Console.WriteLine("Pick a random word, type 'stop' to stop");
            bool stop = false;
            while (!stop)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    Console.WriteLine("Stopping...");
                    stop = true;
                }
                else
                {
                    Console.WriteLine("You picked: " + input);
                }
            }
            //TODO: Add random word generator to get user to guess the word
            //      Add handling for invalid input (non words)
        }
    }
}