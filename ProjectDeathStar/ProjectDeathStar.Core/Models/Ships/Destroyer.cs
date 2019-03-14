using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Destroyer : Ship
    {
        
        
        internal Destroyer(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            :base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        
        //public static Destroyer CreateDestroyer(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Thrasher":
        //            return new Destroyer(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Sabre":
        //            return new Destroyer(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Bifrost":
        //            return new Destroyer(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Nemesis":
        //            return new Destroyer(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Incursus":
        //            return new Destroyer(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
