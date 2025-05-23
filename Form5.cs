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
    public partial class Form5 : Form



    {


        int correctanswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form5()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private async void checkAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            Button clicked = sender as Button;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            disablebutton(); 


            if(buttonTag == correctanswer)
            {
                score++;

                clicked.BackColor = Color.Green; //for 3 seconds and then reset it

            }
            else
            {
                clicked.BackColor = Color.Red;


            }

            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100)/ totalQuestions);

                MessageBox.Show(

                    "QUIZ HAS ENDED!!" + Environment.NewLine + "" + Environment.NewLine + 
                    "You have answered " + score + " questions correctly." + Environment.NewLine + "" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine + "" + Environment.NewLine +
                    "Click OK to go on to the next game."


                );

                Form6 formmain = new Form6();
                formmain.Show();
                this.Hide();

            }

            await Task.Delay(3000);

           
            questionNumber++;
            askQuestion(questionNumber);
            resetbutton();

        }

        private void resetbutton()
        {
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void disablebutton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)

            {
                case 1:
                    pictureBox1.Image = Properties.Resources.coding_background_9izlympnd0ovmpli;

                    label2.Text = "What is a variable?";

                    button1.Text = "Something cool";
                    button2.Text = "A loop";
                    button3.Text = "A function";
                    button4.Text = "A box that stores information";

                    correctanswer = 4;



                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.trueorfalse;

                    label2.Text = "True or false? Conditional statements are: If...then...";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "Maybe";
                    button4.Text = "I don't know";

                    correctanswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.different_flavour_ice_cream_cone_ice_cream_cone_cartoon_art_illustration_vector;

                    label2.Text = "What is an example of a data type?";

                    button1.Text = "A cool saying.";
                    button2.Text = "Numbers";
                    button3.Text = "Fruits";
                    button4.Text = "Vegetables";

                    correctanswer = 2;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.trueorfalse;

                    label2.Text = "True or false? Conditional statements are: If...then...";

                    button1.Text = "False.";
                    button2.Text = "True";
                    button3.Text = "I don't know";
                    button4.Text = "Maybe";

                    correctanswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.runningg;

                    label2.Text = "What is something that causes the program to run?";

                    button1.Text = "Variables";
                    button2.Text = "Shoes";
                    button3.Text = "Loops";
                    button4.Text = "Events";

                    correctanswer = 4;

                    break;

            }

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 formmain = new Form2();
            formmain.Show();
        }
    }
}
