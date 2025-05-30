using Otopark.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark.Formlar
{
    public partial class frmAracGiriş : Form
    {
        public frmAracGiriş()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmAracGiriş_Load(object sender, EventArgs e)
        {
            var markagetir = db.TBLMarka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdı";
            comboMarka.ValueMember = "ID";
            ParkYerleriYenile();

        }

        private void ParkYerleriYenile()
        {
            var parkyerilist = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboPark.DataSource = parkyerilist;
            comboPark.DisplayMember = "ParkYerleri";
            comboPark.ValueMember = "ID";
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serilist = db.TBLSeri.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
                comboSeri.DataSource = serilist;
                comboSeri.DisplayMember = "seri";
                comboSeri.ValueMember = "ID";
            }
            catch (Exception)
            {


            }
        }

        private void comboMarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var serilist = db.TBLSeri.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
            comboSeri.DataSource = serilist;
            comboSeri.DisplayMember = "seri";
            comboSeri.ValueMember = "ID";
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var musterigetir = db.TBLMusteri.Where(x => x.ID.ToString() == txtMusteriID.Text).ToList();
                foreach (var item in musterigetir)
                {
                    txtAdSoyad.Text = item.AdSoyad;
                    txtTelefon.Text = item.Telefon;
                }
                if (txtMusteriID.Text == "")
                {
                    txtAdSoyad.Text = "";
                    txtTelefon.Text = "";
                }
            }
            catch (Exception)
            {

                
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ekle = new AracParkBilgileri();
            ekle.MusteriID = int.Parse(txtMusteriID.Text);
            ekle.AdSoyad = txtAdSoyad.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.MarkaID = (int)comboMarka.SelectedValue;
            ekle.SeriID = (int)comboSeri.SelectedValue;
            ekle.Plaka = txtPlaka.Text;
            ekle.Yİl = txtYıl.Text;
            ekle.Renk = txtRenk.Text;
            ekle.ParkYeriID = (int)comboPark.SelectedValue;
            ekle.Aciklama = txtAciklama.Text;
            ekle.GirisTarihi = DateTime.Now;
            db.TBLAracParkBilgileri.Add(ekle);
            db.SaveChanges();

            var parkyeridoldur = db.TBLAracParkYerleri.FirstOrDefault(x => x.ID ==(int)comboPark.SelectedValue);
            parkyeridoldur.Durumu = "DOLU";
            db.SaveChanges();
            MessageBox.Show("Kayıt işlemi Gerçekleşti","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ParkYerleriYenile();
            btnTemizle.PerformClick();
        }
    }
}
