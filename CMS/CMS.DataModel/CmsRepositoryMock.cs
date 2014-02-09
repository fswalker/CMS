using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Interfaces;
using CMS.DataModel.Models;
using CMS.DataModel.Wrappers;

namespace CMS.DataModel
{
    public class CmsRepositoryMock : ICmsRepository
    {
        private Dictionary<int, LeasingBonusWrapper> _bonuses = new Dictionary<int, LeasingBonusWrapper>();
        private Dictionary<int, LeasingCategoryWrapper> _categories = new Dictionary<int, LeasingCategoryWrapper>();
        private Dictionary<int, LeasingProductWrapper> _products = new Dictionary<int, LeasingProductWrapper>();

        public List<LeasingProduct> GetProducts()
        {
            var products = _products.Select(x => x.Value.LeasingProduct);
            return new List<LeasingProduct>(products);
        }
        public LeasingProduct GetProduct(int id)
        {
            return _products.ContainsKey(id) ?  _products[id].LeasingProduct : null;
        }
        public int AddLeasingProduct(LeasingProduct leasingProduct) {
            LeasingProductWrapper lpw = new LeasingProductWrapper() { Id = _products.Count, LeasingProduct = leasingProduct };
            _products.Add(lpw.Id, lpw);
            return lpw.Id;
        }
        public bool RemoveLeasingProduct(int id) {
            if ( _products.ContainsKey(id) )
            {
                _products.Remove(id);
                return true;
            }
            return false;
        }
        public bool EditLeasingProduct(int id, LeasingProduct updatedProduct) {
            if ( _products.ContainsKey(id)) {
                _products[id].LeasingProduct = updatedProduct;
                return true;
            }
            return false;
        }

        public List<LeasingCategory> GetCategories()
        {
            var categories = _categories.Select(x => x.Value.LeasingCategory);
            return new List<LeasingCategory>(categories);
        }
        public LeasingCategory GetCategory(int id)
        {
            return _categories.ContainsKey(id) ?  _categories[id].LeasingCategory : null;
        }
        public int AddLeasingCategory(LeasingCategory leasingCategory) {
            LeasingCategoryWrapper lcw = new LeasingCategoryWrapper() { Id = _products.Count, LeasingCategory = leasingCategory };
            _categories.Add(lcw.Id, lcw);
            return lcw.Id;
        }
        public bool RemoveLeasingCategory(int id) {
            if ( _categories.ContainsKey(id))
            {
                _categories.Remove(id);
                return true;
            }
            return false;
        }
        public bool EditLeasingCategory(int id, LeasingCategory updatedCatgory)
        {
            if (_categories.ContainsKey(id))
            {
                _categories[id].LeasingCategory = updatedCatgory;
                return true;
            }
            return false;
        }

        public List<LeasingBonus> GetBonuses()
        {
            var bonuses = _bonuses.Select(x => x.Value.LeasingBonus);
            return new List<LeasingBonus>(bonuses);
        }
        public LeasingBonus GetBonus(int id)
        {
            return _bonuses.ContainsKey(id) ?  _bonuses[id].LeasingBonus : null;
        }
        public int AddLeasingBonus(LeasingBonus leasingBonus) {
            LeasingBonusWrapper lbw = new LeasingBonusWrapper() { Id = _products.Count, LeasingBonus = leasingBonus };
            _bonuses.Add(lbw.Id, lbw);
            return lbw.Id;
        }
        public bool RemoveLeasingBonus(int id) {
            if ( _bonuses.ContainsKey(id))
            {
                _bonuses.Remove(id);
                return true;
            }
            return false;
        }
        public bool EditLeasingBonus(int id, LeasingBonus updatedBonus)
        {
            if (_bonuses.ContainsKey(id))
            {
                _bonuses[id].LeasingBonus = updatedBonus;
                return true;
            }
            return false;
        }
    }
}
