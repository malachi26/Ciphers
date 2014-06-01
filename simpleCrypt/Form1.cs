using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace simpleCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		ShiftCipher shiftCipher = new ShiftCipher ();


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Results.Text = shiftCipher.Decrypt(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Results.Text = shiftCipher.Encrypt(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }
    }
}
