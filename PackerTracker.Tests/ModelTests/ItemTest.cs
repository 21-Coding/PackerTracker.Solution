using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
            CampingItems newItem = new CampingItems("flashlight", 4 , 11, true, "Noah");
            int result = newItem.Id;
            Assert.AreEqual(1 , result);
        }
    }
}

           
            




