using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public class Canon
		: WeaponBase
	{
		public Canon()
			: base()
		{
			DamageFactors[DamageEffects.Thermal] = new Dictionary<WeaponGrades, uint>
			{
				{WeaponGrades.Small, 0},
				{WeaponGrades.Medium, 0},
				{WeaponGrades.Large,0 },
				{WeaponGrades.XLarge, 0},
				{WeaponGrades.XXLagre, 0}
			};
			DamageFactors[DamageEffects.Explosive] = new Dictionary<WeaponGrades, uint>
			{
				{WeaponGrades.Small, 10},
				{WeaponGrades.Medium, 20},
				{WeaponGrades.Large,50 },
				{WeaponGrades.XLarge, 100},
				{WeaponGrades.XXLagre, 500}
			};
			DamageFactors[DamageEffects.Electromagnetic] = new Dictionary<WeaponGrades, uint>
			{
				{WeaponGrades.Small, 0},
				{WeaponGrades.Medium, 0},
				{WeaponGrades.Large,0 },
				{WeaponGrades.XLarge, 0},
				{WeaponGrades.XXLagre, 0}
			};
			DamageFactors[DamageEffects.Kinetic] = new Dictionary<WeaponGrades, uint>
			{
				{WeaponGrades.Small, 20},
				{WeaponGrades.Medium, 40},
				{WeaponGrades.Large,100 },
				{WeaponGrades.XLarge, 200},
				{WeaponGrades.XXLagre, 1000}
			};
		}
	}
}
