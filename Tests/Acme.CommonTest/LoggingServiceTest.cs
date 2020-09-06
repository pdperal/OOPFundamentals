using System;
using System.Collections.Generic;
using Acme.Commom.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using ACM.BL.Entities;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddres = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            // act
            LoggingService.WriteToFile(changedItems);
        }
    }
}
