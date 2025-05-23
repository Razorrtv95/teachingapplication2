using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {

        //Size holds how big our table is, x y holds our player position 

        int size = 3;

        int x = 0;

        int y = 2;



        //Generating a 2D array of picture boxes

        PictureBox[,] pictures = new PictureBox[3, 3];



        //Picture resources to simplify use later

        string picCheck = Directory.GetCurrentDirectory() + "/resources/fa29d32e85cbc1c6e5277b1917fbeec5.jpg";


        string picHand = Directory.GetCurrentDirectory() + "/resources/boy.jpg";
        public Form7()
        {
            InitializeComponent();

            //Loop for rows

            for (int i = 0; i < size; i++)

            {

                //Loop for columns

                for (int j = 0; j < size; j++)

                {

                    //Set up our picturebox to have a check mark

                    pictures[i, j] = new PictureBox();

                    pictures[i, j].Image = Image.FromFile(picCheck);

                    pictures[i, j].SizeMode = PictureBoxSizeMode.StretchImage;



                    //Add the picturebox to our table

                    tableLayoutPanel1.Controls.Add(pictures[i, j]);

                }

            }

            //Starting position of our hand

            pictures[y, x].Image = Image.FromFile(picHand);
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
