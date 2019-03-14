using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class SuperTitan : Ship
    {
        
        internal SuperTitan(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        
        //public static SuperTitan CreateSuperTitan(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Leviathan":
        //            return new SuperTitan(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Komodo":
        //            return new SuperTitan(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Cynabal":
        //            return new SuperTitan(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
