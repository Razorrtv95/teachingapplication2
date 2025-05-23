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
    public partial class Form3 : Form
    {


        int i = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
 

        }

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form1 formmain = new Form1();
            formmain.Show();

        }

        private void button2_Click(object sender, EventArgs e) //Go Next
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
                    pictureBox.Image = Properties.Resources.undefined___Imgur;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources.undefined___Imgur__1_;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources.undefined___Imgur__2_;
                    break;
          
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
