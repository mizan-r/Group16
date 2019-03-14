using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public class EngineeringSlot
		: Slot
	{

		public new IList<EngineeringEquipmentBase> Slots { get; private set; }

		public EngineeringSlot(uint count)
			: base(count)
		{

		}
	}
}
