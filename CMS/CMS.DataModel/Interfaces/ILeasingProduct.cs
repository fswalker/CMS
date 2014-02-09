using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Models;

namespace CMS.DataModel.Interfaces
{
    public interface ILeasingProduct
    {
         int Id { get; set; }
         string Name { get; set; }
         LeasingCategory[] Categories { get; set; }
         LeasingBonus[] Bonuses { get; set; }
         string Description { get; set; }
         decimal Price { get; set; }
         byte[] Image { get; set; }
         LeasingCalculations CalculationsRule { get; set; }
    }
}
