using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2016Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Computator computator = new Computator();
            //DataReader reader = new DataReader();
            //List<int> resultList = computator.ComputateResult(reader.ReadDataFromFile());
            //foreach (var number in resultList)
            //{
            //    Console.Write(number);
            //}
            //Console.Read();



            Computator computator = new Computator();
            DataReader reader = new DataReader();
            List<char> resultList = computator.ComputateResultSecondStar(reader.ReadDataFromFile());
            foreach (var number in resultList)
            {
                Console.Write(number);
            }
            Console.Read();
        }
    }

    public class Test1
    {

    }
}
