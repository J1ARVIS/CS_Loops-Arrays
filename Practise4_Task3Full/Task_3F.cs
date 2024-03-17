class Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the text analyzer program!");

        bool keepGoing = true;
        while (keepGoing)
        {
            Console.Write("\nEnter any text: ");
            string text = Console.ReadLine();

            int charCount = text.Length;
            Console.WriteLine($"\nThe text '{text}' contains {charCount} characters.");

            Console.Write("\nEnter a character to find: ");
            char searchChar = Convert.ToChar(Console.ReadLine().ToUpper()[0]);

            int searchCount = 0;
            foreach (char character in text.ToUpper())
            {
                if (character == searchChar) searchCount++;
            }

            Console.WriteLine($"\nThere are {searchCount} findings of character '{searchChar}'.");

            keepGoing = CheckContinue("\nDo you want to analyze another text?");
        }

        Console.WriteLine("\nThank you for using the text analyzer program!");
    }

    static bool CheckContinue(string prompt)
    {
        bool toContinue = true;
        Console.Write($"{prompt} ('y' to continue): ");

        string answer = Console.ReadLine().ToLower();
        if (answer != "y")
        {
            toContinue = false;
        }

        return toContinue;
    }
}