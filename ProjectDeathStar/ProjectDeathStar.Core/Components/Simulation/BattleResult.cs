using ProjectDeathStar.Core.Models.Battles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Components.Simulation
{
    public class BattleResult
    {
        public List<BattleRound> Rounds { get; private set; }
        public BattleStatus Status { get; set; }

        public BattleResult()
        {
            Rounds = new List<BattleRound>();
        }

        public void AddRound(BattleFormation offensiveFormation, BattleFormation defensiveFormation)
        {
            Rounds.Add(new BattleRound((uint)Rounds.Count + 1, offensiveFormation, defensiveFormation));
        }
    }
}
