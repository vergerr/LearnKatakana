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
        public ValidCommandUser(IAsk serviceAsk)
        {
            ServiceAsk = serviceAsk;
        }

        static string _commandAlphabet = string.Empty;
        public string CommandAlphabet
        {
            get => _commandAlphabet;
            set => _commandAlphabet = value.ToUpper();
        }

        static string _commandMode = string.Empty;
        public string CommandMode { get => _commandMode; set => _commandMode = value.ToUpper(); }

        private IAsk ServiceAsk;

        public bool IsCommandAlphabetCorrect
        {
            get => Command._commandAlphabetAccept.ContainsKey(CommandAlphabet);
        }
        public bool IsCommandModeCorrect
        {
            get => Command._commandModeAccept.Contains(CommandMode);
        }
        public string NameAlphabet
        {
            get => Command._commandAlphabetAccept[CommandAlphabet];
        }
        private List<KeyValuePair<string, string>> DictionaryAlphabet
        {
            get => CommandAlphabet switch { "H" => HiraganaToRomaji.Dic, "K" => katakanaToRomaji.Dic, _ => throw new InvalidOperationException("Alphabet no valid") };
        }

        public void CallAskService()
        {
            switch (_commandMode)
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
