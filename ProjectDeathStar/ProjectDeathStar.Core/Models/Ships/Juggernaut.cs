using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Juggernaut : Ship
    {
        
      
        internal Juggernaut(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        
        //public static Juggernaut CreateJuggernaut(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Aeon":
        //            return new Juggernaut(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Archon":
        //            return new Juggernaut(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Thanatos":
        //            return new Juggernaut(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Nyx":
        //            return new Juggernaut(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
