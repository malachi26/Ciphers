using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StringExtensions;

namespace simpleCrypt
{
	public class ShiftCipher
    {
		public string toUCase(string strIn)
        {
            strIn = strIn.ToUpper();
			return strIn;
        }
			
        public string Shift(string plainIn, int shift)
		{// 65=A 90=Z in ASCII
			int Z = (int)'Z';
			int A = (int)'A';

			string readOut=string.Empty;
            char[] charArray;


            int lengthofString = plainIn.Length;
            charArray = plainIn.ToCharArray();
            for (int i = 0; i < lengthofString; i++)
            {
				int Num = Convert.ToInt32(charArray[i]) + shift;
				readOut += Convert.ToChar(Num > Z ? Num -= (Z-A) : (Num < A ? Num += Z-A: Num));
			}
            return readOut;
        }

		public string Encrypt(string ReadIn, int shiftAmount)
        {
			//ReadIn = ReadIn.RemoveSpaces();
			//ReadIn = ReadIn.ReverseString()
			//ReadIn = toUCase(ReadIn);

			ReadIn = ReadIn.RemoveSpaces ().ReverseString ().ToUpper();
			ReadIn = Shift(ReadIn, shiftAmount);
            return ReadIn;
        }

        //here I am going to try and create a method that will do the complete opposite
        // of what I just did with the Encrypt Method
        // there doesn't seem to be a good way to put the spaces back in so I am going to leave
        // the spaces in there, and I am going to leave the sentence in uppercase as well

		public string Decrypt(string readIn, int shiftAmount)
        {
			return Shift(readIn.ReverseString(), -shiftAmount);

        }       
    }
}
