using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using S1.Properties;

using System.Windows.Forms;

namespace S1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string EncryptText( short encryptionKey)
        {
            string text = textBox1.Text;
            char[] EncryptText = new  char [text.Length];

            for (int i = 0; i < EncryptText.Length; i++)
            {
                EncryptText[i] = Convert.ToChar(text[i] + encryptionKey);
            }

            return new string(EncryptText);
        }

        private string DecryptText( short encryptionKey)
        {
            string text = textBox3.Text;
            char[] DecryptionText = new char[text.Length];

            for (int i = 0; i < DecryptionText.Length; i++)
            {
                DecryptionText[i] = Convert.ToChar(text[i] - encryptionKey);
            }

            return new string(DecryptionText);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Byte DecryptionKey = 2;

            textBox4.Text = DecryptText(DecryptionKey);
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            Byte encryptionKey = 2;

            textBox2.Text = EncryptText(encryptionKey);
        }
    }
}
