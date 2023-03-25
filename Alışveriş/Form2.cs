using Alışveriş;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form3 frm3 = new Form3();
                this.Hide();
                frm3.Show();
            }
            if(radioButton2.Checked)
            {
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 250);
        }
    }
}
