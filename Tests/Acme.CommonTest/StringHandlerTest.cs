using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Commom; 

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // arrange
            var source = "SonicSchewdriver";
            var expected = "Sonic Schewdriver";

            // act
            var actual = StringHandler.InsertSpaces(source);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // arrange
            var source = "Sonic Schewdriver";
            var expected = "Sonic Schewdriver";
            
            // act
            var actual = StringHandler.InsertSpaces(source);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
