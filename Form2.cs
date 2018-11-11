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
    public partial class Form2 : Form
    {
        public static string name;

        public Form2()
        {
            InitializeComponent();
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            (new Form4()).Show();
            this.Hide();
            //the above is for directly going to the main playing page.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rules__button_Click(object sender, EventArgs e)
        {
            
            name = textBox1.Text;
            (new Form3()).Show();
            this.Hide();
            //the above code is for a next page where player can read the the rules.
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void Name_label_Click(object sender, EventArgs e)
        {

        }

        private void Age_label_Click(object sender, EventArgs e)
        {

        }

        private void Gender_label_Click(object sender, EventArgs e)
        {

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Male_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Female_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
