using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Domain
{
    internal static class Command
    {
        public static readonly Dictionary<string, string> _commandAlphabetAccept = new Dictionary<string, string>()
        {
            ["H"] = "Hiragana",
            ["K"] = "Katakana"
        };
        public static readonly HashSet<string> _commandModeAccept = ["R", "J", "S", "EXIT"];
    }
}
