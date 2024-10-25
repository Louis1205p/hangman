using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    public class Game
    {
        // definere variablerne
        private string chosenWord;
        private char[] guessedWord;
        private int attemptsLeft;
        public Game(string word)
        {
            chosenWord = word;
            guessedWord = new String('*', chosenWord.Length).ToCharArray(); // har brugt stjerner fordi underscores rammer hinanden som gør at man ik kan se antallet af ord, og man kan ik have mellemrumussa
            attemptsLeft = 12; //

        }
        public void Play()
        {
            Console.WriteLine("welcome to hangman");
            while (attemptsLeft > 0 && new string(guessedWord) != chosenWord) //loopen fortsætter indtil guessedWord er det samme som chosenWord
            {
                Console.WriteLine($"Word: {new string(guessedWord)}"); // viser det man har gættet korrekt 
                Console.WriteLine($"Attempts left: {attemptsLeft}");
                Console.Write("Guess a letter: ");
                char guess = Console.ReadKey().KeyChar; // registrere den knap man trykker på uden at den viser det på skærmen
                Console.WriteLine(" ");

                if (chosenWord.Contains(guess)) // checker om input guess eksisterer i ChosenWord
                {
                    for (int i = 0; i < guessedWord.Length; i++) // checks each letter
                    {
                        if (chosenWord[i] == guess) // checker om guess matcher nogle af bogstaverne i chosenWord
                        {
                            guessedWord[i] = guess;
                        }
                    }
                    Console.WriteLine("you guessed correct");

                }
                else
                {
                    attemptsLeft--; //fjerne et forsøg hver gang man gætter forkert
                    Console.WriteLine("wrong guess");
                }

            }
            if (new string(guessedWord) == chosenWord) // hvis hele ordet er korrekt
            {
                Console.WriteLine("you guessed the word, congratulations :)");
            }
            else
            {
                Console.WriteLine($"you used all you guesses and lost, the word was: {chosenWord}");
            }
            Console.ReadKey();
        }
    }

}