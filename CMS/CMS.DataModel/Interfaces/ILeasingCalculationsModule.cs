using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Interfaces;

namespace CMS.DataModel.Interfaces
{
    public interface ILeasingCalculationsModule
    {
         decimal CalculateCost(ILeasingProduct leasingProduct);
    }
}
