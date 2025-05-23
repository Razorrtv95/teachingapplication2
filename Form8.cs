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
    public partial class Form8 : Form
    {

        PictureBox[] pictures = new PictureBox[4];

        List<String> blocks = new List<string>();

        public Form8()
        {
            InitializeComponent();

            //The 4 here is dependant on how many rows in the table            

            for (int i = 0; i < 4; i++)

            {

                pictures[i] = new PictureBox();

                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;

                pictures[i].AllowDrop = true;

                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);

                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);

                tblCodeArea.Controls.Add(pictures[i]);

            }
        }


        private void codeBlock_MouseDown(object sender, MouseEventArgs e)

        {

            //Defines sender as a picturebox so we can use it

            PictureBox codeBlock = sender as PictureBox;



            //Define a data object and store the image and the tag

            DataObject dragImage = new DataObject();

            dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);

            dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);



            //Copies the data object as we drag

            DoDragDrop(dragImage, DragDropEffects.Copy);

        }

        private void pictures_DragEnter(object sender, DragEventArgs e)

        {

            e.Effect = e.AllowedEffect;

        }

        private void pictures_DragDrop(object sender, DragEventArgs e)

        {

            PictureBox picture = sender as PictureBox;



            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            picture.Tag = e.Data.GetData(TextDataFormat.Text.ToString());



            lblList.Text = "";

            blocks.Clear();



            for (int i = 0; i < 4; i++)

            {

                blocks.Add(String.Format("{0}", pictures[i].Tag));

                if (blocks[i].Contains("For"))

                {

                    lblList.Text += "Initiate a For Loop here\n";

                }
                else if (blocks[i].Contains("When"))

                {

                    lblList.Text += "Handle a Click Event here\n";

                }

            }

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

    }
}
