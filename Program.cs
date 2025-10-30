namespace Gruppeoppgave;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("> ");
            string? input = Console.ReadLine();
            if (input == "exit") break;
            Console.WriteLine($" Du skrev: {input}");
        }
    }
}
