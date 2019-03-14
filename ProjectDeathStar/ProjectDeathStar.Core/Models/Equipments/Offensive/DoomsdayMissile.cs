namespace DeathStar.Core.Models
{
	public class DoomsdayMissile
		: DoomsdayBase
	{
		public DoomsdayMissile()
			: base()
		{
			DamageFactors[DamageEffects.Explosive] = 20000;
			DamageFactors[DamageEffects.Thermal] = 10000;
		}
	}
}
