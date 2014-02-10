using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataModel.Models;

namespace CMS.DataModel.Interfaces
{
    public interface ICmsRepository
    {
        #region Product
        List<Product> GetProducts();
        Product GetProduct(int id);
        int AddProduct(Product product);
        bool RemoveProduct(int id);
        bool EditProduct(int id, Product updatedProduct);
        #endregion

        #region Category
        List<Category> GetCategories();
        Category GetCategory(int id);
        int AddCategory(Category category);
        bool RemoveCategory(int id);
        bool EditCategory(int id, Category updatedCatgory);
        #endregion

        #region Bonus
        List<Bonus> GetBonuses();
        Bonus GetBonus(int id);
        int AddBonus(Bonus bonus);
        bool RemoveBonus(int id);
        bool EditBonus(int id, Bonus updatedBonus);
        #endregion
    }
}
