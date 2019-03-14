using System.Collections.Generic;

namespace DeathStar.Core.Models
{
    public enum DefensiveModuless
    {

    }

	public class DefensiveEquipment
		: EquipmentBase
	{
		public IReadOnlyDictionary<DefensiveEquipmentGrades, uint> ResistanceFactors { get; protected set;}
	}
}
