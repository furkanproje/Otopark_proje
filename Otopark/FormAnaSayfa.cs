using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Formlar.frmMarka marka = new Formlar.frmMarka();
            marka.Show();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            Formlar.frmMarka marka = new Formlar.frmMarka();
            marka.Show();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void seriTool_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void btnMusteriilistele_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele frm = new Formlar.frmMusteriListele();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void btnOtoparkYerleri_Click(object sender, EventArgs e)
        {
            Formlar.frmOtoparkYerleri frm = new Formlar.frmOtoparkYerleri();
            frm.Show();
        }

        private void btnAracOtoparkGiriş_Click(object sender, EventArgs e)
        {
            Formlar.frmAracGiriş frm = new Formlar.frmAracGiriş();
            frm.Show();
        }

        private void btnOtoparkYerleri_Click_1(object sender, EventArgs e)
        {
            Formlar.frmOtoparkYerleri frm = new Formlar.frmOtoparkYerleri();
            frm.Show();
        }

        private void btnAracOtoparkCikisi_Click(object sender, EventArgs e)
        {
            Formlar.frmAracCikis frm = new Formlar.frmAracCikis();
            frm.Show();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele frm = new Formlar.frmMusteriListele();
            frm.Show();
        }

        private void araçOtoparkGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmAracGiriş frm = new Formlar.frmAracGiriş();
            frm.Show();
        }

        private void araçOtoparkÇıkışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmAracCikis frm = new Formlar.frmAracCikis();
            frm.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele frm = new Formlar.frmMusteriListele();
            frm.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Formlar.frmSatis frm = new Formlar.frmSatis();
            frm.Show();
        }
    }
}
