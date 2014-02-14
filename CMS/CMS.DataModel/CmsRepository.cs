using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Interfaces;
using CMS.DataModel.Models;
using System.Data.Entity;
using System.Xml.Serialization;

namespace CMS.DataModel
{
    public class CmsRepository : ICmsRepository
    {

        #region Product
        public List<Product> GetProducts()
        {
            using (var db = new LeasingContext())
            {
                return db.Products.ToList<Product>();
            }
        }
        public Product GetProduct(int id)
        {
            using (var db = new LeasingContext())
            {
                return db.Products.Find(id);
            }
        }
        public int AddProduct(Product product)
        {
            using (var db = new LeasingContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
                return product.ProductId;
            }
        }
        public bool RemoveProduct(int id)
        {
            using (var db = new LeasingContext())
            {
                var product = db.Products.Find(id);
                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                }
                return true;
            }
        }
        public bool EditProduct(int id, Product updatedProduct)
        {
            using (var db = new LeasingContext())
            {
                Product product = db.Products.Find(id);
                if (product != null)
                {
                    product.Name = updatedProduct.Name;
                    product.Description = updatedProduct.Description;
                    product.Price = updatedProduct.Price;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Category
        public List<Category> GetCategories()
        {
            using (var db = new LeasingContext())
            {
                return db.Categories.ToList<Category>();
            }
        }
        public Category GetCategory(int id)
        {
            using (var db = new LeasingContext())
            {
                return db.Categories.Find(id);
            }
        }
        public int AddCategory(Category category)
        {
            using (var db = new LeasingContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return category.CategoryId;
            }
        }
        public bool RemoveCategory(int id)
        {
            using (var db = new LeasingContext())
            {
                var category = db.Categories.Find(id);
                if (category != null)
                {
                    db.Categories.Remove(category);
                    db.SaveChanges();
                }
                return true;
            }
        }
        public bool EditCategory(int id, Category updatedCatgory)
        {
            using (var db = new LeasingContext())
            {
                var category = db.Categories.Find(id);
                if (category != null)
                {
                    category.Name = updatedCatgory.Name;
                    category.Description = updatedCatgory.Description;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Bonus
        public List<Bonus> GetBonuses()
        {
            using (var db = new LeasingContext())
            {
                return db.Bonuses.ToList<Bonus>();
            }
        }
        public Bonus GetBonus(int id)
        {
            using (var db = new LeasingContext())
            {
                var bonus = db.Bonuses.Find(id);
                return bonus;
            }
        }
        public int AddBonus(Bonus bonus)
        {
            using (var db = new LeasingContext())
            {
                db.Bonuses.Add(bonus);
                db.SaveChanges();
                return bonus.BonusId;
            }
        }
        public bool RemoveBonus(int id)
        {
            using (var db = new LeasingContext())
            {
                var bonus = db.Bonuses.Find(id);
                if (bonus != null)
                {
                    db.Bonuses.Remove(bonus);
                    db.SaveChanges();
                }
                return true;
            }
        }
        public bool EditBonus(int id, Bonus updatedBonus)
        {
            using (var db = new LeasingContext())
            {
                var bonus = db.Bonuses.Find(id);
                if (bonus != null)
                {
                    bonus.Name = updatedBonus.Name;
                    bonus.Description = updatedBonus.Description;
                    bonus.Price = updatedBonus.Price;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        #endregion
    }
}
