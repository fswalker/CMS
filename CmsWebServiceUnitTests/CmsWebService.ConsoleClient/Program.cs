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
            //CmsWebService.Bonus bonus = new CmsWebService.Bonus() { Name = "Bonus", Description = "Description", Price = 100m };
            //int id = service.AddBonus(bonus);

            CmsWebService.Product product = new CmsWebService.Product() { Name = "Bonus", Description = "Description", Price = 100m };
            int id = service.AddProduct(product);
            CmsWebService.Product expected = new CmsWebService.Product() { Description = "D", Name = "N", Price = 7m };
            bool result = service.EditProduct(id, expected);

            CmsWebService.Product edited = service.GetProduct(id);

            //CmsWebService.Bonus remoteBonus = service.GetBonus(id);
            //Console.WriteLine(remoteBonus.ToString());

            //CmsWebService.Category category = new CmsWebService.Category() { Description = "Cat desc", Name = "cat name" };
            //int catid = service.AddCategory(category);

            //CmsWebService.Product[] ProductsArray = new CmsWebService.Product[3];
            //int[] ProductsIndexes = new int[3];
            //CmsWebService.Bonus[] bonuses = new CmsWebService.Bonus[1];
            //bonuses[0] = bonus;

            //for (int i = 0; i < 3; i++)
            //{
            //    CmsWebService.Product p = new CmsWebService.Product() { BonusId = bonus.BonusId, CategoryId = category.CategoryId, Name = "CmsWebService.Product " + (i + 1).ToString(), Description = "Desc prod " + (i + 1).ToString(), Price = (i + 1) * 10m };
            //    ProductsArray[i] = p;
            //    ProductsIndexes[i] = service.AddProduct(p);
            //}
            //var products = service.GetProducts();
            Console.ReadKey();
        }
    }
}
