class Task2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the random num-array generator!");
        Console.WriteLine("You may set the array params and get a result.");

        bool keepGoing = true;
        while (keepGoing)
        {
            Console.Write("\nPlease enter the range of random numbers for the array: ");
            int rangeBottom = (int)GetValidNumInput("\n\tBottom: ");
            int rangeTop = (int)GetValidNumInput("\tTop: ");

            int arrayLength = (int)GetPositiveLimitedNumInput("\nPlease enter the array length (up to 50): ", 50);
            int[] numbers = new int[arrayLength];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(rangeBottom, (rangeTop+1));
            }

            List<int> evenNumbers = [];
            foreach (int number in numbers)
            {
                if (number % 2 == 0) evenNumbers.Add(number);
            }

            Console.WriteLine($"\nArray includes {evenNumbers.Count} even numbers: ");
            for (int i = 0; i < evenNumbers.Count; i++)
            {
                Console.Write(evenNumbers[i]);
                if (i < evenNumbers.Count - 1) Console.Write(", ");
            }
            Console.WriteLine();

            //alternative method:
            /*
            string evenNumsList = string.Empty;
            int evenNumCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(rangeBottom, (rangeTop + 1));
                if (numbers[i] % 2 == 0)
                {
                    evenNumCount++;
                    evenNumsList += numbers[i] + ", ";
                }
            }
            evenNumsList = evenNumsList.Remove(evenNumsList.Length - 2, 2);
            Console.WriteLine($"\nArray includes {evenNumCount} even numbers: \n{evenNumsList}"); 
            */

            Console.Write("\nDo you want to generate another array? ('y' to continue): ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "y")
            {
                keepGoing = false;
            }
        }

        Console.WriteLine("\nThank you for using the random num-array generator!");
    }

    static double GetValidNumInput(string prompt)
    {
        double number = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out number))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        return number;
    }

    static double GetPositiveLimitedNumInput(string prompt, double limit)
    {
        bool validInput = false;
        int number = 0;

        while (!validInput)
        {
            number = (int)GetValidNumInput(prompt);

            if (number <= 0 || number > limit)
            {
                Console.WriteLine($"Invalid input. The number should be positive and limited to {limit}");
            }
            else
            {
                validInput = true;
            }
        }
        return number;
    }
}