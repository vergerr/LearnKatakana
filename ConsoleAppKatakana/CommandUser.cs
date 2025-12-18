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
        static string _commandAlphabet = string.Empty;
        public string CommandAlphabet
        {
            get => _commandAlphabet;
            set => _commandAlphabet = value.ToUpper();
        }

        static string _commandMode = string.Empty;
        public string CommandMode { get => _commandMode; set => _commandMode = value.ToUpper(); }
        public bool IsCommandAlphabetCorrect {
            get => Command._commandAlphabetAccept.ContainsKey(CommandAlphabet);
        }
        public bool IsCommandModeCorrect {
            get => Command._commandModeAccept.Contains(CommandMode);
        }
        public string NameAlphabet {
            get => Command._commandAlphabetAccept[CommandAlphabet];
        }

        public Dictionary<string, string> DictionaryAlphabet {
            get => CommandAlphabet switch { "H" => HiraganaToRomaji.GetDic, "K" => katakanaToRomaji.GetDic, _ => throw new InvalidOperationException("Alphabet no valid") };
        }
    }
}
