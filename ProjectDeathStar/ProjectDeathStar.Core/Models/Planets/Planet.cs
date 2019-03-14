using ProjectDeathStar.Core.Models.Battles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectDeathStar.Core.Models.Planets
{

    public class Planet
    {
        private ICollection<KeyValuePair<bool, BattleFormation>> _Formations;
        public string Name { get; private set; }
        public uint CivilProduction { get; private set; }
        public uint MilitaryProduction { get; private set; }
        public uint Defense { get; private set; }
        public uint Offense { get; private set; }


        public Planet(Planets p)
        {
            switch (p)
            {
                case Planets.Pandora:
                    Name = p.ToString();
                    CivilProduction = 20;
                    MilitaryProduction = 10;
                    Offense = 1;
                    Defense = 2;
                    break;
                case Planets.Desert:
                    Name = p.ToString();
                    CivilProduction = 2;
                    MilitaryProduction = 5;
                    Offense = 5;
                    Defense = 10;
                    break;
                case Planets.Lava:
                    Name = p.ToString();
                    CivilProduction = 10;
                    MilitaryProduction = 20;
                    Offense = 1;
                    Defense = 2;
                    break;
                case Planets.Oceanic:
                    Name = p.ToString();
                    CivilProduction = 5;
                    MilitaryProduction = 10;
                    Offense = 1;
                    Defense = 15;
                    break;
            }
            _Formations = new List<KeyValuePair<bool, BattleFormation>>();
        }

        public void ActivateFormation(BattleFormation battleFormation, BattleFormationType battleFormationType)
        {
            if (battleFormation is null)
                throw new ArgumentNullException(nameof(BattleFormation));
            if (battleFormation.GeneralInCharge == null)
            {
                var article = battleFormationType == BattleFormationType.Offensive ? "an" : "a";
                throw new InvalidOperationException($"A general must be assigned in charge of {battleFormation.Name} formation in your '{Name}' planet to activate it as {article} {battleFormationType.ToString().ToLower()} formation");
            }
            var formation = _Formations.SingleOrDefault(f => f.Value.Equals(battleFormation));
            if (formation.Equals(default(KeyValuePair<bool, BattleFormation>)) || formation.Value == null)
                throw new ArgumentException("invalid formation");
            if (formation.Value.Type != battleFormationType)
                throw new InvalidOperationException("invalid formation type selected");
            formation = new KeyValuePair<bool, BattleFormation>(true, battleFormation);
        }
        

        public void AddFormation(BattleFormation battleFormation)
        {
            if (battleFormation is null)
                throw new ArgumentNullException(nameof(BattleFormation));
            _Formations?.Add(new KeyValuePair<bool, BattleFormation>(false, battleFormation));
        }

        public void RemoveFormation(BattleFormation battleFormation)
        {
            if (battleFormation is null)
                throw new ArgumentNullException(nameof(BattleFormation));

            var formations = _Formations.Where(f => f.Value.Equals(battleFormation)).Select(f => f.Value).ToList();
            if (formations != null && formations.Count > 0)
                formations.Remove(battleFormation);
        }

        public bool ExistsFormation(BattleFormation battleFormation)
        {
            if (battleFormation is null)
                throw new ArgumentNullException(nameof(BattleFormation));
            return _Formations?.SingleOrDefault(f => f.Value.Equals(battleFormation)) != null;
        }

        public IEnumerable<BattleFormation> GetActiveFormations()
        {
            return _Formations.Where(f => f.Key).Select(f => f.Value);
        }

        public void UpdateFormation(BattleFormation battleFormation, BattleFormation newFormation)
        {
            if (battleFormation is null)
                throw new ArgumentNullException(nameof(battleFormation), "Invalid source formation");
            if (newFormation is null)
                throw new ArgumentNullException(nameof(battleFormation), "Invalid new formation");
            var existingFormation = _Formations?.SingleOrDefault(f => f.Value.Equals(battleFormation)).Value;

            if (existingFormation != null)
                existingFormation = newFormation;

        }
    }
}
