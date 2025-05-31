
namespace Otopark.Formlar
{
    partial class frmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.txtMusteriIDAra = new System.Windows.Forms.TextBox();
            this.txtIDAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlakaAra = new System.Windows.Forms.TextBox();
            this.txtParkYeriAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Location = new System.Drawing.Point(287, 41);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyadAra.TabIndex = 9;
            this.txtAdSoyadAra.TextChanged += new System.EventHandler(this.txtAdSoyadAra_TextChanged);
            // 
            // txtMusteriIDAra
            // 
            this.txtMusteriIDAra.Location = new System.Drawing.Point(151, 41);
            this.txtMusteriIDAra.Name = "txtMusteriIDAra";
            this.txtMusteriIDAra.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriIDAra.TabIndex = 10;
            this.txtMusteriIDAra.TextChanged += new System.EventHandler(this.txtMusteriIDAra_TextChanged);
            // 
            // txtIDAra
            // 
            this.txtIDAra.Location = new System.Drawing.Point(15, 41);
            this.txtIDAra.Name = "txtIDAra";
            this.txtIDAra.Size = new System.Drawing.Size(100, 22);
            this.txtIDAra.TabIndex = 11;
            this.txtIDAra.TextChanged += new System.EventHandler(this.txtIDAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Park Yeri Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plaka Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad Soyad Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müşteri ID Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Ara";
            // 
            // txtPlakaAra
            // 
            this.txtPlakaAra.Location = new System.Drawing.Point(426, 41);
            this.txtPlakaAra.Name = "txtPlakaAra";
            this.txtPlakaAra.Size = new System.Drawing.Size(100, 22);
            this.txtPlakaAra.TabIndex = 12;
            this.txtPlakaAra.TextChanged += new System.EventHandler(this.txtPlakaAra_TextChanged);
            // 
            // txtParkYeriAra
            // 
            this.txtParkYeriAra.Location = new System.Drawing.Point(589, 41);
            this.txtParkYeriAra.Name = "txtParkYeriAra";
            this.txtParkYeriAra.Size = new System.Drawing.Size(100, 22);
            this.txtParkYeriAra.TabIndex = 13;
            this.txtParkYeriAra.TextChanged += new System.EventHandler(this.txtParkYeriAra_TextChanged);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.txtParkYeriAra);
            this.Controls.Add(this.txtPlakaAra);
            this.Controls.Add(this.txtAdSoyadAra);
            this.Controls.Add(this.txtMusteriIDAra);
            this.Controls.Add(this.txtIDAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.TextBox txtMusteriIDAra;
        private System.Windows.Forms.TextBox txtIDAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakaAra;
        private System.Windows.Forms.TextBox txtParkYeriAra;
    }
}