using ConsoleAppKatakana;
using ConsoleAppKatakana.Domain;
using ConsoleAppKatakana.Interface;
using System.Text;


IAsk askService = new AskService(new ConsoleAppTP20251210.EditConsole());
ValidCommandUser commandUser = new ValidCommandUser(askService);

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

while (!commandUser.IsCommandAlphabetCorrect)
{
    Console.WriteLine("Hello my friend ! Whish alphabet do you want ?");
    ShowAlphabet();
    commandUser.CommandAlphabet = Console.ReadLine();
}

Console.WriteLine("Perfect ! Whish mode do you want ?");

while (!commandUser.CommandMode.Equals("EXIT"))
{
    do
    {
        ShowCommand(commandUser.NameAlphabet);
        commandUser.CommandMode = Console.ReadLine();
    }
    while (!commandUser.IsCommandModeCorrect);

    commandUser.CallAskService();
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
    foreach (KeyValuePair<string, string> kvp in Command._commandAlphabetAccept)
    {
        Console.WriteLine($"{kvp.Key} : {kvp.Value}");
    }
}






