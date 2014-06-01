using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayFairCipher
{
    public class baseDecoder
    {
        /// <ErrorWatch>
        ///     if you are having trouble with the letters not matching up
        ///     be aware that in the Remove Duplicates class we change the input string to 
        ///     uppercase,  I am not sure that the code written below is written for Uppercase
        /// </ErrorWatch>


        //create a multi-dimensional array of the 25 letters of the alphabet ( minus the letter I )
        private char[,] alpha = new char[5,5];
        public char[,] Alpha
        {
            get
            {
                int x = 65;
                for (int i = 0; i < 5; i++)
                {
                    
                    for (int j = 0; j < 5; j++)
                    {
                        if (x == 73)
                        {
                            x += 1;
                        }
                        //j is the row and i is the column
                        alpha[j, i] = Convert.ToChar(x);
                        x += 1;
                    }
                }
                return alpha;
            }
        }


        ///create the duplicate remover object to remove duplicates
        ///
        RemoveDuplicates rmvdbls = new RemoveDuplicates();



        //going to create an array to hold the letters of the alphabet to check against for duplicates and then
        //use this array to input into the multi-Dimensional array.
        private char[] alphabet = new char[25];
        public char[] Alphabet
        {
            get
            {
                char[] AlphaCode = null;
                int K = 0; //this Variable used for Indexing
                for (int i = 65; i < 91; i++)
                {
                    if (i == 73)
                    {
                        i++;
                    }
                    AlphaCode[K] = Convert.ToChar(i);
                    K++;
                }
                return AlphaCode;
            }   
        }
            
        /// <summary>
        /// this is for the Integer Array that represents the alphabet in a char array
        /// this could be used as a linked array with AlphaCode
        /// </summary>
        /// 
        private int[] alphaNUM;
            public int[] AlphaNUM
            {
                get
                {
                    //for StateMent here
                    ///going to change the char array into an integer array, so that I can manipulate 
                    ///the letters and stuff
                    ///

                    int K = 0;
                    for (int i = 65; i < 91; i++)
                    {
                        if (i == 73)
                        {
                            i++;
                        }
                        alphaNUM[K] = i;
                        K++;
                    }
                    return alphaNUM;
                }
            }

        ///going to try and Create a Method that works with alphabet and some input to create a new array of arrays
        ///to start the playfaire cipher
        ///
        public char[,] rebuildCipher(string inputString)
        {
            char[,] outputArray; // this will be the output of this method
            int[] alphabet1 = AlphaNUM; //my alphabet Array 
            

            inputString = rmvdbls.DuplicateRemover(inputString);


            for (int j = 0; j < inputString.Length; j++)
            {
                for (int i = 0; i < alphabet1.Length; i++)
                {
                    if (Convert.ToInt32(inputString[j]) == alphabet1[i])
                    {
                        alphabet1[i] = 0;  //we are going to set the alphabet at this index to 0 and replace later   
                        
                        ///<TODO> this area has an issue I am trying to replace the alphabet with 
                        ///         my keyword. so I am first getting rid of all the letters from the alphabet
                        ///         then I will try to shift the letters over and put the keyword out in front.
                        ///         I am thinking that I might have to change this from a char array into an integer array
                        ///         then I can use Nulls and all I have to do is Convert to Char when I go to Print out
                        ///         </TODO>
                        ///         


                    }
                }
            }

            ///this for loop will take out all the zeros and shift them to the left
            ///I think that I will have to reverse everything so that the shift will work and then 
            ///reverse the string again
            for (int i = 0; i < alphabet1.Length; i++)
            {

            }

            for (int i = 0; i < inputString.Length; i++)
            {
                //this part of the program will eventually input the key word into the alphabet
                //then you can

                    alphabet1[i] = inputString[i];
                
                
            }
        }


        /// <summary>
        /// reading in from a string and the array this will replace the the letters
        /// and take out the doubles and replace 'i' with 'j'
        /// </summary>
        /// <param name="inputarray">array of char's after the input</param>
        /// <param name="inputstring">keyphrase string</param>
        /// <returns></returns>
        public char[,] newAlpha(char[,] inputarray, string inputstring)
        {
            char[,] outputarray;
            for (int k=0;k<inputstring.Length;k++)
                //TODO: Fix this Dilema
            return outputarray;
        }
    }
}
