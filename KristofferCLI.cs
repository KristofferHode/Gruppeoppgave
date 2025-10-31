//pwd- vis hvilken katalog man befinner seg i 
//head- vis ett gitt antall linjer fra starten av en fil
//tail- vis ett gitt antall linjer fra slutten av en fil
using System;
using System.IO;
using System.Threading.Tasks.Dataflow;
namespace KristofferCLICommands
{
    public static class PwdCommand
    {
        public static void Execute()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
    public static class HeadCommand
    {
        public static void Execute(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine("bruk head <filnavn>");
                return;
            }
            if (!File.Exists(filePath))
            {
                Console.WriteLine("filen finnes ikke");
            }
            var lines = File.ReadLines(filePath);
            int count = 0;
            foreach (var line in lines)
            {
                Console.WriteLine(line);
                count++;
                if (count >= 10) break;
            }
        }    }
    public static class TailCommand
            {
            public static void Execute(string filePath)
            {
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    Console.WriteLine("bruk tail <filnavn>");
                    return;
                }
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("filen finnes ikke");
                }

                var lines = File.ReadAllLines(filePath);
                int start = Math.Max(0, lines.Length - 10);
                for(int i = start; i <lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
            
            
            }
        }

    }
