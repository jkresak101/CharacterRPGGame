using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRPGGame
{
    internal class Character : Equipment
    {
        public string CharacterName { get; set; }
        public string AvClass { get; set; }
        public string Ware { get; set; }
        public int Level { get; set; }
        public int Magicka { get; set; }
        public int Health { get; set; }
        public int CharacterStrength { get; set; }
        public int DamageTaken { get; set; }



      
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
            Console.WriteLine($"Name: {CharacterName}\nClass: {AvClass}\nWare: {Ware}\nLevel: {Level}\nMagicka: {Magicka}\nHealth: {Health}\nStrength: {CharacterStrength}\nCurrent Equipment {EquipmentType} {EquipmentMake} {EquipmentName}");
            Console.WriteLine("\nPress Any Key To Return To Your Adventure.");
            Console.ReadKey();
            Console.Clear();
        }




    }
   
}
