using System.Data;
using KristofferCLICommands;

namespace Gruppeoppgave;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("> ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;
            if (input == "exit") break;
            Console.WriteLine($" Du skrev: {input}");
            string[] parts = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            string command = parts[0].ToLower();
            string argument = parts.Length > 1 ? parts[1] : "";
            
            
            switch (command)
            {
            case "pwd":
                KristofferCLICommands.PwdCommand.Execute();
                break;
           case "head":
                KristofferCLICommands.HeadCommand.Execute(argument);
                break;
           case "tail":
                KristofferCLICommands.TailCommand.Execute(argument);
                break;
            }
        }
    }
}
