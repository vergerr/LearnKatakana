using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Interface
{
    public interface IAsk
    {
        void GuessJapanAlphabet(IReadOnlyList<KeyValuePair<string, string>> alphabetRomaji);
        void GuessRomaji(IReadOnlyList<KeyValuePair<string, string>> alphabetRomaji);
        void Study(IReadOnlyList<KeyValuePair<string, string>> alphabetRomaji);
    }
}
