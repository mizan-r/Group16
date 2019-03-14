using ProjectDeathStar.Core.Models.Ships;
using System;

namespace ProjectDeathStar.Core.Models.Battles
{
    public class FormationRow
    {
        public Ship SelectedShip { get; private set; }
        public uint ShipAmount { get; private set; }

        public FormationRow(Ship selectedShip, uint shipAmount)
        {
            throw new NotImplementedException();
        }
    }
}
