using ConsoleAppKatakana;
using ConsoleAppKatakana.Domain;
using ConsoleAppKatakana.Interface;
using System.Text;


IAsk guess = new AskKatakanaRomaji();
Dictionary<string, string> dic;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
string answerAlphabet = string.Empty;
string answerMode = string.Empty;

while (!answerAlphabet.Equals("H") && !answerAlphabet.Equals("K"))
{
    Console.WriteLine("Hello my friend ! Whish alphabet do you want ?");
    ShowAlphabet();
    answerAlphabet = Console.ReadLine().ToUpper();
}
dic = answerAlphabet.Equals("H") ? new HiraganaToRomaji().GetDic : new katakanaToRomaji().GetDic;
answerAlphabet = answerAlphabet.Equals("H") ? "Hiragana" : "Katakana";

Console.WriteLine("Perfect ! Whish mode do you want ?");
ShowCommand(answerAlphabet);
answerMode = Console.ReadLine().ToUpper();

while (!answerMode.Equals("EXIT"))
{
    switch (answerMode)
    {
        case "R": guess.GuessRomaji(dic);break;
        case "J": guess.GuessJapanAlphabet(dic); break;
        case "S": guess.Study(dic); break;
        default:
            Console.WriteLine("What ? Remember : ");
            ShowCommand(answerAlphabet);
            answerMode = Console.ReadLine().ToUpper();
            break;
    }
    Console.WriteLine("What's next ?");
    ShowCommand(answerAlphabet);
    answerMode = Console.ReadLine().ToUpper();
}

void ShowCommand(string alphabet)
{
    Console.WriteLine("R : guess the Romaji letter");
    Console.WriteLine($"J : guess the {alphabet} letter");
    Console.WriteLine("S : study");
    Console.WriteLine("EXIT : see you later !");
}

void ShowAlphabet()
{
    Console.WriteLine("H : Hiragana");
    Console.WriteLine("K : Katakana");
}




        

