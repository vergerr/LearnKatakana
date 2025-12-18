using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Domain
{
    internal static class katakanaToRomaji
    {
        static readonly Dictionary<string, string> _dic = new Dictionary<string, string>
{
    // Voyelles
    { "ア", "a" }, { "イ", "i" }, { "ウ", "u" }, { "エ", "e" }, { "オ", "o" },

    // K
    { "カ", "ka" }, { "キ", "ki" }, { "ク", "ku" }, { "ケ", "ke" }, { "コ", "ko" },

    // S
    { "サ", "sa" }, { "シ", "shi" }, { "ス", "su" }, { "セ", "se" }, { "ソ", "so" },

    // T
    { "タ", "ta" }, { "チ", "chi" }, { "ツ", "tsu" }, { "テ", "te" }, { "ト", "to" },

    // N
    { "ナ", "na" }, { "ニ", "ni" }, { "ヌ", "nu" }, { "ネ", "ne" }, { "ノ", "no" },

    // H
    { "ハ", "ha" }, { "ヒ", "hi" }, { "フ", "fu" }, { "ヘ", "he" }, { "ホ", "ho" },

    // M
    { "マ", "ma" }, { "ミ", "mi" }, { "ム", "mu" }, { "メ", "me" }, { "モ", "mo" },

    // Y
    { "ヤ", "ya" }, { "ユ", "yu" }, { "ヨ", "yo" },

    // R
    { "ラ", "ra" }, { "リ", "ri" }, { "ル", "ru" }, { "レ", "re" }, { "ロ", "ro" },

    // W + N
    { "ワ", "wa" }, { "ヲ", "wo" }, { "ン", "n" }
};
        public static Dictionary<string, string> GetDic
        {
            get
            {
                return _dic;
            }
        }
    }
}
