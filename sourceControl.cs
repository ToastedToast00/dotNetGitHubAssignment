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
            Random random = new Random();
            int targetNumber = random.Next(1, 100); // Generates a number between 1 and 99
            bool stop = false;

            Console.WriteLine("Guess a number between 1 and 99. Type 'stop' to exit.");

            while (!stop)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    Console.WriteLine("Stopping...");
                    stop = true;
                }
                else if (int.TryParse(input, out int guess))
                {
                    if (guess == targetNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number.");
                        stop = true;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }


        public static void WordGame()
        {
            List<string> words = new List<string> { "apple", "banana", "grape", "orange", "lemon" };
            Random random = new Random();
            string targetWord = words[random.Next(words.Count)]; // Selects a random word
            bool stop = false;

            Console.WriteLine("Guess the word! Type 'stop' to exit.");

            while (!stop)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    Console.WriteLine("Stopping...");
                    stop = true;
                }
                else if (input.ToLower() == targetWord)
                {
                    Console.WriteLine("Correct! You guessed the word.");
                    stop = true;
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                }
            }
        }

    }
}