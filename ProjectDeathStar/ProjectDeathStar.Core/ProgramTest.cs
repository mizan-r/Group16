using ProjectDeathStar.Core.Components.Simulation;
using ProjectDeathStar.Core.Models.Battles;
using ProjectDeathStar.Core.Models.Equipments.Weapons;
using ProjectDeathStar.Core.Models.Planets;
using ProjectDeathStar.Core.Models.Ships;

namespace ProjectDeathStar.Core
{
    class ProgramTest
    {
        public static void Main(string[] args)
        {
            //var battleship = Battleship.CreateBattleShip("Raven");

            ShipFactory<Battleship> factory = new ShipFactory<Battleship>();

            var raven = factory.CreateShip(BattleShips.Raven);
            var dominix = factory.CreateShip(BattleShips.Dominix);
            var rokh = factory.CreateShip(BattleShips.Rokh);
            var scorpion = factory.CreateShip(BattleShips.Scorpion);

            var canon = Weapon.CreateWeapon("Cannon", WeaponType.Large);
            var projectile = Weapon.CreateWeapon("Projectile", WeaponType.Large);
            var laser = Weapon.CreateWeapon("Laser", WeaponType.Large);
            var missile = Weapon.CreateWeapon("Missile", WeaponType.Large);

            raven.InstallWeapon(canon, 1);
            dominix.InstallWeapon(projectile, 1);
            rokh.InstallWeapon(laser, 1);
            scorpion.InstallWeapon(missile, 1);

            var attackingPlanetOffensiveFormation = new BattleFormation("ap of");
            var attackingPlanetDefensiveFormation = new BattleFormation("ap df");
            var defensivePlanetOffensiveFormation = new BattleFormation("dp of");
            var defensivePlanetDefensiveFormation = new BattleFormation("dp df");

            attackingPlanetOffensiveFormation.SetFormationRow(raven, 100, 1);
            attackingPlanetDefensiveFormation.SetFormationRow(dominix, 100, 1);
            defensivePlanetOffensiveFormation.SetFormationRow(raven, 100, 1);
            defensivePlanetDefensiveFormation.SetFormationRow(raven, 100, 1);

            attackingPlanetOffensiveFormation.SetFormationType(BattleFormationType.Offensive);
            attackingPlanetDefensiveFormation.SetFormationType(BattleFormationType.Defensive);
            defensivePlanetDefensiveFormation.SetFormationType(BattleFormationType.Defensive);
            defensivePlanetOffensiveFormation.SetFormationType(BattleFormationType.Offensive);

            General attackingPlanetOffensiveFormationGeneral = new General();
            General attackingPlanetDefensiveFormationGeneral = new General();
            General defensivePlanetOffensiveFormationGeneral = new General();
            General defensivePlanetDefensiveFormationGeneral = new General();

            attackingPlanetOffensiveFormation.SetGeneral(attackingPlanetOffensiveFormationGeneral);
            attackingPlanetDefensiveFormation.SetGeneral(attackingPlanetDefensiveFormationGeneral);
            defensivePlanetDefensiveFormation.SetGeneral(defensivePlanetDefensiveFormationGeneral);
            defensivePlanetOffensiveFormation.SetGeneral(defensivePlanetOffensiveFormationGeneral);

            var attackingPlanet = new Planet(Planets.Pandora);
            var defensivePlanet = new Planet(Planets.Desert);

            attackingPlanet.AddFormation(attackingPlanetOffensiveFormation);
            attackingPlanet.AddFormation(attackingPlanetDefensiveFormation);
            defensivePlanet.AddFormation(defensivePlanetOffensiveFormation);
            defensivePlanet.AddFormation(defensivePlanetDefensiveFormation);

            attackingPlanet.ActivateFormation(attackingPlanetOffensiveFormation, BattleFormationType.Offensive);
            attackingPlanet.ActivateFormation(attackingPlanetDefensiveFormation, BattleFormationType.Defensive);
            defensivePlanet.ActivateFormation(defensivePlanetOffensiveFormation, BattleFormationType.Offensive);
            defensivePlanet.ActivateFormation(defensivePlanetDefensiveFormation, BattleFormationType.Defensive);

            BattleSimulator.CalculateBattleResult(attackingPlanet, defensivePlanet);
        }
    }
}
