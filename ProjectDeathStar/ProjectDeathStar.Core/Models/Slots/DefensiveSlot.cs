using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public class DefensiveSlot
		: Slot
	{

		public new IList<DefensiveEquipment> Slots { get; private set; }

		public DefensiveSlot(uint count)
			: base(count)
		{
		}
	}
}
