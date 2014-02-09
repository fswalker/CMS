using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Interfaces;

namespace CMS.DataModel.Models
{
    public class LeasingCalculations
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public LeasingCalculationsSimpleModule CalculationsModule { get; set; }
    }
}
