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
        [TestMethod()]
        public void ComputateResultSecondStarShouldReturnGenericListWithResult()
        {
            //given
            string[] inputData = new[] { "DDLUURRR", "UURDD"  };
            List<char> suposedResult = new List<char>() { '8', 'C' };
            DataReader reader = new DataReader();
            Computator computator = new Computator();

            CompareLogic comparer = new CompareLogic();

            //when
            List<char> result = computator.ComputateResultSecondStar(inputData);

            //then
            Assert.IsTrue(comparer.Compare(suposedResult, result).AreEqual, "something went wrong");

        }
    }
}