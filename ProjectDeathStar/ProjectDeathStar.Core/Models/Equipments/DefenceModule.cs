using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDeathStar.Core.Models.Equipments
{
    public class DefenceModule
    {
        public string Name { get; protected set; }
        public int ShieldEffectFactor { get; protected set; }
        public int ArmorEffectFactor { get; protected set; }
        public int HullEffectFactor { get; protected set; }
    }
}
