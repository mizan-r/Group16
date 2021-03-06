﻿using ProjectDeathStar.Core.Models.Ships;
using System;

namespace ProjectDeathStar.Core.Models.Battles
{
    public class BattleFormation
    {
        public string Name { get; private set; }
        public FormationRow[] Rows { get; private set; }
        public BattleFormationType Type { get; private set; }


        //public bool IsActive { get; private set; }

        public General GeneralInCharge { get; private set; }

        public BattleFormation(string name)
        {
            Name = name;
            Rows = new FormationRow[6];
        }

        public void SetFormationRow(Ship selectedShip, uint amountOfShips, uint rowPosition)
        {
            if (rowPosition < 6)
            {
                Rows[rowPosition] = new FormationRow(selectedShip, amountOfShips);
            }
            else
            {
                throw new Exception("Invalid Row Position");
            }
        }

        //public void ActiveteFormation(General AssignedGeneral)
        //{
        //    GeneralInCharge = AssignedGeneral;
        //    IsActive = true;
        //}

        public void SetGeneral(General general)
        {
            if (general is null)
                throw new ArgumentNullException(nameof(general));

            GeneralInCharge = general;
        }

        public void SetFormationType(BattleFormationType battleFormationType)
        {
            Type = battleFormationType;
        }
    }
}
