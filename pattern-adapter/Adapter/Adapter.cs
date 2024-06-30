using pattern_adapter.Interfaces;
using pattern_adapter.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_adapter.Adapter
{
    public class AdapterClass : ITargetInterface
    {
        private LegacyClass legacyClass;

        public AdapterClass(LegacyClass legacyClass)
        {
            this.legacyClass = legacyClass;
        }

        public string GetModernData()
        {
            string modernData = "Datos adaptados: " + legacyClass.GetData();
            return modernData;
        }

        public void DoSpecificOperation()
        {
            ((LegacyClass)legacyClass).DoSpecificOperation();
        }
    }
}
