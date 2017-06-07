using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC2016Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2016Day2.Tests
{
    [TestClass()]
    public class DataReaderBehaviour
    {
        [TestMethod()]
        public void ReadDataFromFileShouldReturnStringArrayWithElements()
        {
            DataReader reader = new DataReader();
            string[] result = reader.ReadDataFromFile();



            Assert.IsInstanceOfType(result, typeof(string[]), "sorry, returned object was not an string[] type");
            Assert.IsTrue(result.Any(), "sorry, array is empty, thats means file is empty or something went wrong");
        }

        //[TestMethod()]
        //public void ParseDataShouldReturnJaggedArray()
        //{
        //    //given
        //    string[] inputData = new[] {"UUDDD", "DDUUU"};
        //    string[][] properResult = new string[][]
        //    {
        //        new string[] {"U", "U", "D","D","D"},
        //        new string[] {"D", "D", "U","U","U"}
        //    };

        //    DataReader reader = new DataReader();

            

        //    //when
        //    string[][] takenResult = reader.ParseData(reader.ReadDataFromFile());

        //    //then

        //    Assert.AreEqual(properResult, takenResult, "wrong estimated result");
        //}


    }
}