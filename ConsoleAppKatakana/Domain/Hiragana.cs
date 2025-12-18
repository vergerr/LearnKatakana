using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Domain
{
    internal static class HiraganaToRomaji
{
        static readonly List<KeyValuePair<string, string>> _dic = new List<KeyValuePair<string, string>>
{
    new("あ", "a"),
    new("い", "i"),
    new("う", "u"),
    new("え", "e"),
    new("お", "o"),

    new("か", "ka"),
    new("き", "ki"),
    new("く", "ku"),
    new("け", "ke"),
    new("こ", "ko"),

    new("さ", "sa"),
    new("し", "shi"),
    new("す", "su"),
    new("せ", "se"),
    new("そ", "so"),

    new("た", "ta"),
    new("ち", "chi"),
    new("つ", "tsu"),
    new("て", "te"),
    new("と", "to"),

    new("な", "na"),
    new("に", "ni"),
    new("ぬ", "nu"),
    new("ね", "ne"),
    new("の", "no"),

    new("は", "ha"),
    new("ひ", "hi"),
    new("ふ", "fu"),
    new("へ", "he"),
    new("ほ", "ho"),

    new("ま", "ma"),
    new("み", "mi"),
    new("む", "mu"),
    new("め", "me"),
    new("も", "mo"),

    new("や", "ya"),
    new("ゆ", "yu"),
    new("よ", "yo"),

    new("ら", "ra"),
    new("り", "ri"),
    new("る", "ru"),
    new("れ", "re"),
    new("ろ", "ro"),

    new("わ", "wa"),
    new("を", "wo"),
    new("ん", "n")
};
        public static List<KeyValuePair<string, string>> Dic
        {
            get => _dic;
        }
    }
}