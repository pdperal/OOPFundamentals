using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL.Repository;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expexted = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted size set of siunflower",
                ProductName = "Sunflower"
            };

            //Act
            var actual = productRepository.Retrieve(2);

            //Assert

            Assert.AreEqual(expexted.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expexted.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expexted.ProductName, actual.ProductName);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size etc",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // act
            var actual = productRepository.Save(updatedProduct);

            //assert

            Assert.AreEqual(true, actual);
        }
        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size etc",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(false, actual);
        }
    }
}
