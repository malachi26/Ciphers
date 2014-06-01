using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayFairCipher
{
    class RemoveDuplicates
    {
        public string DuplicateRemover(string stringIn)
        {

            string stringOut = "";
            stringIn = stringIn.Replace(" ", "");
            stringIn = stringIn.ToUpper();
            string newString = stringIn;



            for (int i = 0; i < stringIn.Length; i++)
            {
                int g = 0;
                for (int j = 0; j < stringIn.Length; j++)
                {
                    if (stringIn[i]==newString[j])
                    {
                        g++;
                    }

                }
                //if there is more than one match of the same letter it won't hit this code
                //there will always be at least one match to the letter because of the way I coded the program
                if (g < 2)
                {
                    stringOut += stringIn[i];
                }

            }


            //for (int x=0;x<stringIn.Length;x++)
            //{
            //    for (int i = x+1; i < stringIn.Length; i++)
            //    {
            //        if (stringIn[x] == newString[i])
            //        {
            //            stringOut += "";
            //            indexOut++;
            //            break;   
            //        }
            //    }

            //    stringOut += stringIn[x];
            //}

            return stringOut;
        }
    }
}