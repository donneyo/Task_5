namespace Task_5;

class Great
{
    static void Main(string[] args)
     {
            // Call the Greet method with the argument "Alice"
            Greet("Alice");

            // Keep the console window open
            Console.ReadLine();
        }

        // Method that prints a personalized greeting message
        static void Greet(string name)
        {
            // Print the greeting message to the console
            Console.WriteLine("Hello, " + name + "!");
        }
}
