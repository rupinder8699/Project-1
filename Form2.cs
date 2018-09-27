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

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            (new Form4()).Show();
            this.Hide();
            //the above is for directly going to the main playing page.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            name = textBox1.Text;
            (new Form3()).Show();
            this.Hide();
            //the above code is for a next page where player can read the the rules.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
