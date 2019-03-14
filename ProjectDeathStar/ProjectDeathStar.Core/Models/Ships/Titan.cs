using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Titan : Ship
    {
        
        internal Titan(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        //public static Titan CreateTitan(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Molok":
        //            return new Titan(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Avatar":
        //            return new Titan(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Erebus":
        //            return new Titan(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
