using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CmsWebServiceUnitTests
{
    using NUnit.Framework;
    using CmsWebService;

    [TestFixture]
    public class CmsWebServiceUnitTests
    {
        private CmsWebService.CmsWebService cmsWeb;

        [SetUp]
        public void Init()
        {
            cmsWeb = new CmsWebService.CmsWebService();
        }

        #region ProductTests
        [Test]
        public void GetProductsTest()
        {
            Product[] productsArray = new Product[3];
            int[] productsIndexes = new int[3];
            int productsNumberBefore = cmsWeb.GetProducts().Length;
            for (int i = 0; i < 3; i++)
            {
                Product p = new Product() { Name = "Product " + (i + 1).ToString(), Description = "Desc prod " + (i + 1).ToString(), Price = (i + 1) * 10m };
                productsArray[i] = p;
                productsIndexes[i] = cmsWeb.AddProduct(p);
            }
            var products = cmsWeb.GetProducts();
            Assert.AreEqual(3, products.Length - productsNumberBefore, "Some products are missing!");
            for (int j = 0; j < 3; j++)
            {
                Assert.AreEqual(productsArray[j].Name, cmsWeb.GetProduct(productsIndexes[j]).Name, "Names of the products are different!");
                Assert.AreEqual(productsArray[j].Description, cmsWeb.GetProduct(productsIndexes[j]).Description, "Descriptions of the products are different!");
                Assert.AreEqual(productsArray[j].Price, cmsWeb.GetProduct(productsIndexes[j]).Price, "Prices of the products are different!");
            }
        }

        [Test]
        public void GetProductTest()
        {
            Product p = new Product() { Name = "Product " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddProduct(p);
            int productsNumberBefore = cmsWeb.GetProducts().Length;
            Product wsProduct = cmsWeb.GetProduct(id);
            int productsNumberAfter = cmsWeb.GetProducts().Length;
            Assert.AreEqual(productsNumberAfter, productsNumberBefore, "Getting product modifies data base!");
            Assert.AreEqual(p.Name, wsProduct.Name, "Names of the products are different!");
            Assert.AreEqual(p.Description, wsProduct.Description, "Descriptions of the products are different!");
            Assert.AreEqual(p.Price, wsProduct.Price, "Prices of the products are different!");
        }

        [Test]
        public void AddProductTest()
        {
            int productsNumberBefore = cmsWeb.GetProducts().Length;
            Product p = new Product() { Name = "Product " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddProduct(p);
            int productsNumberAfter = cmsWeb.GetProducts().Length;
            Product wsProduct = cmsWeb.GetProduct(id);
            Assert.AreEqual(productsNumberAfter, productsNumberBefore + 1, "Adding product doesn't work!");
            Assert.AreEqual(p.Name, wsProduct.Name, "Names of the products are different!");
            Assert.AreEqual(p.Description, wsProduct.Description, "Descriptions of the products are different!");
            Assert.AreEqual(p.Price, wsProduct.Price, "Prices of the products are different!");
        }

        [Test]
        public void RemoveProductTest()
        {
            int productsNumber = cmsWeb.GetProducts().Length;
            Product p = new Product() { Name = "Product " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddProduct(p);
            bool result = cmsWeb.RemoveProduct(id);
            Assert.IsTrue(result, "Removing of the product went wrong!");
            Assert.AreEqual(productsNumber, cmsWeb.GetProducts().Length, "Number of products is bad!");
        }

        [Test]
        public void EditProductTest()
        {
            string expectedName = "Product 7";
            string expectedDescription = "Great description number 7";
            decimal expectedPrice = 7.77m;
            Product expectedProduct = new Product() { Name = expectedName, Description = expectedDescription, Price = expectedPrice };

            Product p = new Product() { Name = "Product " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddProduct(p);

            bool result = cmsWeb.EditProduct(id, expectedProduct);
            Product changedProduct = cmsWeb.GetProduct(id);

            Assert.AreEqual(expectedName, changedProduct.Name, "Name didn't change!");
            Assert.AreEqual(expectedDescription, changedProduct.Description, "Description didn't change!");
            Assert.AreEqual(expectedPrice, changedProduct.Price, "Price didn't change!");
        }
        #endregion

        #region CategoriesTest
        [Test]
        public void GetCategoriesTest()
        {
            Category[] CategorysArray = new Category[3];
            int[] CategorysIndexes = new int[3];
            int CategorysNumberBefore = cmsWeb.GetCategories().Length;
            for (int i = 0; i < 3; i++)
            {
                Category p = new Category() { Name = "Category " + (i + 1).ToString(), Description = "Desc cat " + (i + 1).ToString() };
                CategorysArray[i] = p;
                CategorysIndexes[i] = cmsWeb.AddCategory(p);
            }
            var Categorys = cmsWeb.GetCategories();
            Assert.AreEqual(3, Categorys.Length - CategorysNumberBefore, "Some Categories are missing!");
            for (int j = 0; j < 3; j++)
            {
                Assert.AreEqual(CategorysArray[j].Name, cmsWeb.GetCategory(CategorysIndexes[j]).Name, "Names of the Categorys are different!");
                Assert.AreEqual(CategorysArray[j].Description, cmsWeb.GetCategory(CategorysIndexes[j]).Description, "Descriptions of the Categorys are different!");
            }
        }

        [Test]
        public void GetCategoryTest()
        {
            Category p = new Category() { Name = "Category " + (1).ToString(), Description = "Desc prod " + (1).ToString() };
            int id = cmsWeb.AddCategory(p);
            int CategorysNumberBefore = cmsWeb.GetCategories().Length;
            Category wsCategory = cmsWeb.GetCategory(id);
            int CategorysNumberAfter = cmsWeb.GetCategories().Length;
            Assert.AreEqual(CategorysNumberAfter, CategorysNumberBefore, "Getting Category modifies data base!");
            Assert.AreEqual(p.Name, wsCategory.Name, "Names of the Categories are different!");
            Assert.AreEqual(p.Description, wsCategory.Description, "Descriptions of the Categories are different!");
        }

        [Test]
        public void AddCategoryTest()
        {
            int CategorysNumberBefore = cmsWeb.GetCategories().Length;
            Category p = new Category() { Name = "Category " + (1).ToString(), Description = "Desc prod " + (1).ToString() };
            int id = cmsWeb.AddCategory(p);
            int CategorysNumberAfter = cmsWeb.GetCategories().Length;
            Category wsCategory = cmsWeb.GetCategory(id);
            Assert.AreEqual(CategorysNumberAfter, CategorysNumberBefore + 1, "Adding Category doesn't work!");
            Assert.AreEqual(p.Name, wsCategory.Name, "Names of the Categorys are different!");
            Assert.AreEqual(p.Description, wsCategory.Description, "Descriptions of the Categorys are different!");
        }

        [Test]
        public void RemoveCategoryTest()
        {
            int CategorysNumber = cmsWeb.GetCategories().Length;
            Category p = new Category() { Name = "Category " + (1).ToString(), Description = "Desc prod " + (1).ToString() };
            int id = cmsWeb.AddCategory(p);
            bool result = cmsWeb.RemoveCategory(id);
            Assert.IsTrue(result, "Removing of the Category went wrong!");
            Assert.AreEqual(CategorysNumber, cmsWeb.GetCategories().Length, "Number of Categorys is bad!");
        }

        [Test]
        public void EditCategoryTest()
        {
            string expectedName = "Category 7";
            string expectedDescription = "Great description number 7";
            Category expectedCategory = new Category() { Name = expectedName, Description = expectedDescription };

            Category p = new Category() { Name = "Category " + (1).ToString(), Description = "Desc prod " + (1).ToString() };
            int id = cmsWeb.AddCategory(p);

            bool result = cmsWeb.EditCategory(id, expectedCategory);
            Category changedCategory = cmsWeb.GetCategory(id);

            Assert.AreEqual(expectedName, changedCategory.Name, "Name didn't change!");
            Assert.AreEqual(expectedDescription, changedCategory.Description, "Description didn't change!");
        }
        #endregion

        #region BonusTests
        [Test]
        public void GetBonusesTest()
        {
            Bonus[] BonusesArray = new Bonus[3];
            int[] BonusesIndexes = new int[3];
            int BonusesNumberBefore = cmsWeb.GetBonuses().Length;
            for (int i = 0; i < 3; i++)
            {
                Bonus p = new Bonus() { Name = "Bonus " + (i + 1).ToString(), Description = "Desc bonus " + (i + 1).ToString(), Price = (i + 1) * 10m };
                BonusesArray[i] = p;
                BonusesIndexes[i] = cmsWeb.AddBonus(p);
            }
            var Bonuses = cmsWeb.GetBonuses();
            Assert.AreEqual(3, Bonuses.Length - BonusesNumberBefore, "Some Bonuses are missing!");
            for (int j = 0; j < 3; j++)
            {
                Assert.AreEqual(BonusesArray[j].Name, cmsWeb.GetBonus(BonusesIndexes[j]).Name, "Names of the Bonuses are different!");
                Assert.AreEqual(BonusesArray[j].Description, cmsWeb.GetBonus(BonusesIndexes[j]).Description, "Descriptions of the Bonuses are different!");
                Assert.AreEqual(BonusesArray[j].Price, cmsWeb.GetBonus(BonusesIndexes[j]).Price, "Prices of the Bonuses are different!");
            }
        }

        [Test]
        public void GetBonusTest()
        {
            Bonus p = new Bonus() { Name = "Bonus " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddBonus(p);
            int BonusesNumberBefore = cmsWeb.GetBonuses().Length;
            Bonus wsBonus = cmsWeb.GetBonus(id);
            int BonusesNumberAfter = cmsWeb.GetBonuses().Length;
            Assert.AreEqual(BonusesNumberAfter, BonusesNumberBefore, "Getting Bonus modifies data base!");
            Assert.AreEqual(p.Name, wsBonus.Name, "Names of the Bonuses are different!");
            Assert.AreEqual(p.Description, wsBonus.Description, "Descriptions of the Bonuses are different!");
            Assert.AreEqual(p.Price, wsBonus.Price, "Prices of the Bonuses are different!");
        }

        [Test]
        public void AddBonusTest()
        {
            int BonusesNumberBefore = cmsWeb.GetBonuses().Length;
            Bonus p = new Bonus() { Name = "Bonus " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddBonus(p);
            int BonusesNumberAfter = cmsWeb.GetBonuses().Length;
            Bonus wsBonus = cmsWeb.GetBonus(id);
            Assert.AreEqual(BonusesNumberAfter, BonusesNumberBefore + 1, "Adding Bonus doesn't work!");
            Assert.AreEqual(p.Name, wsBonus.Name, "Names of the Bonuses are different!");
            Assert.AreEqual(p.Description, wsBonus.Description, "Descriptions of the Bonuses are different!");
            Assert.AreEqual(p.Price, wsBonus.Price, "Prices of the Bonuses are different!");
        }

        [Test]
        public void RemoveBonusTest()
        {
            int BonusesNumber = cmsWeb.GetBonuses().Length;
            Bonus p = new Bonus() { Name = "Bonus " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddBonus(p);
            bool result = cmsWeb.RemoveBonus(id);
            Assert.IsTrue(result, "Removing of the Bonus went wrong!");
            Assert.AreEqual(BonusesNumber, cmsWeb.GetBonuses().Length, "Number of Bonuses is bad!");
        }

        [Test]
        public void EditBonusTest()
        {
            string expectedName = "Bonus 7";
            string expectedDescription = "Great description number 7";
            decimal expectedPrice = 7.77m;
            Bonus expectedBonus = new Bonus() { Name = expectedName, Description = expectedDescription, Price = expectedPrice };

            Bonus p = new Bonus() { Name = "Bonus " + (1).ToString(), Description = "Desc prod " + (1).ToString(), Price = (1) * 10m };
            int id = cmsWeb.AddBonus(p);

            bool result = cmsWeb.EditBonus(id, expectedBonus);
            Bonus changedBonus = cmsWeb.GetBonus(id);

            Assert.AreEqual(expectedName, changedBonus.Name, "Name didn't change!");
            Assert.AreEqual(expectedDescription, changedBonus.Description, "Description didn't change!");
            Assert.AreEqual(expectedPrice, changedBonus.Price, "Price didn't change!");
        }
        #endregion
    }
}
