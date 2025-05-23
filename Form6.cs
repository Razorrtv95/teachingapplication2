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
    public partial class Form6 : Form
    {

        string[] words = {
            "A Boolean value is either true or __________",
            "Data types are _______, strings and boolean values",
            "A __________ is used to store stuff in programing",
            "The function stores _____", 
            "A conditional is an if...________...",

        };



        Random rmd = new Random();
      
        int correct = 0;
        int incorrect = 0;

        

        public Form6()
        {
            InitializeComponent();

            label3.Text = words[rmd.Next(0, words.Length)];

            label3.AutoSize = false;
            label3.Dock = DockStyle.Top;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Padding = new Padding(10);
            label3.Height = 50;
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkGame(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)


            {

                string input = textBox1.Text.Trim().ToLower();
                string target = label3.Text.Trim().ToLower();


                if (label3.Text == words[0])
                {
                    string correctAnswer = "false";

                    if (input == correctAnswer)
                    {
                        correct++;
                        label5.Text = "Correct";
                        label5.ForeColor = Color.Green;

                    }
                    else
                    {
                        incorrect++;
                        label5.Text = "Incorrect";
                        label5.ForeColor = Color.DarkRed;


                    }

                    label3.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;

                    label1.Text = "Incorrect: " + incorrect;
                    label2.Text = "Correct: " + correct;

                }
                else if (label3.Text == words[1])
                {
                    string correctAnswer1 = "numbers";

                    if (input == correctAnswer1)
                    {
                        correct++;
                        label5.Text = "Correct";
                        label5.ForeColor = Color.Green;

                    }
                    else
                    {
                        incorrect++;
                        label5.Text = "Incorrect";
                        label5.ForeColor = Color.DarkRed;


                    }

                    label3.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;

                    label1.Text = "Incorrect: " + incorrect;
                    label2.Text = "Correct: " + correct;

                }

                else if (label3.Text == words[2])
                {
                    string correctAnswer2 = "variable";

                    if (input == correctAnswer2)
                    {
                        correct++;
                        label5.Text = "Correct";
                        label5.ForeColor = Color.Green;

                    }
                    else
                    {
                        incorrect++;
                        label5.Text = "Incorrect";
                        label5.ForeColor = Color.DarkRed;


                    }

                    label3.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;

                    label1.Text = "Incorrect: " + incorrect;
                    label2.Text = "Correct: " + correct;

                }

                else if (label3.Text == words[3])
                {
                    string correctAnswer3 = "code";

                    if (input == correctAnswer3)
                    {
                        correct++;
                        label5.Text = "Correct";
                        label5.ForeColor = Color.Green;

                    }
                    else
                    {
                        incorrect++;
                        label5.Text = "Incorrect";
                        label5.ForeColor = Color.DarkRed;


                    }

                    label3.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;

                    label1.Text = "Incorrect: " + incorrect;
                    label2.Text = "Correct: " + correct;

                }

                else
                {
                    string correctAnswer4 ="then";

                    if (input == correctAnswer4)
                    {
                        correct++;
                        label5.Text = "Correct";
                        label5.ForeColor = Color.Green;
                  
                    }
                    else
                    {
                        incorrect++;
                        label5.Text = "Incorrect";
                        label5.ForeColor = Color.DarkRed;

                    }

                    label3.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;
                    label1.Text = "Incorrect: " + incorrect;
                    label2.Text = "Correct: " + correct;
                }

                if (incorrect == 5)
                {
                    MessageBox.Show(

                   "QUIZ HAS ENDED!!" + Environment.NewLine + "" + Environment.NewLine +
                   "You answered 5 questions incorrectly." + Environment.NewLine + "" + Environment.NewLine +
                   "CLICK OK to try again without failing." 


                 );

                    Form6 formmain = new Form6();
                    formmain.Show();
                    this.Hide();
              

                }

                if (correct == 8)
                {
                    MessageBox.Show(

                   "QUIZ HAS ENDED!!" + Environment.NewLine + "" + Environment.NewLine +
                   "You have passed." + Environment.NewLine + "" + Environment.NewLine +
                   "Thanks so much for playing."


                 );

                    Form1 formmain = new Form1();
                    formmain.Show();
                    this.Hide();

                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
