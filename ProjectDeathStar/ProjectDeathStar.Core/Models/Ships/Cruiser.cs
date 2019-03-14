using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Cruiser : Ship
    {
        
        
        internal Cruiser(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        //public static Cruiser CreateCruiser(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Thorax":
        //            return new Cruiser(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Vexor":
        //            return new Cruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Deimos":
        //            return new Cruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Caracal":
        //            return new Cruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Blackbird":
        //            return new Cruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
