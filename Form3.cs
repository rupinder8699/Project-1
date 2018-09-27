using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form4()).Show();
            this.Hide();
            //the above is for directly going to the main playing page.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            (new Form2()).Show();
            this.Hide();
            //the above is for going backward page.
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this is just a demo button for player to learn the game. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this is just a demo button for player to learn the game. 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is just a demo button for player to learn the game. 
        }
    }
}
