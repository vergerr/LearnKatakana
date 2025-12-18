using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppKatakana.Domain
{
    internal static class katakanaToRomaji
{
        static readonly List<KeyValuePair<string, string>> _dic = new List<KeyValuePair<string, string>>
{
    new ("ア", "a"),
    new ("イ", "i"),
    new ("ウ", "u"),
    new ("エ", "e"),
    new ("オ", "o"),

    new ("カ", "ka"),
    new ("キ", "ki"),
    new ("ク", "ku"),
    new ("ケ", "ke"),
    new ("コ", "ko"),

    new ("サ", "sa"),
    new ("シ", "shi"),
    new ("ス", "su"),
    new ("セ", "se"),
    new ("ソ", "so"),

    new ("タ", "ta"),
    new ("チ", "chi"),
    new ("ツ", "tsu"),
    new ("テ", "te"),
    new ("ト", "to"),

    new ("ナ", "na"),
    new ("ニ", "ni"),
    new ("ヌ", "nu"),
    new ("ネ", "ne"),
    new ("ノ", "no"),

    new ("ハ", "ha"),
    new ("ヒ", "hi"),
    new ("フ", "fu"),
    new ("ヘ", "he"),
    new ("ホ", "ho"),

    new ("マ", "ma"),
    new ("ミ", "mi"),
    new ("ム", "mu"),
    new ("メ", "me"),
    new ("モ", "mo"),

    new ("ヤ", "ya"),
    new ("ユ", "yu"),
    new ("ヨ", "yo"),

    new ("ラ", "ra"),
    new ("リ", "ri"),
    new ("ル", "ru"),
    new ("レ", "re"),
    new ("ロ", "ro"),

    new ("ワ", "wa"),
    new ("ヲ", "wo"),
    new ("ン", "n")
};
        public static List<KeyValuePair<string, string>> Dic
        {
            get => _dic;
        }
    }
}

