//pwd- vis hvilken katalog man befinner seg i 
//head- vis ett gitt antall linjer fra starten av en fil
//tail- vis ett gitt antall linjer fra slutten av en fil
using System;
using System.IO;
namespace KristofferCLI.Commands
{
    public static class PwdCommand
    {
        public static void Execute()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}