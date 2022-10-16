using CharacterRPGGame;
using System.Diagnostics.CodeAnalysis;


Random rd = new Random();

int rand_num = rd.Next(1, 150);


Console.WriteLine(" Beyond This Door...\n Comes An Adventure...\n Not For The Weak...\n Are You Up For This Dangerous Task?");
Console.WriteLine(" Type Your Answer");
var input = Console.ReadLine();

if (input == "Yes")
{
    var character = new Character();
    


    Console.Clear();
    Console.WriteLine("Welcome Adventueer... I Am The Voice Known As Ether...No Body...No Existance...Just A Mind.\nWhat Do They Call You?");
    Console.ReadLine();
    Console.WriteLine("Greetings " + );
    Console.WriteLine("\nPress any key to go to the main menu.");
    Console.ReadKey();
    Console.Clear();
}

else
{
    Console.WriteLine("I Knew You Weren't A True Adventuerer...");
}