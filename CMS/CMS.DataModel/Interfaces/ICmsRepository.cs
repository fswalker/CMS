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
        List<LeasingProduct> GetProducts();
        LeasingProduct GetProduct(int id);
        int AddLeasingProduct(LeasingProduct leasingProduct);
        bool RemoveLeasingProduct(int id);
        bool EditLeasingProduct(int id, LeasingProduct updatedProduct);

        List<LeasingCategory> GetCategories();
        LeasingCategory GetCategory(int id);
        int AddLeasingCategory(LeasingCategory leasingCategory);
        bool RemoveLeasingCategory(int id);
        bool EditLeasingCategory(int id, LeasingCategory updatedCatgory);

        List<LeasingBonus> GetBonuses();
        LeasingBonus GetBonus(int id);
        int AddLeasingBonus(LeasingBonus leasingCategory);
        bool RemoveLeasingBonus(int id);
        bool EditLeasingBonus(int id, LeasingBonus updatedBonus);
    }
}
