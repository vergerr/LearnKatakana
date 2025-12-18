using ConsoleAppKatakana;
using ConsoleAppKatakana.Domain;
using ConsoleAppKatakana.Interface;
using System.Text;


IAsk guess = new AskKatakanaRomaji(new ConsoleAppTP20251210.EditConsole());
ValidCommandUser commandUser = new ValidCommandUser();

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

while (!commandUser.IsCommandAlphabetCorrect)
{
    Console.WriteLine("Hello my friend ! Whish alphabet do you want ?");
    ShowAlphabet();
    commandUser.CommandAlphabet = Console.ReadLine();
}

Console.WriteLine("Perfect ! Whish mode do you want ?");
ShowCommand(commandUser.NameAlphabet);
commandUser.CommandMode = Console.ReadLine();

while (!commandUser.CommandMode.Equals("EXIT"))
{
    switch (commandUser.CommandMode)
    {
        case "R": guess.GuessRomaji(commandUser.DictionaryAlphabet);break;
        case "J": guess.GuessJapanAlphabet(commandUser.DictionaryAlphabet); break;
        case "S": guess.Study(commandUser.DictionaryAlphabet); break;
        default:
            Console.WriteLine("What ? Remember : ");
            ShowCommand(commandUser.NameAlphabet);
            commandUser.CommandMode = Console.ReadLine();
            break;
    }
    Console.WriteLine("What's next ?");
    ShowCommand(commandUser.NameAlphabet);
    commandUser.CommandMode = Console.ReadLine();
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




        

