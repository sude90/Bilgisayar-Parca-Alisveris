using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Alışveriş
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemci: İnel Core i7 - Anakart: Gigabyte--Ekran Kartı: Sapphire - Sabit Disk: Hıkvısıon - PSU: Corsair - Kasa: Dark Guardian");
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form1 frm1 = new Form1();
             this.Hide();
             frm1.Show();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(780, 230);
            this.Location = new Point(450, 250);
        }
    }
}
