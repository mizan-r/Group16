using System.Collections.Generic;

namespace DeathStar.Core.Models
{
	public abstract class Slot
	{
		public virtual IList<EquipmentBase> Equipments { get; protected set; }

		protected Slot()
			=> Equipments = new List<EquipmentBase>();

		protected Slot(uint count) 
			=> Equipments = new List<EquipmentBase>((int)count);
	}
}
