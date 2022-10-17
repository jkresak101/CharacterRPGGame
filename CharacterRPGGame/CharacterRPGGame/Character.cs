using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRPGGame
{
   public class Character : Equipment
    {
        public string CharacterName { get; set; }
        public string AvClass { get; set; }
        public string Ware { get; set; }
        public int Level { get; set; }
        public int Magicka { get; set; }
        public int Health { get; set; }
        public int CharacterStrength { get; set; }
        public int DamageTaken { get; set; }

        public Character()
        {
            CharacterName = "";
            AvClass = "";
            Ware = "";
            Level = 0;
            Magicka = 0;
            Health = 100;
            CharacterStrength = 0;
            DamageTaken = 0;


        }

        public Character(string name, string avclass, string ware)
        {
            CharacterName = name;
            AvClass = avclass;
            Ware = ware;
            Level = 0;
            Magicka = 0;
            Health= 100;
            CharacterStrength = 0;
            DamageTaken= 0;
        }
        public void CharacterStatus()
        {
            Console.WriteLine(CharacterName + "status: ");
            Console.WriteLine($"Name: {CharacterName}\nClass: {AvClass}\nWare: {Ware}\nLevel: {Level}\nMagicka: {Magicka}\nHealth: {Health}\nStrength: {CharacterStrength}\nCurrent Equipment");
            Console.WriteLine("\nPress Any Key To Return To Your Adventure.");
            Console.ReadKey();
            Console.Clear();
        }
       
       public void SetName()
        {
            Console.Clear();
            Console.WriteLine("Welcome Adventurer... I Am The Voice Known As Ether...No Body...No Existance...Just A Mind.\nWhat Do They Call You?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Greetings " + CharacterName + "!");
            Console.WriteLine("\nPress any key to go to the main menu.");
            Console.ReadKey();
            Console.Clear();
        }

       
       

    }

}
