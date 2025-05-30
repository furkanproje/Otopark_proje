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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }
        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            pictureBox1.ImageLocation = "";
            dateTimeTarih.Value = DateTime.Now;

        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.TBLMusteri
                      where x.ID.ToString() == txtID.Text
                      select x;
            foreach (var item in ara)
            {
                txtAdSoyad.Text = item.AdSoyad;
                txtTelefon.Text = item.Telefon;
                txtEmail.Text = item.Email;
                txtAdres.Text = item.Adres;
                pictureBox1.ImageLocation = item.Resim;
                dateTimeTarih.Value = item.Tarih;
            }
            if (txtID.Text == "")
            {
                Temizle();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ekle = new Musteri();
            ekle.AdSoyad = txtAdSoyad.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.Email = txtEmail.Text;
            ekle.Adres = txtAdres.Text;
            ekle.Resim = pictureBox1.ImageLocation;
            ekle.Tarih = dateTimeTarih.Value;
            db.TBLMusteri.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Gerçekleşti", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.TBLMusteri.FirstOrDefault(x => x.ID == id);
            db.TBLMusteri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var guncelle = db.TBLMusteri.FirstOrDefault(x => x.ID == id);
            guncelle.AdSoyad = txtAdSoyad.Text;
            guncelle.Telefon = txtTelefon.Text;
            guncelle.Email = txtEmail.Text; 
            guncelle.Adres = txtAdres.Text;
            guncelle.Resim = pictureBox1.ImageLocation;
            guncelle.Tarih = dateTimeTarih.Value;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }
    }
}
