using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRPGGame
{
    public class Equipment
    {
        public string? EquipmentType { get; set; }
        public string? EquipmentName { get; set; }
        public string? EquipmentMake { get; set; }
        public int Strength { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }

        
        public Equipment()
        {
            EquipmentType = "EquipmentType";
            EquipmentName = "EquipmentName";
            EquipmentMake = "EquipmentMake";
            


        }
       






    }
}
