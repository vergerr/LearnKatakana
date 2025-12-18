using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Domain
{
    internal class CommandUser
    {
        string _commandAlphabet = string.Empty;
        public string CommandAlphabet
        {
            get => _commandAlphabet;
            set => _commandAlphabet = value.ToUpper();
        }

        string _commandMode = string.Empty;
        public string CommandMode { get => _commandMode; set => _commandMode = value.ToUpper(); }
    }
}
