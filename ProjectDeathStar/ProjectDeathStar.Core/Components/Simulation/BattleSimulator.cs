using ProjectDeathStar.Core.Models.Battles;
using ProjectDeathStar.Core.Models.Planets;
using System.Linq;

namespace ProjectDeathStar.Core.Components.Simulation
{
    public class BattleSimulator
    {
        public static BattleResult CalculateBattleResult(Planet offensivePlanet, Planet defensivePlanet)
        {
            var luckForOffensive = GenerateLuck();
            var luckForDefensive = GenerateLuck();

            var planetActiveFormations = offensivePlanet.GetActiveFormations();
            for (int i = 0; i < 6; i++)
            {

                uint armor = planetActiveFormations.SingleOrDefault(f => f.Type == BattleFormationType.Offensive).Rows[i].SelectedShip.Armor;
                var x = armor * planetActiveFormations.SingleOrDefault(f => f.Type == BattleFormationType.Defensive).Rows[i].ShipAmount;
            }

            var result = new BattleResult();
            //result.AddRound();

            return result;
        }

        public static int GenerateLuck()
        {
            return 5;
        }
    }
}
