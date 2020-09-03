﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL.Repository;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {

            //arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //act
            var actual = orderRepository.Retrieve(10);

            //assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
