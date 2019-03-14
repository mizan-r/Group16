using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public abstract class DoomsdayBase
		: WeaponBase
	{
		public new IDictionary<DamageEffects, uint> DamageFactors { get; protected set; }

		protected DoomsdayBase()
			: base() => DamageFactors = new Dictionary<DamageEffects, uint>
			{
				{DamageEffects.Thermal, 0},
				{DamageEffects.Explosive, 0},
				{DamageEffects.Electromagnetic, 0},
				{DamageEffects.Kinetic, 0}
			};
	}
}
