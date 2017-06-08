using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2016Day2
{
    public class Computator
    {

        public List<int> ComputateResult(string[] inputData)
        {
            List<Numpad> myList = new List<Numpad>();
           
            foreach (var word in inputData)
            {
                Numpad numpad = new Numpad();
                if (myList.Any())
                {
                    numpad.Width = myList.Last().Width;
                    numpad.Height = myList.Last().Height;
                }

                
                foreach (var character in word)
                {
                    if (character == 'U')
                    {
                        ++numpad.Height;
                    }
                    else if (character == 'D')
                    {
                        --numpad.Height;
                    }
                    else if (character == 'L')
                    {
                        --numpad.Width;
                    }
                    else if(character == 'R')
                    {
                        ++numpad.Width;
                    }
                }
                myList.Add(numpad);
            }

            return myList.Select(numpad => numpad.numpadnumbers[numpad.Height][numpad.Width]).ToList();
        }


        public void Test()
        {
        }
    }
}
