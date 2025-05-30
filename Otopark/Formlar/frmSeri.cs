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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmSeri_Load(object sender, EventArgs e)
        {
            Listele();
            var comboliste = db.TBLMarka.ToList();
            comboBoxMarka.DataSource = comboliste;
            comboBoxMarka.DisplayMember = "MarkaAdı";
            comboBoxMarka.ValueMember = "ID";
        }

        private void Listele()
        {
            listView1.Items.Clear();
            var liste = from x in db.TBLSeri
                        join y in db.TBLMarka on x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkaAdı,
                            x.seri
                        };
            foreach (var item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdı);
                viewItem.SubItems.Add(item.seri);
                listView1.Items.Add(viewItem);
            }
        }
        void Temizle () 
        {
            txtID.Text = "";
            txtSeriAd.Text = "";
            comboBoxMarka.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int markaid = (int)comboBoxMarka.SelectedValue;
            var ekle = new Seri();
            ekle.MarkaID = markaid;
            ekle.seri = txtSeriAd.Text;
            db.TBLSeri.Add(ekle);
            db.SaveChanges();
            Temizle();
            Listele();
            MessageBox.Show("Araç Serisi eklendi","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem secilenID = listView1.SelectedItems[0];
            int secilenId = int.Parse(secilenID.SubItems[0].Text);
            var sil = db.TBLSeri.FirstOrDefault(X => X.ID == secilenId);
            db.TBLSeri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç Serisi Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TBLSeri.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaID = (int)comboBoxMarka.SelectedValue;
            guncelle.seri = txtSeriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Serisi Güncellendi", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                txtID.Text = secilen.SubItems[0].Text;
                comboBoxMarka.Text = secilen.SubItems[1].Text;
                txtSeriAd.Text = secilen.SubItems[2].Text;

            }
        }
    }
}
