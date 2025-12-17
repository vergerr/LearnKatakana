using ConsoleAppKatakana.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana
{
    internal class AskKatakanaRomaji : IAsk
    {
        ConsoleAppTP20251210.Interface.IEditConsole myConsole = new ConsoleAppTP20251210.EditConsole();

        public List<KeyValuePair<string, string>> GetRandomDictionary(Dictionary<string, string> dict)
        {
            var list = dict.ToList();

            var rng = Random.Shared;
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
            return list;
        }

        public void GuessKatakana(Dictionary<string, string> katakanaRomaji)
        {
            var list = GetRandomDictionary(katakanaRomaji);
              
            for(int i = 1; i <= list.Count; i++)
            {
                myConsole.WriteNewLineTitle($"Question n°{i} : Quel est le katakana '{list[i].Value}'");
                Console.ReadLine();
                Console.WriteLine($"Answer is : '{list[i].Key}'");
                Console.ReadLine();
            }
        }

        public void GuessRomaji(Dictionary<string, string> katakanaRomaji)
        {
            var list = GetRandomDictionary(katakanaRomaji);

            for (int i = 1; i <= list.Count; i++)
            {
                myConsole.WriteNewLineTitle($"Question n°{i} : Quel est la signification de '{list[i].Key}'");
                Console.ReadLine();
                Console.WriteLine($"Answer is : '{list[i].Value}'");
                Console.ReadLine();
            }
        }

        public void Study(Dictionary<string, string> katakanaRomaji)
        {
            const int newLine = 5;
            int countItem = 0;
            myConsole.WriteNewLineTitle("Study");
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
            Console.ReadLine();
        }
    }
}
