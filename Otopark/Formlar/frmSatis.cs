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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmSatis_Load(object sender, EventArgs e)
        {
            TumKayitlar();

        }

        private void TumKayitlar()
        {
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                            // x.SatisID,
                             x.MusteriID,
                             x.AdSoyad,
                             t.ParkYerleri,
                             x.Telefon,
                             y.MarkaAdı,
                             z.seri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcretı,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).ToList();
            dataGridView1.DataSource = liste;
            

        }

        private void txtIDAra_TextChanged(object sender, EventArgs e)
        {
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdSoyad,
                             t.ParkYerleri,
                             x.Telefon,
                             y.MarkaAdı,
                             z.seri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcretı,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.ID.ToString() == txtIDAra.Text).ToList();
            dataGridView1.DataSource = liste;
            if (txtIDAra.Text == "")
            {
                TumKayitlar();
            }
        }

        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdSoyad,
                             t.ParkYerleri,
                             x.Telefon,
                             y.MarkaAdı,
                             z.seri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcretı,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.MusteriID.ToString() == txtMusteriIDAra.Text).ToList();
            dataGridView1.DataSource = liste;
            if (txtIDAra.Text == "")
            {
                TumKayitlar();
            }
        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdSoyad,
                             t.ParkYerleri,
                             x.Telefon,
                             y.MarkaAdı,
                             z.seri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcretı,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.AdSoyad.Contains(txtAdSoyadAra.Text)).ToString();
            dataGridView1.DataSource = liste;
          

        }

        private void txtPlakaAra_TextChanged(object sender, EventArgs e)
        {
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdSoyad,
                             t.ParkYerleri,
                             x.Telefon,
                             y.MarkaAdı,
                             z.seri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcretı,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.Plaka.Contains(txtPlakaAra.Text)).ToString();
            dataGridView1.DataSource = liste;
          


        }

        private void txtParkYeriAra_TextChanged(object sender, EventArgs e)
        {
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on
                      x.MarkaID equals y.ID
                         join z in db.TBLSeri on
                      x.SeriID equals z.ID
                         join t in db.TBLAracParkYerleri on
                      x.ParkYeriID equals t.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdSoyad,
                             t.ParkYerleri,
                             x.Telefon,
                             y.MarkaAdı,
                             z.seri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcretı,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi


                         }).Where(x => x.ParkYerleri.Contains(txtParkYeriAra.Text)).ToString();
            dataGridView1.DataSource = liste;

        }
    }
}


