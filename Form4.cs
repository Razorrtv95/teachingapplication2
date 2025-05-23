using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {

        int i = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formmain = new Form1();
            formmain.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Go Next
        {
            i++;

            if (i > 3)
            {
                i = 1;
            }

            changeImage(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 3;
            }

            changeImage(i);
        }

        private void changeImage(int num)
        {

            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Aitutaki_Aireal_of_the_Island;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.intro_1702854506;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.images1;
                    break;

            }
        }
    }

 
}
