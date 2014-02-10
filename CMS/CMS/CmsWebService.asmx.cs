using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CMS.DataModel;
using CMS.DataModel.Interfaces;
using CMS.DataModel.Models;

namespace CMS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://bestleasing.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.Web.Script.Services.ScriptService]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
     class CmsWebService: System.Web.Services.WebService
    {
        private ICmsRepository _cmsDataRepository = new CmsRepository();

        [WebMethod]
        public List<Product> GetProducts()
        {
            return _cmsDataRepository.GetProducts();
        }
        [WebMethod]
        public Product GetProduct(int id)
        {
            return _cmsDataRepository.GetProduct(id);
        }
        [WebMethod]
        public int AddProduct(Product Product)
        {
            return _cmsDataRepository.AddProduct(Product);
        }
        [WebMethod]
        public bool RemoveProduct(int id)
        {
            return _cmsDataRepository.RemoveProduct(id);
        }
        [WebMethod]
        public bool EditProduct(int id, Product updatedProduct)
        {
            return _cmsDataRepository.EditProduct(id, updatedProduct);
        }

        [WebMethod]
        public List<Category > GetCategories()
        {
            return _cmsDataRepository.GetCategories();
        }
        [WebMethod]
        public Category  GetCategory(int id)
        {
            return _cmsDataRepository.GetCategory(id);
        }
        [WebMethod]
        public int AddCategory (Category  Category )
        {
            return _cmsDataRepository.AddCategory (Category );
        }
        [WebMethod]
        public bool RemoveCategory (int id)
        {
            return _cmsDataRepository.RemoveCategory (id);
        }
        [WebMethod]
        public bool EditCategory (int id, Category  updatedCatgory)
        {
            return _cmsDataRepository.EditCategory (id, updatedCatgory);
        }

        [WebMethod]
        public List<Bonus> GetBonuses()
        {
            return _cmsDataRepository.GetBonuses();
        }
        [WebMethod]
        public Bonus GetBonus(int id)
        {
            return _cmsDataRepository.GetBonus(id);
        }
        [WebMethod]
        public int AddBonus(Bonus Bonus)
        {
            return _cmsDataRepository.AddBonus(Bonus);
        }
        [WebMethod]
        public bool RemoveBonus(int id)
        {
            return _cmsDataRepository.RemoveBonus(id);
        }
        [WebMethod]
        public bool EditBonus(int id, Bonus updatedBonus)
        {
            return _cmsDataRepository.EditBonus(id, updatedBonus);
        }
    }
}
