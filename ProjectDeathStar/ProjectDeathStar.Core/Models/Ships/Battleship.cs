using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Ships
{
    public class Battleship : Ship
    {

        internal Battleship(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
            :base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
        {
            

            
        }

        

        //public static Battleship CreateBattleShip(string shipName)
        //{
        //    switch(shipName)
        //    {
        //        case "Raven":
        //            return new Battleship(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5 );
        //        case "Dominix":
        //            return new Battleship(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Scorpion":
        //            return new Battleship(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Widow":
        //            return new Battleship(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        case "Rokh":
        //            return new Battleship(shipName, "", 1000, 2000, 1000, 3, 7, 7, 5);
        //        default:
        //            return null;
        //    }   
        //}

    }
}
