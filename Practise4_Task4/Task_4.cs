class Task4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ASCII table program!\n");

        int startAscii = (int)'a';
        int endAscii = (int)'z';

        char[] characters = new char[endAscii - startAscii + 1];
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i] = (char)(startAscii + i);
        }

        Console.WriteLine("{0,10} {1,10}", "Symbol", "ASCII");
        foreach (char character in characters)
        {
            Console.WriteLine("{0,10} {1,10}", character, (int)character);
        }

        Console.WriteLine("\nThank you for using the ASCII table program!");
    }
}