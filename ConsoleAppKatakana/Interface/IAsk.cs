using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Interface
{
    internal interface IAsk
    {
        void GuessJapanAlphabet(Dictionary<string, string> alphabetRomaji);
        void GuessRomaji(Dictionary<string, string> alphabetRomaji);
        void Study(Dictionary<string, string> alphabetRomaji);

        List<KeyValuePair<string, string>> GetRandomDictionary(Dictionary<string, string> dict);
    }
}
