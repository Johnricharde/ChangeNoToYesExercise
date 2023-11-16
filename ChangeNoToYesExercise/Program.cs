namespace ChangeNoToYesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Why take no for an answer?
            string userInput = Console.ReadLine();
            string agreeableUserInput = userInput.Replace("no", "yes", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(agreeableUserInput);
        }
    }
}
