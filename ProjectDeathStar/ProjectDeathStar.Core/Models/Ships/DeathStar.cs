using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class DeathStar : Ship
    {
        

        internal DeathStar(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        
        //public static DeathStar CreateDeathStar(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Astero":
        //            return new DeathStar(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Dramiel":
        //            return new DeathStar(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Machariel":
        //            return new DeathStar(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
