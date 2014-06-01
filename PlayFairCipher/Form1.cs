using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayFairCipher
{
    public partial class Form1 : Form
    {
        //declarations for the playfaire cipher
        public string KeyPhrase;
        baseDecoder template = new baseDecoder();
        public char[,] Decoder;
        RemoveDuplicates noDoubles = new RemoveDuplicates();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decoder = template.Alpha; //the base for the Decoder
            KeyPhrase = txtKeyPhrase.Text; //the Keyphrase read in form the form

            #region setting up the KeyWord
            
            int lengthofkey = txtKeyPhrase.Text.Length;
            KeyPhrase = noDoubles.DuplicateRemover(KeyPhrase);

            textBox1.Text = noDoubles.DuplicateRemover(KeyPhrase);

           //replacing the letters in the decoder with letters from the keyphrase
            int ii = 0, jj = 0;
            foreach (char k in KeyPhrase)
            {
                Decoder[ii, jj] = k;
                ii++;
                if (ii == 5)
                {
                    jj++;
                    ii = 0;
                }

            }



            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < lengthofkey; k++) //k will be the variable for my length of keyphrase
                    {
                        Decoder[j, i] = keyphrase[k];
                    }
                }
            }
            */
            #endregion


            //setting the template for the decoder
            #region Writing out to the Rich TextBox
            for (int i = 0; i < 5; i++)
            {
                string line = "";
                for (int j = 0; j < 5; j++)
                {
                    //line += " " + Decoder[j,i] + " ";
                    line += string.Format("{0,4}", Decoder[j, i]);
                }

                rtbOutput.Text += line;
                rtbOutput.Text += "\n";
            }
            #endregion

            
        }
    }
}
