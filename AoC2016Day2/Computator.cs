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
                        if (numpad.Height != 0)
                        {
                            --numpad.Height;
                        }
                        
                    }
                    else if (character == 'D')
                    {
                        if (numpad.Height != 2)
                        {
                            ++numpad.Height;
                        }
                        
                    }
                    else if (character == 'L')
                    {
                        if (numpad.Width != 0)
                        {
                            --numpad.Width;
                        }
                        
                    }
                    else if(character == 'R')
                    {
                        if (numpad.Width != 2)
                        {
                            ++numpad.Width;
                        }
                        
                    }
                }
                myList.Add(numpad);
            }

            return myList.Select(numpad => numpad.numpadnumbers[numpad.Height][numpad.Width]).ToList();
        }
        public List<char> ComputateResultSecondStar(string[] inputData)
        {
            List<CharNumpad> myList = new List<CharNumpad>();

            foreach (var word in inputData)
            {
                CharNumpad numpad = new CharNumpad();
                if (myList.Any())
                {
                    numpad.Width = myList.Last().Width;
                    numpad.Height = myList.Last().Height;
                }


                foreach (var character in word)
                {
                    //if (character == 'D')
                    //{
                    //    for (int i = 2; i < 5; i++)
                    //    {
                    //        if (numpad.numpadnumbers[numpad.Height][numpad.Width] != numpad.numpadnumbers[i].First() || numpad.numpadnumbers[numpad.Height][numpad.Width] != numpad.numpadnumbers[i].Last())
                    //        {
                    //            --numpad.Height;
                    //        }
                    //    }
                    //}

                    if (character == 'U')
                    {
                        if ((numpad.Height == 3) || (numpad.Height == 4)  || (numpad.Height == 2 && (numpad.Width == 1 || numpad.Width == 2 || numpad.Width == 3)) || (numpad.Height == 1 && numpad.Width == 1))
                        {
                            --numpad.Height;
                            if (numpad.Width < 2)
                            {
                                ++numpad.Width;
                            }
                            else
                            {
                                --numpad.Width;
                            }
                        }

                    }
                    else if (character == 'D')
                    {
                        if ((numpad.Height == 1) || (numpad.Height == 2 && (numpad.Width == 2 || numpad.Width == 1 || numpad.Width == 3)) || (numpad.Height == 3 && numpad.Width == 1) && (numpad.Height == 0))
                        {
                            ++numpad.Height;
                            if (numpad.Width > 2)
                            {
                                ++numpad.Width;
                            }
                            else
                            {
                                --numpad.Width;
                            }
                        }

                    }
                    else if (character == 'L')
                    {
                        if ((numpad.Width != 0))
                        {
                            --numpad.Width;
                            
                        }

                    }
                    else if (character == 'R')
                    {
                        if ((numpad.Height == 2 && numpad.Width == 0) || (numpad.Width == 1) || (numpad.Width == 0 && (numpad.Height == 1 || numpad.Height == 3)) || (numpad.Width == 3) || (numpad.Height == 2 && numpad.Width == 2))
                        {
                            ++numpad.Width;
                        }

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
