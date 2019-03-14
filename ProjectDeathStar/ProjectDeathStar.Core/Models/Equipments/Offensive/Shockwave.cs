using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public class Shockwave
		: WeaponBase
	{
		public Shockwave()
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
				{WeaponGrades.Small, 0},
				{WeaponGrades.Medium, 0},
				{WeaponGrades.Large, 0},
				{WeaponGrades.XLarge, 0},
				{WeaponGrades.XXLagre, 0}
			};
			DamageFactors[DamageEffects.Electromagnetic] = new Dictionary<WeaponGrades, uint>
			{
				{WeaponGrades.Small, 30},
				{WeaponGrades.Medium, 60},
				{WeaponGrades.Large, 150},
				{WeaponGrades.XLarge, 300},
				{WeaponGrades.XXLagre, 1500}
			};
			DamageFactors[DamageEffects.Kinetic] = new Dictionary<WeaponGrades, uint>
			{
				{WeaponGrades.Small, 0},
				{WeaponGrades.Medium, 0},
				{WeaponGrades.Large, 0},
				{WeaponGrades.XLarge, 0},
				{WeaponGrades.XXLagre, 0}
			};
		}
	}
}
