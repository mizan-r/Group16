using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class BattleCruiser : Ship
    {
        
        
        internal BattleCruiser(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {

        }

        //public static BattleCruiser CreateBattleCruiser(string shipName)
        //{
        //    switch (shipName)
        //    {
        //        case "Ferox":
        //            return new BattleCruiser(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
        //        case "Drake":
        //            return new BattleCruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Naga":
        //            return new BattleCruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Nihgthawk":
        //            return new BattleCruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Vulture":
        //            return new BattleCruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Oracle":
        //            return new BattleCruiser(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }

        //}
    }
}
