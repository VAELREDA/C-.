using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VİZE_FİNAL_PROGRAMI._
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float Vize;
        float Final;
        float Ort;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butHesapla_Click(object sender, EventArgs e)
        {
            Vize = float.Parse(textVize.Text);
            Final = float.Parse(textFinal.Text);
            Ort = (Vize*40)/100 + (Final * 60)/100;
            lblOrt.Text= Ort.ToString();
            /* 90-100 AA
            * 85-89 BA
            * 75-84 BB
            * 70-74 CB
            * 60-69 CC
            * 55-59 DC
            * 50-54 DD
            * 40-49 FD
            * 0-39 FF */
            if (Ort >= 90 && Ort <= 100) lblHarf.Text ="AA";
            if (Ort >= 85 && Ort < 90) lblHarf.Text = "BA";
            if (Ort >= 75 && Ort < 85) lblHarf.Text = "BB";
            if (Ort >= 70 && Ort < 75) lblHarf.Text = "CB";
            if (Ort >= 60 && Ort < 70) lblHarf.Text = "CC";
            if (Ort >= 55 && Ort < 60) lblHarf.Text = "DC";
            if (Ort >= 50 && Ort < 55) lblHarf.Text = "DD";
            if (Ort >= 40 && Ort < 50) lblHarf.Text = "FD";
            if (Ort >= 0 && Ort < 40) lblHarf.Text = "FF";
                
        }
        
    }
}


