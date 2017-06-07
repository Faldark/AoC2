using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC2016Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KellermanSoftware.CompareNetObjects;

namespace AoC2016Day2.Tests
{
    [TestClass()]
    public class ComputatorTests
    {
        [TestMethod()]
        public void ComputateResultShouldReturnGenericListWithResult()
        {
            //given
            string[] inputData = new[] { "UUDDD", "DDUUU" };
            List<int> suposedResult = new List<int>() {8,2};
            DataReader reader = new DataReader();
            Computator computator = new Computator();

            CompareLogic comparer = new CompareLogic();

            //when
            List<int> result = computator.ComputateResult(inputData);

            //then
            Assert.IsTrue(comparer.Compare(suposedResult, result).AreEqual, "something went wrong");

        }
    }
}