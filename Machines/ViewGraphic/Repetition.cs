using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Turing.Machines.ViewGraphic
{
    class Repetition
    {
        char[] Alphabet;
        char[] CurrentWord;
        readonly char MaxSymbol = '\0';

        public Repetition(char[] Alphabet)
        {
            this.Alphabet = new char[Alphabet.Length + 1];
            for (int i = 0; i < Alphabet.Length; i++)
                this.Alphabet[i] = Alphabet[i];
            this.Alphabet[this.Alphabet.Length - 1] = '\0';
            this.CurrentWord = new char[] { Alphabet[0] };
        }

        public Repetition(char[] Alphabet, char[] StartWord)
        {
            this.Alphabet = new char[Alphabet.Length + 1];
            for (int i = 0; i < Alphabet.Length; i++)
                this.Alphabet[i] = Alphabet[i];
            this.Alphabet[this.Alphabet.Length - 1] = '\0';
            CurrentWord = StartWord;
        }

        public Repetition(char[] Alphabet, String StartWord)
        {
            this.Alphabet = new char[Alphabet.Length + 1];
            for (int i = 0; i < Alphabet.Length; i++)
                this.Alphabet[i] = Alphabet[i];
            this.Alphabet[this.Alphabet.Length - 1] = '\0';
            CurrentWord = StartWord.ToCharArray();
        }

        public char[] nextStep()
        {
            int i = CurrentWord.Length - 1;
            CurrentWord[i] = incChar(CurrentWord[i]);

            while (CurrentWord[i] == MaxSymbol)
            {
                CurrentWord[i] = Alphabet[0];

                if (i == 0)
                {
                    Char[] newArray = new Char[CurrentWord.Length + 1];
                    newArray[0] = Alphabet[0];
                    CurrentWord.CopyTo(newArray, 1);
                    CurrentWord = newArray;
                    break;
                }

                CurrentWord[i - 1] = incChar(CurrentWord[i - 1]);
                i--;
            }

            return CurrentWord;
        }

        private char incChar(char letter)
        {
            int i = Array.IndexOf(Alphabet, letter);
            return Alphabet[i + 1];
        }
    }
}
