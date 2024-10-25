using System;
using hangman;
class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Enter a word, for someone to start guessing: ");
        string gameMasterInput = Console.ReadLine();

        Game game = new Game(gameMasterInput);
        game.Play();


    }
}