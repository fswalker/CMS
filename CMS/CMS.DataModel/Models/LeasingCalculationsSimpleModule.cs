using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Interfaces;

namespace CMS.DataModel.Models
{
    public class LeasingCalculationsSimpleModule : ILeasingCalculationsModule
    {
        public decimal CalculateCost(ILeasingProduct leasingProduct)
        {
            return leasingProduct.Bonuses.Count() * 1.5m;
        }
    }
}
