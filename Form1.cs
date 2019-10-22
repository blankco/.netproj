using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool choice = true;
        string[] prizes = { "Singko", "Dos", "Tres","Shift","Uno" };
        int randomNumber;
        Random ranNumberGenerator = new Random();
        public Form1()
        {
            InitializeComponent();
            randomNumber = ranNumberGenerator.Next(0, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //the random number is assigned to this button
            if (choice)
            {
                //randomly assign prizes
                button1.Tag = randomNumber;
                if (randomNumber == 0)
                {
                    button2.Tag = 1;
                    button3.Tag = 2;
                    button4.Tag = 3;
                    button5.Tag = 4;

                }
                else if (randomNumber == 1)
                {
                    button2.Tag = 0;
                    button3.Tag = 2;
                    button4.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 2)
                {
                    button2.Tag = 0;
                    button3.Tag = 1;
                    button4.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 3)
                {
                    button2.Tag = 0;
                    button3.Tag = 1;
                    button4.Tag = 2;
                    button5.Tag = 4;
                }
                else
                {
                    button2.Tag = 0;
                    button3.Tag = 1;
                    button4.Tag = 2;
                    button5.Tag = 3;
                }

                if (Convert.ToInt32(button2.Tag) < Convert.ToInt32(button3.Tag))
                    textBox1.Text = "Door 2 has " + prizes[Convert.ToInt32(button2.Tag)] + ". You can change doors now!";
                else
                {
                    textBox1.Text = "Door 3 has " + prizes[Convert.ToInt32(button4.Tag)] + ". You can change doors now!";
                }
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you're grade is now " + prizes[Convert.ToInt32(button1.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (choice)
            {
                //randomly assign prizes
                button2.Tag = randomNumber;
                if (randomNumber == 0)
                {
                    button1.Tag = 1;
                    button3.Tag = 2;
                    button4.Tag = 3;
                    button5.Tag = 4;

                }
                else if (randomNumber == 1)
                {
                    button1.Tag = 0;
                    button3.Tag = 2;
                    button4.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 2)
                {
                    button1.Tag = 0;
                    button3.Tag = 1;
                    button4.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 3)
                {
                    button1.Tag = 0;
                    button3.Tag = 1;
                    button4.Tag = 2;
                    button5.Tag = 4;
                }
                else
                {
                    button1.Tag = 0;
                    button3.Tag = 1;
                    button4.Tag = 2;
                    button5.Tag = 3;
                }

                if (Convert.ToInt32(button1.Tag) < Convert.ToInt32(button3.Tag))
                    textBox1.Text = "Door 1 has " + prizes[Convert.ToInt32(button1.Tag)] + ". You can change doors now!";
                else
                    textBox1.Text = "Door 3 has " + prizes[Convert.ToInt32(button3.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button2.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (choice)
            {
                //randomly assign prizes
                button2.Tag = randomNumber;
                if (randomNumber == 0)
                {
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button4.Tag = 3;
                    button5.Tag = 4;

                }
                else if (randomNumber == 1)
                {
                    button1.Tag = 0;
                    button2.Tag = 2;
                    button4.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 2)
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button4.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 3)
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button4.Tag = 2;
                    button5.Tag = 4;
                }
                else
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button4.Tag = 2;
                    button5.Tag = 3;
                }
                if (Convert.ToInt32(button1.Tag) < Convert.ToInt32(button2.Tag))
                    textBox1.Text = "Door 1 has " + prizes[Convert.ToInt32(button1.Tag)] + ". You can change doors now!";
                else
                    textBox1.Text = "Door 2 has " + prizes[Convert.ToInt32(button2.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button3.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //the random number is assigned to this button
            if (choice)
            {
                //randomly assign prizes
                button4.Tag = randomNumber;
                if (randomNumber == 0)
                {
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button5.Tag = 4;

                }
                else if (randomNumber == 1)
                {
                    button1.Tag = 0;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 2)
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button3.Tag = 3;
                    button5.Tag = 4;
                }
                else if (randomNumber == 3)
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button3.Tag = 2;
                    button5.Tag = 4;
                }
                else
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button3.Tag = 2;
                    button5.Tag = 3;
                }

                if (Convert.ToInt32(button3.Tag) < Convert.ToInt32(button4.Tag))
                    textBox1.Text = "Door 3 has " + prizes[Convert.ToInt32(button2.Tag)] + ". You can change doors now!";
                else if (Convert.ToInt32(button4.Tag) < Convert.ToInt32(button5.Tag))
                    textBox1.Text = "Door 4 has " + prizes[Convert.ToInt32(button5.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button1.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //the random number is assigned to this button
            if (choice)
            {
                //randomly assign prizes
                button5.Tag = randomNumber;
                if (randomNumber == 0)
                {
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;

                }
                else if (randomNumber == 1)
                {
                    button1.Tag = 0;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                }
                else if (randomNumber == 2)
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button3.Tag = 3;
                    button4.Tag = 4;
                }
                else if (randomNumber == 3)
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button3.Tag = 2;
                    button4.Tag = 4;
                }
                else
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                    button3.Tag = 2;
                    button4.Tag = 3;
                }

                if (Convert.ToInt32(button3.Tag) < Convert.ToInt32(button4.Tag))
                    textBox1.Text = "Door 2 has " + prizes[Convert.ToInt32(button2.Tag)] + ". You can change doors now!";
                else if (Convert.ToInt32(button1.Tag) < Convert.ToInt32(button2.Tag))
                    textBox1.Text = "Door 5 has " + prizes[Convert.ToInt32(button5.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button1.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }

        }
    }
}
