using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2016Day2
{
    public class Numpad
    {
        public  int[][] numpadnumbers = new int[][]
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9}
        };


        public int Height { get; set; } = 1;

        public int Width { get; set; } = 1;
    }
    public class CharNumpad
    {
        public char[][] numpadnumbers = new char[][]
        {
            new char[] {'1'},
            new char[] {'2','3','4'},
            new char[] {'5','6','7','8','9'},
            new char[] {'A','B','C'},
            new char[] {'D'}
        };


        public int Height { get; set; } = 2;

        public int Width { get; set; } = 0;
    }
}
