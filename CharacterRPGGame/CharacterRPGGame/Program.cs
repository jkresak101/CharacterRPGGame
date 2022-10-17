using CharacterRPGGame;
using System.Diagnostics.CodeAnalysis;


//Random rd = new Random();

//int rand_num = rd.Next(1, 150);


Console.WriteLine(" Beyond This Door...\n Comes An Adventure...\n Not For The Weak...\n Are You Up For This Dangerous Task?");
Console.WriteLine(" Type Your Answer");
var input = Console.ReadLine();

if (input == "Yes")
{
    var character = new Character();
    var equipment = new Equipment();
    character.SetName();
   

    var isRunning = true;
    while (isRunning)
    {
        //List Game Options in a Console Menu
        Console.WriteLine("Grab What You Need, Make Sure To Train Before Leaving...");
        Console.WriteLine("1. Look At Your Stats & Inventory\n" +
            "2. Sword Training\n" +
            "3. Meditation\n" +
            "4. Learn Incantation & Spells\n" +
            "5. Visit A Local BlackSmith");
        Console.WriteLine("6. Raise Your Level \n" +
            "7. Quest List\n" +
            "8. Attempt Your Adventure\n" +
            "9. Lore and Information\n" +
            "10. Exit Game\n");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                character.CharacterStatus();


                break;
            case "2":

                break;
            case "3":
                Console.Clear();

                break;
            case "4":
                Console.Clear();

                break;
            case "5":
                Console.Clear();

                break;
            case "6":
                Console.Clear();

                break;
            case "7":
                Console.Clear();


                break;
            case "8":
                Console.Clear();

                break;
            case "9":
                Console.Clear();

                break;
            case "10":
                Console.Clear();
                isRunning = false;
                break;
            default:
                continue;
        }
    }
}

else
{
    Console.WriteLine("I Knew You Weren't A True Adventuerer...");
}