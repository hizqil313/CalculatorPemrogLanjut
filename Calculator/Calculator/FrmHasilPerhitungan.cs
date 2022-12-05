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
    public partial class FrmHasilPerhitungan : Form
    {
        public FrmHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void HasilHitung(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            listHasil.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCalculator frmEntry = new FrmCalculator();
            frmEntry.prosesEvent += HasilHitung;
            frmEntry.ShowDialog();
        }
    }
}
