namespace DeathStar.Core.Models
{
    public enum DefensiveModules
    {
        ShieldAmplifier,
        ArmorPlate,
        HullPlate

    }

    public class DefensiveEquipments
        : EquipmentBase
    {
        public string Name { get; private set; }
        public DefensiveEquipmentGrades Size { get; private set; }
        public uint Bonus { get; private set; }


        public DefensiveEquipments(DefensiveModules defensiveModules, DefensiveEquipmentGrades defensiveWeaponGrades)
        {
            Name = defensiveModules.ToString();
            Size = defensiveWeaponGrades;
            if (defensiveModules == DefensiveModules.ShieldAmplifier)
            {
                switch (Size)
                {
                    case DefensiveEquipmentGrades.Medium:
                        Bonus = 20;
                        break;
                    case DefensiveEquipmentGrades.Large:
                        Bonus = 50;
                        break;
                    case DefensiveEquipmentGrades.XLarge:
                        Bonus = 100;
                        break;
                    case DefensiveEquipmentGrades.XXLagre:
                        Bonus = 500;
                        break;
                    case DefensiveEquipmentGrades.Doomsday:
                        Bonus = 500;
                        break;
                    case DefensiveEquipmentGrades.Small:

                    default:
                        Bonus = 5;
                        break;
                }
            }
            else if (defensiveModules == DefensiveModules.HullPlate)
            {
                switch (Size)
                {
                    case DefensiveEquipmentGrades.Medium:
                        Bonus = 20;
                        break;
                    case DefensiveEquipmentGrades.Large:
                        Bonus = 50;
                        break;
                    case DefensiveEquipmentGrades.XLarge:
                        Bonus = 100;
                        break;
                    case DefensiveEquipmentGrades.XXLagre:
                        Bonus = 500;
                        break;
                    case DefensiveEquipmentGrades.Doomsday:
                        Bonus = 500;
                        break;
                    case DefensiveEquipmentGrades.Small:

                    default:
                        Bonus = 10;
                        break;
                }

            }
        }
    }
}
