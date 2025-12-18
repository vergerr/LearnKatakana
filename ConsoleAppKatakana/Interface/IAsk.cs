using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Interface
{
    internal interface IAsk
    {
        void GuessJapanAlphabet(List<KeyValuePair<string, string>> alphabetRomaji);
        void GuessRomaji(List<KeyValuePair<string, string>> alphabetRomaji);
        void Study(List<KeyValuePair<string, string>> alphabetRomaji);
    }
}
