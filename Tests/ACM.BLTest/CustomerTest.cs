using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange - Instancia da classe
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act - Operação a ser testada
            string actual = customer.FullName;

            //Assert - Verificação se o valor esperado equivale ao valor real

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFistNameEmpty()
        {
            // Arrange - Instancia da classe
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // Act - Operação a ser testada
            string actual = customer.FullName;

            //Assert - Verificação se o valor esperado equivale ao valor real

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange - Instancia da classe
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;
            // Act - Operação a ser testada


            //Assert - Verificação se o valor esperado equivale ao valor real

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange - Instancia da classe
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddres = "fbaggins@hobbiton.me"
            };

            var expected = true;
            // Act - Operação a ser testada

            var actual = customer.Validate();

            //Assert - Verificação se o valor esperado equivale ao valor real

            Assert.AreEqual(expected, actual);
        }
    }
}
