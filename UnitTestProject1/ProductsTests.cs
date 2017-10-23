using System;
using System.Linq;
using lab3dotnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductsTests
    {
        [TestMethod]
        public void When_GettingProductByName_ShouldReturn_ThatProduct()
        {
            var product = repo.GetProductByName("nume1");

            Assert.AreEqual("nume1", product.ProductName);
        }


        [TestMethod]
        public void When_FindingAllProducts_Should_Return_AllProducts()
        {
            Assert.AreEqual(repo.Products.All(repo.FindAllProducts().Contains), true);
        }

        [TestMethod]
        public void When_AddingAProduct_ItShouldBeInProducts()
        {
            Product product = new Product("name4", "desc4", 500);
            repo.AddProduct(product);
            Assert.AreEqual(product.ProductName, repo.GetProductByName(product.ProductName).ProductName);
        }

        [TestMethod]
        public void When_GettingByPositionAtZero_ShouldReturnFirstElement()
        {
            Assert.AreEqual(repo.GetProductByPosition(0).ProductName, "nume1");
        }

        [TestMethod]
        public void When_RemovingFirstElement_ItShouldNotExistInList()
        {
            repo.RemoveProductByName("nume1");

            Assert.AreNotEqual("nume1", repo.GetProductByName("nume1"));
            Assert.AreEqual(2, repo.FindAllProducts().Count);
        }

        [TestMethod]
        public void When_GettingProductsWithPriceGreaterThan250_ItShouldReturnLastElement()
        {
            var product = repo.GetProductsWithPriceGreaterThen(250);

            Assert.AreEqual(300, product[0].ProductPrice);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_GettingProductAtNegativePosition_ShouldThrowException()
        {
            var product = repo.GetProductByPosition(-1);

        }


        private ProductRepository repo = new ProductRepository();

    }
}
