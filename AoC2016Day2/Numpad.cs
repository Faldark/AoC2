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
            new char[] {'0','0','0','0','0','0','0'},
            new char[] {'0','0','0','1','0','0','0'},
            new char[] {'0','0','2','3','4','0','0'},
            new char[] {'0','5','6','7','8','9','0'},
            new char[] {'0','0','A','B','C','0','0'},
            new char[] {'0','0','0','D','0','0','0'},
            new char[] {'0','0','0','0','0','0','0'}
        };


        public int Height { get; set; } = 3;

        public int Width { get; set; } = 1;
    }
}
