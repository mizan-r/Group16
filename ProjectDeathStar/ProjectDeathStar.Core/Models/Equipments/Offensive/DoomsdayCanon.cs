namespace DeathStar.Core.Models
{
	public class DoomsdayCanon
		: DoomsdayBase
	{
		public DoomsdayCanon()
			: base()
			=> DamageFactors[DamageEffects.Thermal] =
			DamageFactors[DamageEffects.Explosive] = DamageFactors[DamageEffects.Kinetic] = 10000;
	}
}
