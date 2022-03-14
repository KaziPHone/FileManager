using System;

namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUi ui = new ConsoleUi();
            ui.CreateWindow();
            Console.ReadKey();
        }
    }
}
