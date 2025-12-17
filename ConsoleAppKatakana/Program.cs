using ConsoleAppKatakana;
using ConsoleAppKatakana.Domain;
using ConsoleAppKatakana.Interface;
using System.Text;


IAsk guess = new AskKatakanaRomaji();
katakanaToRomaji dic = new katakanaToRomaji();
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Hello my friend ! What's mode do you want ?");
ShowCommand();
string answer = Console.ReadLine().ToUpper();

while (!answer.Equals("EXIT"))
{
    switch (answer)
    {
        case "0": guess.GuessRomaji(dic.GetDic);break;
        case "1": guess.GuessKatakana(dic.GetDic); break;
        case "2": guess.Study(dic.GetDic); break;
        default:
            Console.WriteLine("What ? Remember : ");
            ShowCommand();
            answer = Console.ReadLine().ToUpper();
            break;
    }
    Console.WriteLine("What's next ?");
    ShowCommand();
    answer = Console.ReadLine().ToUpper();
}

void ShowCommand()
{
    Console.WriteLine("0 : guess the Romaji letter");
    Console.WriteLine("1 : guess the katakana letter");
    Console.WriteLine("2 : study");
    Console.WriteLine("EXIT : see you later !");
}




        

