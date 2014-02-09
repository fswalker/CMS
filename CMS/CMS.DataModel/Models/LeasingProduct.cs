using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataModel.Models
{
    public class LeasingProduct
    {
        public string Name { get; set; }
        public LeasingCategory[] Categories { get; set; }
        public LeasingBonus[] Bonuses { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public LeasingCalculations CalculationsRule { get; set; }
    }
}
