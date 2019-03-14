using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Dreadnaunt : Ship
    {
        
        
        internal Dreadnaunt(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }
        

        //public static Dreadnaunt CreateDreadnaunt(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Phoenix":
        //            return new Dreadnaunt(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Moros":
        //            return new Dreadnaunt(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Naglfar":
        //            return new Dreadnaunt(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Revelation":
        //            return new Dreadnaunt(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
