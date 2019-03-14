using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Frigate : Ship
    {
        
        internal Frigate(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        
        //public static Frigate CreateFrigate(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Heron":
        //            return new Frigate(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Slicer":
        //            return new Frigate(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Punisher":
        //            return new Frigate(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Vengeance":
        //            return new Frigate(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Rifter":
        //            return new Frigate(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
