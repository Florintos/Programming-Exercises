using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Disaheim.Enum;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string Design { get; set; }

        private Enum.Level quality;
        public Enum.Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public Amulet(string itemId)
        {
            ItemId = itemId;
        }
        public Amulet(string itemId, Enum.Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }
        public Amulet(string itemId, Enum.Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
