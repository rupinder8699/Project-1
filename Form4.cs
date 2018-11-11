﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form4 : Form
    {
         int bload;
         int cspin;
          
        int b;



        public Form4()
        {
            InitializeComponent();
        }

        private void Fire_button_Click(object sender, EventArgs e)
        { 
            int bscroll=0;

            //the below code help to upload image in form.
            Image img = Image.FromFile(@"C:\Users\Rupinder Singh Com\source\repos\project 1\project 1\sources\images\empty.gif");

            pictureBox1.Image = img;

            //the below code help to upload sound in form.
            Sound Shotobj = new Sound();
            Shotobj.shot_sound();
          

            do
            {
                if (bscroll == 0 && bload == cspin)
                {
                  
                    //below codes helps to show the pop up message on the screen.
                    MessageBox.Show("you won and your score is 10");
                    bscroll = 3;
                    button4.Enabled = false;
                }
                else if (bscroll == 1 && bload == cspin)
                {
                    MessageBox.Show("you won and your score is 5");
                    bscroll = 3;
                    b = b - 1;

                }
                else if (bscroll == 2)
                {
                    MessageBox.Show("you loose");
                    bscroll = 3;
                    b = b - 1;

                }
                else
                {
                    bscroll++;

                    cspin = spin_fuc(cspin);
                }
            }
            while (bscroll <= 2);

            if (b == 0)
            {
                button3.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                b = 2;
            }


        }


        private void Form2_Load(object sender, EventArgs e)

        {
            textBox1.Text = Form2.name;
        }

        private void Load_button_Click(object sender, EventArgs e)
        {

            //the below code help to upload image in form.
            Image img = Image.FromFile(@"C:\Users\Rupinder Singh Com\source\repos\project 1\project 1\sources\images\giphy.gif");
            pictureBox1.Image = img;

            //the below code help to upload sound in form.
            Sound load = new Sound();
            load.load_sound();

            //the below load the bullet in revolver chamber.
            bload = 1;


            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void Gif_pictureBox_Click(object sender, EventArgs e)
        {
             //the above code is for picturebox  aplly on all three button.
        }

        private void Spin_Button_Click(object sender, EventArgs e)
        {
            //the below code help to upload image in form.
            Image img = Image.FromFile(@"C:\Users\Rupinder Singh Com\source\repos\project 1\project 1\sources\images\scroll.gif");

            pictureBox1.Image = img;
            //the below code help to upload sound in form.
            Sound spinobj = new Sound();
            spinobj.Spin_sound();
           
            //below code helps spin the bullet chamber. 
            Random rnd = new Random();
           
            cspin = rnd.Next(1, 6);
            //above code pick bullet from the chamber randomly.

            button3.Enabled = true;
            button2.Enabled = false;

        }

        public int spin_fuc(int c)
        {
            if (c == 6)
            {
                c = 1;
            }
            else
            {
                c++;
            }
            return c;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();

            Application.Exit();
        }


        private void Shootaway_button_Click(object sender, EventArgs e)
        {
            //below code is helps to start the game again from the same page.
            (new Form4()).Show();
            this.Hide();

        }

        private void PlayerName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payer_label_Click(object sender, EventArgs e)
        {
            //this label tool which helps to show the player name on the top left of the screen.
        }
    }
}
