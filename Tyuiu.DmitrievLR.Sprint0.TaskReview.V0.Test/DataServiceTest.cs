using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {

            Assert.AreEqual(75, DataService.Calc(4,5,6));


        }
    }
}
