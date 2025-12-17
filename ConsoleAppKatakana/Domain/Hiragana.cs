using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Domain
{
    internal class HiraganaToRomaji
    {
        readonly Dictionary<string, string> _dic = new Dictionary<string, string>
{
    // Voyelles
    { "あ", "a" }, { "い", "i" }, { "う", "u" }, { "え", "e" }, { "お", "o" },

    // K
    { "か", "ka" }, { "き", "ki" }, { "く", "ku" }, { "け", "ke" }, { "こ", "ko" },

    // S
    { "さ", "sa" }, { "し", "shi" }, { "す", "su" }, { "せ", "se" }, { "そ", "so" },

    // T
    { "た", "ta" }, { "ち", "chi" }, { "つ", "tsu" }, { "て", "te" }, { "と", "to" },

    // N
    { "な", "na" }, { "に", "ni" }, { "ぬ", "nu" }, { "ね", "ne" }, { "の", "no" },

    // H
    { "は", "ha" }, { "ひ", "hi" }, { "ふ", "fu" }, { "へ", "he" }, { "ほ", "ho" },

    // M
    { "ま", "ma" }, { "み", "mi" }, { "む", "mu" }, { "め", "me" }, { "も", "mo" },

    // Y
    { "や", "ya" }, { "ゆ", "yu" }, { "よ", "yo" },

    // R
    { "ら", "ra" }, { "り", "ri" }, { "る", "ru" }, { "れ", "re" }, { "ろ", "ro" },

    // W + N
    { "わ", "wa" }, { "を", "wo" }, { "ん", "n" }
};
        public Dictionary<string, string> GetDic
        {
            get
            {
                return _dic;
            }
        }
    }
}
