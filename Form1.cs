using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Hallo {0}", nama);
            txtPesan2.Text = string.Format("Pendidkan Anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda Seorang {0}, Hebat", pekerjaaan);
        }
    }
}
