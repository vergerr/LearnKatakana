using ConsoleAppKatakana.Domain;
using ConsoleAppKatakana.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppKatakana
{
    internal class ValidCommandUser
    {
        public ValidCommandUser(IAsk serviceAsk, CommandUser commandUser)
        {
            ServiceAsk = serviceAsk;
            CommandUser = commandUser;
        }

        private IAsk ServiceAsk;
        private CommandUser CommandUser;

        public bool IsCommandAlphabetCorrect
        {
            get => Command._commandAlphabetAccept.ContainsKey(CommandUser.CommandAlphabet);
        }
        public bool IsCommandModeCorrect
        {
            get => Command._commandModeAccept.Contains(CommandUser.CommandMode);
        }
        public string NameAlphabet
        {
            get => Command._commandAlphabetAccept[CommandUser.CommandAlphabet];
        }
        private IReadOnlyList<KeyValuePair<string, string>> DictionaryAlphabet
        {
            get => CommandUser.CommandAlphabet switch { "H" => HiraganaToRomaji.Dic, "K" => katakanaToRomaji.Dic, _ => throw new InvalidOperationException("Alphabet no valid") };
        }

        public void CallAskService()
        {
            switch (CommandUser.CommandMode)
            {
                case "R": ServiceAsk.GuessRomaji(DictionaryAlphabet); break;
                case "J": ServiceAsk.GuessJapanAlphabet(DictionaryAlphabet); break;
                case "S": ServiceAsk.Study(DictionaryAlphabet); break;
                case "EXIT": break;
                default: throw new InvalidOperationException("No mode found");
            }
            ;
        }
    }
}
