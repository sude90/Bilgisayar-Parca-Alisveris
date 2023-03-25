using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş
{
    public partial class Form1 : Form
    {
        int toplamTutar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(230, 150);
        }


        public void btnHesapla_Click_1(object sender, EventArgs e)
        {
            label1.Text = ("Toplam Tutar: " + toplamTutar.ToString());
        }

        private void btnIslemci_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[5];
            fiyatlar[0] = 600;
            fiyatlar[1] = 500;
            fiyatlar[2] = 400;
            fiyatlar[3] = 300;
            fiyatlar[4] = 200;

            if (rbCpul7.Checked)
            {
                SEPETİM.Items.Add("İntel Core i7");
                toplamTutar += fiyatlar[0];
            }
            else if (rbCpul5.Checked)
            {
                SEPETİM.Items.Add("İntel Core i5");
                toplamTutar += fiyatlar[1];
            }
            else if (rbCpul3.Checked)
            {
                SEPETİM.Items.Add("İntel Core i3");
                toplamTutar += fiyatlar[2];
            }
            else if (rbCpulR5.Checked)
            {
                SEPETİM.Items.Add("AMD Ryzen 5");
                toplamTutar += fiyatlar[3];
            }
            else if (rbCpulR3.Checked)
            {
                SEPETİM.Items.Add("AMD Ryzen 3");
                toplamTutar += fiyatlar[4];
            }
        }

        private void btnIslemciSil_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[5];
            fiyatlar[0] = 600;
            fiyatlar[1] = 500;
            fiyatlar[2] = 400;
            fiyatlar[3] = 300;
            fiyatlar[4] = 200;

            if (rbCpul7.Checked)
            {
                SEPETİM.Items.Remove("İntel Core i7");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbCpul5.Checked)
            {
                SEPETİM.Items.Remove("İntel Core i5");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbCpul3.Checked)
            {
                SEPETİM.Items.Remove("İntel Core i3");
                toplamTutar -= fiyatlar[2];
            }
            else if (rbCpulR5.Checked)
            {
                SEPETİM.Items.Remove("AMD Ryzen 5");
                toplamTutar -= fiyatlar[3];
            }
            else if (rbCpulR3.Checked)
            {
                SEPETİM.Items.Remove("AMD Ryzen 3");
                toplamTutar -= fiyatlar[4];
            }
        }

        private void btnAnakart_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 600;
            fiyatlar[1] = 500;
            fiyatlar[2] = 400;
           
            if (rbGİGABYTE.Checked)
            {
                SEPETİM.Items.Add("Gigabyte (Anakart)");
                toplamTutar += fiyatlar[0];
            }
            else if (rbTURBOX.Checked)
            {
                SEPETİM.Items.Add("Turbox (Anakart)");
                toplamTutar += fiyatlar[1];
            }
            else if (rbMSI.Checked)
            {
                SEPETİM.Items.Add("MSI (Anakart)");
                toplamTutar += fiyatlar[2];
            }
        }

        private void btnAnakartSil_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 600;
            fiyatlar[1] = 500;
            fiyatlar[2] = 400;

            if (rbGİGABYTE.Checked)
            {
                SEPETİM.Items.Remove("Gigabyte (Anakart)");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbTURBOX.Checked)
            {
                SEPETİM.Items.Remove("Turbox (Anakart)");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbMSI.Checked)
            {
                SEPETİM.Items.Remove("MSI (Anakart)");
                toplamTutar -= fiyatlar[2];
            }
        }

        private void btnEkrankartı_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 600;
            fiyatlar[1] = 500;
            fiyatlar[2] = 400;

            if (rbGALAX.Checked)
            {
                SEPETİM.Items.Add("Galax (Ekran Kartı)");
                toplamTutar += fiyatlar[0];
            }
            else if (rbTURBOX.Checked)
            {
                SEPETİM.Items.Add("Turbox (Ekran Kartı)");
                toplamTutar += fiyatlar[1];
            }
            else if (rbSAPPHİRE.Checked)
            {
                SEPETİM.Items.Add("Sapphire (Ekran Kartı)");
                toplamTutar += fiyatlar[2];
            }
        }

        private void btnEkranKartıÇıkar_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 600;
            fiyatlar[1] = 500;
            fiyatlar[2] = 400;

            if (rbGALAX.Checked)
            {
                SEPETİM.Items.Remove("Galax (Ekran Kartı)");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbTURBOX.Checked)
            {
                SEPETİM.Items.Remove("Turbox (Ekran Kartı)");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbSAPPHİRE.Checked)
            {
                SEPETİM.Items.Remove("Sapphire (Ekran Kartı)");
                toplamTutar -= fiyatlar[2];
            }
        }
        private void btnRam_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 500;
            fiyatlar[1] = 400;
            fiyatlar[2] = 300;

            if (rbRam16.Checked )
            {
                SEPETİM.Items.Add("16 GB Ram");
                toplamTutar += fiyatlar[0];
            }
            else if (rbRam8.Checked)
            {
                SEPETİM.Items.Add("8 GB Ram");
                toplamTutar += fiyatlar[1];
            }
            else if (rbRam4.Checked)
            {
                SEPETİM.Items.Add("4 GB Ram");
                toplamTutar += fiyatlar[2];
            }
        }

        private void btnRamSil_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 500;
            fiyatlar[1] = 400;
            fiyatlar[2] = 300;

            if (rbRam16.Checked)
            {
                SEPETİM.Items.Remove("16 GB Ram");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbRam8.Checked)
            {
                SEPETİM.Items.Remove("8 GB Ram");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbRam4.Checked)
            {
                SEPETİM.Items.Remove("4 GB Ram");
                toplamTutar -= fiyatlar[2];
            }
        }

        private void btnSabitDisk_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 800;
            fiyatlar[1] = 700;
            fiyatlar[2] = 600;

            if (rbHIKVISION.Checked)
            {
                SEPETİM.Items.Add("Hıkvısıon (SSD)");
                toplamTutar += fiyatlar[0];
            }
            else if(rbINTENSO.Checked)
            {
                SEPETİM.Items.Add("Intenso (SSD)");
                toplamTutar += fiyatlar[1];
            }
            else if (rbKINGSTON.Checked)
            {
                SEPETİM.Items.Add("Kingston (SSD)");
                toplamTutar += fiyatlar[2];
            }
        }

        private void btnSabitDiskSil_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 800;
            fiyatlar[1] = 700;
            fiyatlar[2] = 600;

            if (rbHIKVISION.Checked)
            {
                SEPETİM.Items.Remove("Hıkvısıon (SSD)");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbINTENSO.Checked)
            {
                SEPETİM.Items.Remove("Intenso (SSD)");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbKINGSTON.Checked)
            {
                SEPETİM.Items.Remove("Kingston (SSD)");
                toplamTutar -= fiyatlar[2];
            }
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 800;
            fiyatlar[1] = 700;
            fiyatlar[2] = 600;

            if (rbCORSAIRPSU.Checked)
            {
                SEPETİM.Items.Add("Corsair (PSU)");
                toplamTutar += fiyatlar[0];
            }
            else if (rbFRISBY.Checked)
            {
                SEPETİM.Items.Add("Frisby (PSU)");
                toplamTutar += fiyatlar[1];
            }
            else if (rbHADRON.Checked)
            {
                SEPETİM.Items.Add("Hadron (PSU)");
                toplamTutar += fiyatlar[2];
            }
        }

        private void btnPSUSil_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 800;
            fiyatlar[1] = 700;
            fiyatlar[2] = 600;

            if (rbCORSAIRPSU.Checked)
            {
                SEPETİM.Items.Remove("Corsair (PSU)");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbFRISBY.Checked)
            {
                SEPETİM.Items.Remove("Frisby (PSU)");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbHADRON.Checked)
            {
                SEPETİM.Items.Remove("Hadron (PSU)");
                toplamTutar -= fiyatlar[2];
            }
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 900;
            fiyatlar[1] = 800;
            fiyatlar[2] = 700;

            if (rbDARKGUARDİAN.Checked)
            {
                SEPETİM.Items.Add("Dark Guardian (Kasa)");
                toplamTutar += fiyatlar[0];
            }
            else if (rbCOUGAR.Checked)
            {
                SEPETİM.Items.Add("Cougar (Kasa)");
                toplamTutar += fiyatlar[1];
            }
            else if (rbCORSAIR.Checked)
            {
                SEPETİM.Items.Add("Corsaır (Kasa)");
                toplamTutar += fiyatlar[2];
            }
        }

        private void btnKasaSil_Click(object sender, EventArgs e)
        {
            int[] fiyatlar = new int[3];
            fiyatlar[0] = 900;
            fiyatlar[1] = 800;
            fiyatlar[2] = 700;

            if (rbDARKGUARDİAN.Checked)
            {
                SEPETİM.Items.Remove("Dark Guardian (Kasa)");
                toplamTutar -= fiyatlar[0];
            }
            else if (rbCOUGAR.Checked)
            {
                SEPETİM.Items.Remove("Cougar (Kasa)");
                toplamTutar -= fiyatlar[1];
            }
            else if (rbCORSAIR.Checked)
            {
                SEPETİM.Items.Remove("Corsaır (Kasa)");
                toplamTutar -= fiyatlar[2];
            }
        }
    }
}
