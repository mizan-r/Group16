using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public interface IWeapon
		: IEquipment
	{
		IDictionary<DamageEffects, IDictionary<WeaponGrades, uint>> DamageFactors { get; }
		WeaponGrades Grade { get; }
	}
}