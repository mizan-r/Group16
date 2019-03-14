using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public class WeaponSlot
		: Slot
	{
		public new IList<IWeapon> Equipments { get; private set; }

		public WeaponSlot()
			: base()
			=> Equipments = new List<IWeapon>();

		public WeaponSlot(uint count)
			: base(count)
			=> Equipments = new List<IWeapon>((int)count);
	}
}
