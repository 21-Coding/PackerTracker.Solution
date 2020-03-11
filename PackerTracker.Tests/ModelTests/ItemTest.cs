using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;
namespace PackerTracker.Tests
{

    [TestClass]
    public class UnitTest1 : IDisposable
    {
        public void Dispose()
        {
            CampingItems.ClearAll();
        }
        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
            CampingItems newItem = new CampingItems("flashlight", 4 , 11, true, "Noah");
            int result = newItem.Id;
            Assert.AreEqual(1 , result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
            //Arrange
            CampingItems newItem = new CampingItems("flashlight", 4 , 11, true, "Noah");
            CampingItems newItem2 = new CampingItems("backpack", 6 , 15, true, "Isaac");

            //Act
            CampingItems result = CampingItems.Find(2);

            //Assert
            Assert.AreEqual(newItem2.Item, result.Item);
        }
    }
}

           
            




