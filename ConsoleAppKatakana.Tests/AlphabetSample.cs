using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Tests
{
    internal static class AlphabetSample
    {
        public static List<KeyValuePair<string, string>> SampleAlphabet =>
    new()
    {
        new("ア", "a"),
        new("イ", "i"),
        new("ウ", "u")
    };
    }
}
