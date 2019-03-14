using System.Collections.Generic;
using System.Linq;

namespace DeathStar.Core.Models
{
	public abstract class WeaponBase
		: EquipmentBase
	{
		public virtual IDictionary<DamageEffects, IDictionary<WeaponGrades, uint>> DamageFactors { get; protected set; }

		public WeaponGrades Grade { get; protected set; }

		protected WeaponBase()
			=> DamageFactors = new Dictionary<DamageEffects, IDictionary<WeaponGrades, uint>>
			{
				{DamageEffects.Kinetic, null},
				{DamageEffects.Thermal, null },
				{DamageEffects.Explosive, null},
				{DamageEffects.Electromagnetic, null}
			};
	}
}
