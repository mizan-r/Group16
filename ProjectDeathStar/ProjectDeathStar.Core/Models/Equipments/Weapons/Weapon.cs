﻿using DeathStar.Core.Models;
using System.Collections.Generic;

namespace ProjectDeathStar.Core.Models.Equipments.Weapons
{

    public enum Weapons
    {
        Cannon,
        Projectile,
        Laser,
        Missile,
        Shockwave,
        DoomsdayBeam,
        DoomsdayMissile,
        DoomsdayCannon

    }

    public class Weapon : EquipmentBase
    {

        public string Name { get; private set; }
        public uint KineticDamage { get; private set; }
        public uint ThermalDamage { get; private set; }
        public uint ExplosiveDamage { get; private set; }
        public uint ElectromagneticDamage { get; private set; }

        public WeaponGrades Grade { get; private set; }

        public Weapon(Weapons weapons, WeaponGrades weaponGrades)
        {
            Name = weapons.ToString();
            
            Grade = weaponGrades;
            switch (weapons)
            {
                case Weapons.Cannon:
                    if (weaponGrades == WeaponGrades.Small)
                    {
                        KineticDamage = 20;
                        ExplosiveDamage = 10;
                    }
                    else if (weaponGrades == WeaponGrades.Medium)
                    {
                        KineticDamage = 40;
                        ExplosiveDamage = 20;
                    }
                    else if (weaponGrades == WeaponGrades.Large)
                    {
                        KineticDamage = 100;
                        ExplosiveDamage = 50;
                    }
                    else if (weaponGrades == WeaponGrades.XLarge)
                    {
                        KineticDamage = 200;
                        ExplosiveDamage = 100;
                    }
                    else if (weaponGrades == WeaponGrades.XXLagre)
                    {
                        KineticDamage = 1000;
                        ExplosiveDamage = 500;
                    }
                    break;
                case Weapons.Projectile:
                    if (weaponGrades == WeaponGrades.Small)
                    {
                        KineticDamage = 10;
                        ThermalDamage = 10;
                        ExplosiveDamage = 10;
                    }
                    else if (weaponGrades == WeaponGrades.Medium)
                    {
                        KineticDamage = 20;
                        ThermalDamage = 20;
                        ExplosiveDamage = 20;
                    }
                    else if (weaponGrades == WeaponGrades.Large)
                    {
                        KineticDamage = 50;
                        ThermalDamage = 50;
                        ExplosiveDamage = 50;
                    }
                    else if (weaponGrades == WeaponGrades.XLarge)
                    {
                        KineticDamage = 100;
                        ThermalDamage = 100;
                        ExplosiveDamage = 100;
                    }
                    else if (weaponGrades == WeaponGrades.XXLagre)
                    {
                        KineticDamage = 500;
                        ThermalDamage = 500;
                        ExplosiveDamage = 500;
                    }
                    break;
                case Weapons.Laser:
                    if (weaponGrades == WeaponGrades.Small)
                    {
                        ElectromagneticDamage = 10;
                        ThermalDamage = 20;
                    }
                    else if (weaponGrades == WeaponGrades.Medium)
                    {
                        ElectromagneticDamage = 20;
                        ThermalDamage = 40;
                    }
                    else if (weaponGrades == WeaponGrades.Large)
                    {
                        ElectromagneticDamage = 50;
                        ThermalDamage = 100;
                    }
                    else if (weaponGrades == WeaponGrades.XLarge)
                    {
                        ElectromagneticDamage = 100;
                        ThermalDamage = 200;
                    }
                    else if (weaponGrades == WeaponGrades.XXLagre)
                    {
                        ElectromagneticDamage = 500;
                        ThermalDamage = 1000;
                    }
                    break;
                case Weapons.Missile:
                    if (weaponGrades == WeaponGrades.Small)
                    {
                        ExplosiveDamage = 20;
                        ThermalDamage = 10;
                    }
                    else if (weaponGrades == WeaponGrades.Medium)
                    {
                        ExplosiveDamage = 40;
                        ThermalDamage = 20;
                    }
                    else if (weaponGrades == WeaponGrades.Large)
                    {
                        ExplosiveDamage = 100;
                        ThermalDamage = 50;
                    }
                    else if (weaponGrades == WeaponGrades.XLarge)
                    {
                        ExplosiveDamage = 200;
                        ThermalDamage = 100;
                    }
                    else if (weaponGrades == WeaponGrades.XXLagre)
                    {
                        ExplosiveDamage = 1000;
                        ThermalDamage = 500;
                    }
                    break;
                case Weapons.Shockwave:
                    if (weaponGrades == WeaponGrades.Small)
                    {
                        ElectromagneticDamage = 30;
                    }
                    else if (weaponGrades == WeaponGrades.Medium)
                    {
                        ElectromagneticDamage = 60;
                    }
                    else if (weaponGrades == WeaponGrades.Large)
                    {
                        ElectromagneticDamage = 150;
                    }
                    else if (weaponGrades == WeaponGrades.XLarge)
                    {
                        ElectromagneticDamage = 300;
                    }
                    else if (weaponGrades == WeaponGrades.XXLagre)
                    {
                        ElectromagneticDamage = 1500;
                    }
                    break;
                case Weapons.DoomsdayBeam:
                    ElectromagneticDamage = 3000;
                    break;
                case Weapons.DoomsdayMissile:
                    ExplosiveDamage = 20000;
                    ThermalDamage = 10000;
                    break;
                case Weapons.DoomsdayCannon:
                    ExplosiveDamage = 10000;
                    ThermalDamage = 10000;
                    KineticDamage = 10000;
                    break;
            }
        }
        
    }
}
