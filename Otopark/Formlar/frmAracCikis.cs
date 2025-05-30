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
    public partial class frmAracCikis : Form
    {
        public frmAracCikis()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();

        private void frmAracCikis_Load(object sender, EventArgs e)
        {
            comboSaatUcreti.SelectedIndex = 0;

           
            
            Yenile();
            var markagetir = db.TBLMarka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdı";
            comboMarka.ValueMember = "ID";
        }

        private void Yenile()
        {
            comboPlakaAra.Text = "";
            comboPlakaAra.Items.Clear();
            var plakagetir = db.TBLAracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                comboPlakaAra.Items.Add(item.Plaka);
            }
            var bosparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = bosparkyerleri;
            comboParkYeri.DisplayMember = "ParkYerleri";
            comboParkYeri.ValueMember = "ID";

            var doluparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();
            comboParkYeriAra.DataSource = doluparkyerleri;
            comboParkYeriAra.DisplayMember = "ParkYerleri";
            comboParkYeriAra.ValueMember = "ID";
            comboParkYeriAra.Text = "";
            comboParkYeri.Text = "";

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
                comboSeri.DataSource = serigetir;
                comboSeri.DisplayMember = "seri";
                comboSeri.ValueMember = "ID";
            }
            catch (Exception)
            {


            }
        }

        private void comboMarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
            comboSeri.DataSource = serigetir;
            comboSeri.DisplayMember = "seri";
            comboSeri.ValueMember = "ID";
        }
        void UcretHesapla() 
        {
            try
            {
                lblCikisTarihi.Text = DateTime.Now.ToString();
                TimeSpan fark;
                fark = DateTime.Parse(lblCikisTarihi.Text) - DateTime.Parse(lblgiristarihi.Text);
                decimal saatucreti = 0, sure = 0, tutar=0;
                lblsure.Text = fark.TotalHours.ToString("0.00");
                saatucreti = Convert.ToDecimal(comboSaatUcreti.Text);
                sure = Convert.ToDecimal(lblsure.Text);
                tutar = sure * saatucreti;
                lbltutar.Text = tutar.ToString("0.00");
            }
            catch (Exception)
            {

                
            }
        }
        private void ttxtIDAra_TextChanged(object sender, EventArgs e)
        {
            if (txtIDAra.Text == "")
            {
                foreach (Control item in panelBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            var IDAra = (from x in db.TBLAracParkBilgileri
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdSoyad,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.GirisTarihi,
                             y.MarkaAdı,
                             z.seri,
                             t.ParkYerleri
                         }).Where(ara => ara.ID.ToString() == txtIDAra.Text).ToList();
            foreach (var item in IDAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdSoyad;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdı;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }

        }

        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            if (txtMusteriIDAra.Text == "")
            {
                foreach (Control item in panelBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            var MusteriIDAra = (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on
                             x.MarkaID equals y.ID
                                join z in db.TBLSeri on
                             x.SeriID equals z.ID
                                join t in db.TBLAracParkYerleri on
                             x.ParkYeriID equals t.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdSoyad,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdı,
                                    z.seri,
                                    t.ParkYerleri
                                }).Where(ara => ara.MusteriID.ToString() == txtMusteriIDAra.Text).ToList();
            foreach (var item in MusteriIDAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdSoyad;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdı;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                 lblgiristarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }

        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAdSoyadAra.Text == "")
            {
                foreach (Control item in panelBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            var AdSoyadAra = (from x in db.TBLAracParkBilgileri
                              join y in db.TBLMarka on
                           x.MarkaID equals y.ID
                              join z in db.TBLSeri on
                           x.SeriID equals z.ID
                              join t in db.TBLAracParkYerleri on
                           x.ParkYeriID equals t.ID
                              select new
                              {
                                  x.ID,
                                  x.MusteriID,
                                  x.AdSoyad,
                                  x.Telefon,
                                  x.Plaka,
                                  x.Renk,
                                  x.Aciklama,
                                  x.GirisTarihi,
                                  y.MarkaAdı,
                                  z.seri,
                                  t.ParkYerleri
                              }).Where(ara => ara.AdSoyad.ToString() == txtAdSoyadAra.Text).ToList();
            foreach (var item in AdSoyadAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdSoyad;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdı;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                 lblgiristarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
        }

        private void comboPlakaAra_SelectedIndexChanged(object sender, EventArgs e)
        {


            var PlakaAra = (from x in db.TBLAracParkBilgileri
                            join y in db.TBLMarka on
                         x.MarkaID equals y.ID
                            join z in db.TBLSeri on
                         x.SeriID equals z.ID
                            join t in db.TBLAracParkYerleri on
                         x.ParkYeriID equals t.ID
                            select new
                            {
                                x.ID,
                                x.MusteriID,
                                x.AdSoyad,
                                x.Telefon,
                                x.Plaka,
                                x.Renk,
                                x.Aciklama,
                                x.GirisTarihi,
                                y.MarkaAdı,
                                z.seri,
                                t.ParkYerleri
                            }).Where(ara => ara.Plaka.ToString() == comboPlakaAra.Text).ToList();
            foreach (var item in PlakaAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdSoyad;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdı;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
        }

        private void comboParkYeriAra_SelectedIndexChanged(object sender, EventArgs e)
        {


            var ParkYeriAra = (from x in db.TBLAracParkBilgileri
                               join y in db.TBLMarka on
                            x.MarkaID equals y.ID
                               join z in db.TBLSeri on
                            x.SeriID equals z.ID
                               join t in db.TBLAracParkYerleri on
                            x.ParkYeriID equals t.ID
                               select new
                               {
                                   x.ID,
                                   x.MusteriID,
                                   x.AdSoyad,
                                   x.Telefon,
                                   x.Plaka,
                                   x.Renk,
                                   x.Aciklama,
                                   x.GirisTarihi,
                                   y.MarkaAdı,
                                   z.seri,
                                   t.ParkYerleri
                               }).Where(ara => ara.ParkYerleri.ToString() == comboParkYeriAra.Text).ToList();
            foreach (var item in ParkYeriAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdSoyad;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdı;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
        }

        private void comboPlakaAra_TextChanged(object sender, EventArgs e)
        {
            if (comboPlakaAra.Text == "")
            {
                foreach (Control item in panelBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void comboParkYeriAra_TextChanged(object sender, EventArgs e)
        {
            if (comboParkYeriAra.Text == "")
            {
                foreach (Control item in panelBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var DoluParkYeriDegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeriAra.Text);
            DoluParkYeriDegistir.Durumu = "BOŞ";
            db.SaveChanges();
            var BosParkYeriDegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeri.Text);
            BosParkYeriDegistir.Durumu = "DOLU";
            db.SaveChanges();
            var aracparkdegistir = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka.ToString() == txtPlaka.Text);
            aracparkdegistir.ParkYeriID = (int)comboParkYeri.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Araç Park Yeri Degişti", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Yenile();
            btnTemizle.PerformClick();
            lblsure.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgiristarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in panelArama.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in panelBilgi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item != comboSaatUcreti)
                {

                }
            }
            lblsure.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgiristarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayıtSil();
            MessageBox.Show("Araç Park Yeri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboParkYeriAra.Items.Clear();
            Yenile();
            btnTemizle.PerformClick();
            lblsure.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgiristarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void KayıtSil()
        {
            var sil = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka == txtPlaka.Text);
            db.TBLAracParkBilgileri.Remove(sil);
            db.SaveChanges();

            var aracparkyeribosalt = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeri.Text);
            aracparkyeribosalt.Durumu = "BOŞ";
            db.SaveChanges();
        }

        private void btnAracCikis_Click(object sender, EventArgs e)
        {
            if (comboParkYeriAra.Text != "")
            {
                var ekle = new Satis();
                ekle.SatisID = Convert.ToInt32(txtID.Text);
                ekle.MusteriID = Convert.ToInt32(txtMusteriID.Text);
                ekle.AdSoyad = txtAdSoyad.Text;
                ekle.Telefon = txtTelefon.Text;
                ekle.MarkaID = (int)comboMarka.SelectedValue;
                ekle.SeriID = (int)comboSeri.SelectedValue;
                ekle.Plaka = txtPlaka.Text;
                ekle.Renk = txtRenk.Text;
                ekle.ParkYeriID = (int)comboParkYeriAra.SelectedValue;
                ekle.Aciklama = txtAciklama.Text;
                ekle.SaatUcretı = Convert.ToDecimal(comboSaatUcreti.Text);
                ekle.Sure = Convert.ToDecimal(lblsure.Text);
                ekle.Tutar = Convert.ToDecimal(lbltutar.Text);
                ekle.GirisTarihi = DateTime.Parse(lblgiristarihi.Text);
                ekle.CikisTarihi = DateTime.Parse(lblCikisTarihi.Text);
                db.TBLSatis.Add(ekle);
                db.SaveChanges();
                MessageBox.Show("Araç Çıkışı Yapıldı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KayıtSil();
                Yenile();
                btnTemizle.PerformClick();
                
                lblsure.Text = "0.00";
                lbltutar.Text = "0.00";
                lblgiristarihi.Text = DateTime.Now.ToString();
                lblCikisTarihi.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Dolu Park Yerinin Seçilmesi Gerekir","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.TBLAracParkBilgileri.FirstOrDefault(x => x.ID.ToString() == txtID.Text);
            guncelle.MarkaID = (int)comboMarka.SelectedValue;
            guncelle.SeriID = (int)comboSeri.SelectedValue;
            guncelle.Plaka = txtPlaka.Text;
            guncelle.Renk = txtRenk.Text;
            guncelle.Aciklama = txtAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Park Bilgileri Güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Yenile();
            btnTemizle.PerformClick();
            lblsure.Text = "0.00";
            lbltutar.Text = "0.00";
            lblgiristarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();

        }

        private void comboSaatUcreti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void panelArama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
