using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC2016Day2
{
    public class DataReader
    {
        private string _filepath = @"D:\input data\AoCday2.txt";

        public string[] ReadDataFromFile()
        {
            return File.ReadAllLines(_filepath);
        }

        //public string[][] ParseData(string[] inputData)
        //{
        //    string[][] jaggedArray = new string[4][];

            
        //    int i = 0;
        //    foreach (var array in inputData)
        //    {
                
        //        string[] parsedArray = Regex.Split(array, @"[A-Z]");
        //        jaggedArray[i] = parsedArray;
        //        i++;
        //    }
        //    return jaggedArray;
        //}
    }
}
