using System;
using System.Collections.Generic;

#nullable disable

namespace ResearchProject.Models
{
    public partial class AttributesPrice
    {
        public int AtrributesPriceId { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
