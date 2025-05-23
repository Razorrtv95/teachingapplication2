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
    public partial class Form2 : Form

    {

        int i = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formmain = new Form1();
            formmain.Show();
        }

        private void button1_Click(object sender, EventArgs e) //GoNext
        {
            i++;

            if(i > 6)
            {
                i = 1;
            }

            changeImage(i);
        }

        private void button2_Click(object sender, EventArgs e) //GoBack
        {
            i--;

            if (i < 1)
            {
                i = 6;
            }

            changeImage(i);
        }

        private void changeImage(int num)
        {
             
            switch(num)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources._6;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }

     
    }
   
}


