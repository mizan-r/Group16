using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Carrier : Ship
    {
        
        
        internal Carrier(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        
        //public static Carrier CreateCarrier(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Hel":
        //            return new Carrier(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Loggerhead":
        //            return new Carrier(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Revenant":
        //            return new Carrier(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
