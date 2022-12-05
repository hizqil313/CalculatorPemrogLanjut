using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
            OperatorInit();
        }

        private void OperatorInit()
        {
            OperatorTxt.Items.Clear();
            OperatorTxt.Items.Add("Penjumlahan");
            OperatorTxt.Items.Add("Pengurangan");
            OperatorTxt.Items.Add("Perkalian");
            OperatorTxt.Items.Add("Pembagian");
            OperatorTxt.SelectedIndex = 0;
        }

        public delegate void Hasil(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil);

        public event Hasil prosesEvent;
        private void button1_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtAngka1.Text);
            int nilaiB = int.Parse(txtAngka2.Text);
            string operasi = "";
            string operasiLabel = "";
            float hasil = 0;
            switch (OperatorTxt.SelectedIndex)
            {
                // Penjumlahan
                case 0:
                    hasil = Operator.Penjumlahan(nilaiA, nilaiB);
                    operasiLabel = "Penjumlahan";
                    operasi = "+";
                    break;
                // Pengurangan
                case 1:
                    hasil = Operator.Pengurangan(nilaiA, nilaiB);
                    operasiLabel = "Pengurangan";
                    operasi = "-";
                    break;
                // Perkalian
                case 2:
                    hasil = Operator.Perkalian(nilaiA, nilaiB);
                    operasiLabel = "Perkalian";
                    operasi = "x";
                    break;
                // Pembagian
                case 3:
                    hasil = (float)Operator.Pembagian(nilaiA, nilaiB);
                    operasiLabel = "Pembagian";
                    operasi = "/";
                    break;

            }
            prosesEvent(nilaiA, nilaiB, operasi, operasiLabel, hasil);
        }
    }
}

