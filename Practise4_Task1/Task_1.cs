class Task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number-array builder program!");
        Console.WriteLine("You may set the array params and get a result.");

        bool keepGoing = true;
        while (keepGoing)
        {
            Console.Write("\nPlease enter the range of numbers for the array: ");
            double rangeBottom = GetValidNumInput("\n\tBottom: ");
            double rangeTop = GetValidNumInput("\tTop: ");

            int step = (int)GetPositiveLimitedNumInput("\nPlease enter the step between numbers: ", rangeTop - rangeBottom);
            int arrayLength = (int)((rangeTop - rangeBottom) / step);
            double[] numbers = new double[arrayLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rangeBottom + step * (i+1);
            }

            Console.WriteLine("\nThe full array by your settings: ");
            int counter = 1;
            foreach (double element in numbers)
            {
                Console.WriteLine($"Element #{counter}: {element}");
                counter++;
            }

            Console.Write("\nDo you want to build another array? ('y' to continue): ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "y")
            {
                keepGoing = false;
            }
        }

        Console.WriteLine("\nThank you for using the number-array builder!");
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