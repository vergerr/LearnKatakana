using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Interface
{
    internal interface IAsk
    {
        void GuessKatakana(Dictionary<string, string> katakanaRomaji);
        void GuessRomaji(Dictionary<string, string> katakanaRomaji);
        void Study(Dictionary<string, string> katakanaRomaji);

        List<KeyValuePair<string, string>> GetRandomDictionary(Dictionary<string, string> dict);
    }
}
