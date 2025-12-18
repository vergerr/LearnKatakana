using ConsoleAppKatakana.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana
{
    internal class AskService : IAsk
    {
        ConsoleAppTP20251210.Interface.IEditConsole _myConsole;

        public AskService(ConsoleAppTP20251210.Interface.IEditConsole editConsole)
        {
            _myConsole = editConsole;
        }

        private List<KeyValuePair<string, string>> GetRandomDictionary(IReadOnlyList<KeyValuePair<string, string>> listAlphabet)
        {
            var rng = Random.Shared;
            List<KeyValuePair<string, string>> listRandom = new List<KeyValuePair<string, string>>(listAlphabet);
            
            for (int i = listRandom.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (listRandom[i], listRandom[j]) = (listRandom[j], listRandom[i]);
            }
            return listRandom;
        }

        public void GuessJapanAlphabet(IReadOnlyList<KeyValuePair<string, string>> listAlphabet)
        {
            var listAlphabetRandom = GetRandomDictionary(listAlphabet);
            string answer;
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<string, string> kvp in listAlphabet)
            {
                sb.Append($"{kvp.Key},");
            }

            for (int i = 0; i < listAlphabetRandom.Count; i++)
            {
                _myConsole.WriteNewLineTitle($"Question n°{i} : Quel est le katakana '{listAlphabetRandom[i].Value}'");
                Console.WriteLine($"Réponse possible : {sb.ToString()}");
                answer = Console.ReadLine();
                Console.WriteLine($"{(answer.Equals(listAlphabetRandom[i].Key)?"BRAVO ! ":"WRONG ! ")}Answer is : '{listAlphabetRandom[i].Key}'");
                Console.ReadLine();
            }
        }

        public void GuessRomaji(IReadOnlyList<KeyValuePair<string, string>> listAlphabet)
        {
            var listAlphabetRandom = GetRandomDictionary(listAlphabet);
            string answer;

            for (int i = 0; i < listAlphabetRandom.Count; i++)
            {
                _myConsole.WriteNewLineTitle($"Question n°{i} : Quel est la signification de '{listAlphabetRandom[i].Key}'");
                answer = Console.ReadLine().ToLower();
                Console.WriteLine($"{(answer.Equals(listAlphabetRandom[i].Value) ? "BRAVO ! " : "WRONG ! ")}Answer is : '{listAlphabetRandom[i].Value}'");
                Console.ReadLine();
            }
        }

        public void Study(IReadOnlyList<KeyValuePair<string, string>> katakanaRomaji)
        {
            const int newLine = 5;
            int countItem = 0;
            _myConsole.WriteNewLineTitle("Study");
            foreach (KeyValuePair<string, string> kvp in katakanaRomaji)
            {
                countItem++;
                Console.Write($"{kvp.Value} = {kvp.Key}{(countItem < newLine ? ",":"")}");
                if (countItem == newLine)
                {
                    countItem = 0;
                    Console.WriteLine();
                }
            }
        }
    }
}
