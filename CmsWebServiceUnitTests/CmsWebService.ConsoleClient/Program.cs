using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsWebService;

namespace CmsWebService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CmsWebService.CmsWebService service = new CmsWebService.CmsWebService();
            CmsWebService.Bonus bonus = new CmsWebService.Bonus() { Name = "Bonus", Description = "Description", Price = 100m };
            int id = service.AddBonus(bonus);
            CmsWebService.Bonus remoteBonus = service.GetBonus(id);
            Console.WriteLine(remoteBonus.ToString());
            Console.ReadKey();
        }
    }
}
