using DeathStar.Core.Models;
using ProjectDeathStar.Core.Models.Equipments.Weapons;
using System;
using System.Collections.Generic;

namespace ProjectDeathStar.Core.Models.Ships
{
    public abstract class Ship
    {
        public string Name { get; protected set; }
        public string PictureUrl { get; protected set; }
        public uint ShieldStrength { get; protected set; }
        public uint ArmorStrength { get; protected set; }
        public uint HullStrength { get; protected set; }
        public uint Range { get; protected set; }

        //public Weapon[] WeaponSlots { get; protected set; }
        //public EngineeringModule[] EngineeringSlots { get; protected set; }
        //public DefenceModule[] DefenceModuleSlots { get; protected set; }

        public IList<Slot> EquipmentSlots { get; private set; }


        protected Ship(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenseSlot)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ShieldStrength = shield;
            ArmorStrength = armor;
            HullStrength = hull;
            Range = range;

            EquipmentSlots = new List<Slot>
            {
                new WeaponSlot(weaponSlot),
                new EngineeringSlot(engineeringSlot),
                new DefensiveSlot(defenseSlot)
            };
        }

        public void InstallEquipment(EquipmentBase equipment, int slot)
        {
            if (equipment is Weapon weapon)
            {
                if (slot >= 0 && slot < EquipmentSlots[0].Equipments.Count)
                {
                    if (this is Shuttle || this is Corvette || this is Frigate)
                    {
                        if (weapon.Grade == WeaponGrades.Small)
                        {

                            if (EquipmentSlots[0].Equipments.Count == 0)
                                EquipmentSlots[0].Equipments.Add(weapon);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = weapon;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a small '{weapon.Name}' weapon in '{Name}' ship");
                    }
                    else if (this is Destroyer || this is Cruiser || this is BattleCruiser)
                    {
                        if (weapon.Grade == WeaponGrades.Medium)
                        {

                            if (EquipmentSlots[0].Equipments.Count == 0)
                                EquipmentSlots[0].Equipments.Add(weapon);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = weapon;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a medium '{weapon.Name}' weapon in '{Name}' ship");
                    }
                    else if (this is Battleship || this is Dreadnaunt || this is Juggernaut)
                    {
                        if (weapon.Grade == WeaponGrades.Large)
                        {

                            if (EquipmentSlots[0].Equipments.Count == 0)
                                EquipmentSlots[0].Equipments.Add(weapon);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = weapon;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a large '{weapon.Name}' weapon in '{Name}' ship");
                    }
                    else if (this is Carrier || this is SuperCarrier)
                    {
                        if (weapon.Grade == WeaponGrades.XLarge)
                        {

                            if (EquipmentSlots[0].Equipments.Count == 0)
                                EquipmentSlots[0].Equipments.Add(weapon);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = weapon;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a xlarge '{weapon.Name}' weapon in '{Name}' ship");
                    }
                    else if (this is Titan || this is SuperTitan)
                    {
                        if (weapon.Grade == WeaponGrades.XXLagre)
                        {

                            if (EquipmentSlots[0].Equipments.Count == 0)
                                EquipmentSlots[0].Equipments.Add(weapon);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = weapon;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a xxlarge '{weapon.Name}' weapon in '{Name}' ship");
                    }
                    else if (this is DeathStar)
                    {
                        if (weapon.Grade == WeaponGrades.Doomsday)
                        {

                            if (EquipmentSlots[0].Equipments.Count == 0)
                                EquipmentSlots[0].Equipments.Add(weapon);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = weapon;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a doomsday '{weapon.Name}' weapon in '{Name}' ship");
                    }
                    else
                        throw new InvalidOperationException("Unknown ship");
                }
                else
                    throw new Exception("Invalid Slot");
            }

            if (equipment is DefensiveEquipments defensiveEquipment)
            {
                if (slot >= 0 && slot < EquipmentSlots[2].Equipments.Count)
                {
                    if (this is Shuttle || this is Corvette || this is Frigate)
                    {
                        if (defensiveEquipment.Size == DefensiveEquipmentGrades.Small)
                        {

                            if (EquipmentSlots[2].Equipments.Count == 0)
                                EquipmentSlots[2].Equipments.Add(defensiveEquipment);
                            else
                                EquipmentSlots[2].Equipments[slot - 1] = defensiveEquipment;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a small '{defensiveEquipment.Name}' defensive equipment in '{Name}' ship");
                    }
                    else if (this is Destroyer || this is Cruiser || this is BattleCruiser)
                    {
                        if (defensiveEquipment.Size == DefensiveEquipmentGrades.Medium)
                        {

                            if (EquipmentSlots[2].Equipments.Count == 0)
                                EquipmentSlots[2].Equipments.Add(defensiveEquipment);
                            else
                                EquipmentSlots[2].Equipments[slot - 1] = defensiveEquipment;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a medium '{defensiveEquipment.Name}' defensive equipment in '{Name}' ship");
                    }
                    else if (this is Battleship || this is Dreadnaunt || this is Juggernaut)
                    {
                        if (defensiveEquipment.Size == DefensiveEquipmentGrades.Large)
                        {

                            if (EquipmentSlots[2].Equipments.Count == 0)
                                EquipmentSlots[2].Equipments.Add(defensiveEquipment);
                            else
                                EquipmentSlots[2].Equipments[slot - 1] = defensiveEquipment;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a large '{defensiveEquipment.Name}' defensive equipment in '{Name}' ship");
                    }
                    else if (this is Carrier || this is SuperCarrier)
                    {
                        if (defensiveEquipment.Size == DefensiveEquipmentGrades.XLarge)
                        {

                            if (EquipmentSlots[2].Equipments.Count == 0)
                                EquipmentSlots[2].Equipments.Add(defensiveEquipment);
                            else
                                EquipmentSlots[2].Equipments[slot - 1] = defensiveEquipment;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a xlarge '{defensiveEquipment.Name}' defensive equipment in '{Name}' ship");
                    }
                    else if (this is Titan || this is SuperTitan)
                    {
                        if (defensiveEquipment.Size == DefensiveEquipmentGrades.XXLagre)
                        {

                            if (EquipmentSlots[2].Equipments.Count == 0)
                                EquipmentSlots[2].Equipments.Add(defensiveEquipment);
                            else
                                EquipmentSlots[0].Equipments[slot - 1] = defensiveEquipment;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a xxlarge '{defensiveEquipment.Name}' defensive equipment in '{Name}' ship");
                    }
                    else if (this is DeathStar)
                    {
                        if (defensiveEquipment.Size == DefensiveEquipmentGrades.Doomsday)
                        {

                            if (EquipmentSlots[2].Equipments.Count == 0)
                                EquipmentSlots[2].Equipments.Add(defensiveEquipment);
                            else
                                EquipmentSlots[2].Equipments[slot - 1] = defensiveEquipment;
                        }
                        else
                            throw new InvalidOperationException($"Can not install a doomsday '{defensiveEquipment.Name}' defensive equipment in '{Name}' ship");
                    }
                    else
                        throw new InvalidOperationException("Unknown ship");
                }
                else
                    throw new Exception("Invalid Slot");
            }
        }


        public enum Equipments
        {
            Weapon,
            DefensiveModule,
            EngineeringModule
        }

        public void RemoveEquipment(Equipments equipments, int slotIndex)
        {
            if (equipments == Equipments.Weapon)
            {
                if (slotIndex < 0 || slotIndex >= EquipmentSlots[0].Equipments.Count)
                    throw new ArgumentOutOfRangeException(nameof(slotIndex));
                EquipmentSlots[0].Equipments.RemoveAt(slotIndex);
            }

        }
    }
}
