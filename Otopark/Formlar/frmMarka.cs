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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        
        void Temizle() 
        {
            txtID.Text = "";
            txtMarkaAdı.Text = "";
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count>0)
            {
                txtID.Text = secilen.SubItems[0].Text;
                txtMarkaAdı.Text = secilen.SubItems[1].Text;
            }
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void MarkaListele()
        {
            listView1.Items.Clear();
            var markalistesi = db.TBLMarka.ToList();
            for (int i = 0; i < markalistesi.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markalistesi[i].ID.ToString());
                ekle.SubItems.Add(markalistesi[i].MarkaAdı);
                listView1.Items.Add(ekle);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var tbl = new Marka();
            tbl.MarkaAdı = txtMarkaAdı.Text;
            db.TBLMarka.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Araç Markası Eklendi","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MarkaListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem secilenID = listView1.SelectedItems[0];
            int secilenId = int.Parse(secilenID.SubItems[0].Text);
            var sil = db.TBLMarka.FirstOrDefault(X => X.ID ==secilenId);
            db.TBLMarka.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç Markası Silindi", "Uyarı" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TBLMarka.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaAdı = txtMarkaAdı.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Markası Güncellendi", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();

        }
    }
}
