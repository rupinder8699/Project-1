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

        private void Fire_Detail_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Spin_Detail_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            (new Form4()).Show();
            this.Hide();
            //the above is for directly going to the main playing page.
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            
            (new Form2()).Show();
            this.Hide();
            //the above is for going backward page.
        }

        private void Header_label_Click(object sender, EventArgs e)
        {

        }

        private void Spin_button_Click(object sender, EventArgs e)
        {
            // this is just a demo button for player to learn the game. 
        }

        private void Fire_button_Click(object sender, EventArgs e)
        {
            // this is just a demo button for player to learn the game. 
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            // this is just a demo button for player to learn the game. 
        }

        private void Load_Detail_Lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
