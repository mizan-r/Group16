namespace DeathStar.Core.Models
{
	public class DoomsdayBeam
		: DoomsdayBase
	{
		public DoomsdayBeam()
			: base()
			=> DamageFactors[DamageEffects.Electromagnetic] = 30000;
	}
}
