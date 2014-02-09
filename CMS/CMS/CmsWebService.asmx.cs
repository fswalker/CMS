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
        private ICmsRepository _cmsDataRepository = new CmsRepositoryMock();

        [WebMethod]
        public List<LeasingProduct> GetProducts()
        {
            return _cmsDataRepository.GetProducts();
        }
        [WebMethod]
        public LeasingProduct GetProduct(int id)
        {
            return _cmsDataRepository.GetProduct(id);
        }
        [WebMethod]
        public int AddLeasingProduct(LeasingProduct leasingProduct)
        {
            return _cmsDataRepository.AddLeasingProduct(leasingProduct);
        }
        [WebMethod]
        public bool RemoveLeasingProduct(int id)
        {
            return _cmsDataRepository.RemoveLeasingProduct(id);
        }
        [WebMethod]
        public bool EditLeasingProduct(int id, LeasingProduct updatedProduct)
        {
            return _cmsDataRepository.EditLeasingProduct(id, updatedProduct);
        }

        [WebMethod]
        public List<LeasingCategory> GetCategories()
        {
            return _cmsDataRepository.GetCategories();
        }
        [WebMethod]
        public LeasingCategory GetCategory(int id)
        {
            return _cmsDataRepository.GetCategory(id);
        }
        [WebMethod]
        public int AddLeasingCategory(LeasingCategory leasingCategory)
        {
            return _cmsDataRepository.AddLeasingCategory(leasingCategory);
        }
        [WebMethod]
        public bool RemoveLeasingCategory(int id)
        {
            return _cmsDataRepository.RemoveLeasingCategory(id);
        }
        [WebMethod]
        public bool EditLeasingCategory(int id, LeasingCategory updatedCatgory)
        {
            return _cmsDataRepository.EditLeasingCategory(id, updatedCatgory);
        }

        [WebMethod]
        public List<LeasingBonus> GetBonuses()
        {
            return _cmsDataRepository.GetBonuses();
        }
        [WebMethod]
        public LeasingBonus GetBonus(int id)
        {
            return _cmsDataRepository.GetBonus(id);
        }
        [WebMethod]
        public int AddLeasingBonus(LeasingBonus leasingBonus)
        {
            return _cmsDataRepository.AddLeasingBonus(leasingBonus);
        }
        [WebMethod]
        public bool RemoveLeasingBonus(int id)
        {
            return _cmsDataRepository.RemoveLeasingBonus(id);
        }
        [WebMethod]
        public bool EditLeasingBonus(int id, LeasingBonus updatedBonus)
        {
            return _cmsDataRepository.EditLeasingBonus(id, updatedBonus);
        }
    }
}
