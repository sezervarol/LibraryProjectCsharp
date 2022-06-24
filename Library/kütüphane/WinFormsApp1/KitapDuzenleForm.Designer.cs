
namespace WinFormsApp1
{
    partial class KitapDuzenleForm
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
            this.kitapDuzenleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kitapStokLbl = new System.Windows.Forms.Label();
            this.kitapStokNud = new System.Windows.Forms.NumericUpDown();
            this.stokEkleBtn = new System.Windows.Forms.Button();
            this.KitapEkleBtn = new System.Windows.Forms.Button();
            this.kitapSilBtn = new System.Windows.Forms.Button();
            this.kitapDuzenleBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.durumCb = new System.Windows.Forms.ComboBox();
            this.resimTxt = new System.Windows.Forms.TextBox();
            this.aciklamaRtb = new System.Windows.Forms.RichTextBox();
            this.rafCb = new System.Windows.Forms.ComboBox();
            this.turCb = new System.Windows.Forms.ComboBox();
            this.yazarCb = new System.Windows.Forms.ComboBox();
            this.kitapAdiTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.kitapDuzenleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.kitapDuzenleCikisBtn = new System.Windows.Forms.Button();
            this.kitapDuzenleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapStokNud)).BeginInit();
            this.kitapDuzenleHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitapDuzenleContentPanel
            // 
            this.kitapDuzenleContentPanel.Controls.Add(this.groupBox1);
            this.kitapDuzenleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitapDuzenleContentPanel.Location = new System.Drawing.Point(0, 95);
            this.kitapDuzenleContentPanel.Name = "kitapDuzenleContentPanel";
            this.kitapDuzenleContentPanel.Size = new System.Drawing.Size(780, 355);
            this.kitapDuzenleContentPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kitapStokLbl);
            this.groupBox1.Controls.Add(this.kitapStokNud);
            this.groupBox1.Controls.Add(this.stokEkleBtn);
            this.groupBox1.Controls.Add(this.KitapEkleBtn);
            this.groupBox1.Controls.Add(this.kitapSilBtn);
            this.groupBox1.Controls.Add(this.kitapDuzenleBtn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.durumCb);
            this.groupBox1.Controls.Add(this.resimTxt);
            this.groupBox1.Controls.Add(this.aciklamaRtb);
            this.groupBox1.Controls.Add(this.rafCb);
            this.groupBox1.Controls.Add(this.turCb);
            this.groupBox1.Controls.Add(this.yazarCb);
            this.groupBox1.Controls.Add(this.kitapAdiTxt);
            this.groupBox1.Controls.Add(this.isbnTxt);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // kitapStokLbl
            // 
            this.kitapStokLbl.AutoSize = true;
            this.kitapStokLbl.Location = new System.Drawing.Point(534, 245);
            this.kitapStokLbl.Name = "kitapStokLbl";
            this.kitapStokLbl.Size = new System.Drawing.Size(62, 15);
            this.kitapStokLbl.TabIndex = 21;
            this.kitapStokLbl.Text = "Kitap Adet";
            // 
            // kitapStokNud
            // 
            this.kitapStokNud.Location = new System.Drawing.Point(534, 263);
            this.kitapStokNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kitapStokNud.Name = "kitapStokNud";
            this.kitapStokNud.Size = new System.Drawing.Size(77, 23);
            this.kitapStokNud.TabIndex = 20;
            this.kitapStokNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stokEkleBtn
            // 
            this.stokEkleBtn.Location = new System.Drawing.Point(614, 263);
            this.stokEkleBtn.Name = "stokEkleBtn";
            this.stokEkleBtn.Size = new System.Drawing.Size(75, 23);
            this.stokEkleBtn.TabIndex = 19;
            this.stokEkleBtn.Text = "Stoğa Ekle";
            this.stokEkleBtn.UseVisualStyleBackColor = true;
            this.stokEkleBtn.Click += new System.EventHandler(this.stokEkleBtn_Click);
            // 
            // KitapEkleBtn
            // 
            this.KitapEkleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KitapEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KitapEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KitapEkleBtn.ForeColor = System.Drawing.Color.White;
            this.KitapEkleBtn.Location = new System.Drawing.Point(534, 147);
            this.KitapEkleBtn.Name = "KitapEkleBtn";
            this.KitapEkleBtn.Size = new System.Drawing.Size(77, 80);
            this.KitapEkleBtn.TabIndex = 18;
            this.KitapEkleBtn.Text = "Kitap Ekle";
            this.KitapEkleBtn.UseVisualStyleBackColor = false;
            this.KitapEkleBtn.Click += new System.EventHandler(this.KitapEkleBtn_Click);
            // 
            // kitapSilBtn
            // 
            this.kitapSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kitapSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitapSilBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapSilBtn.ForeColor = System.Drawing.Color.White;
            this.kitapSilBtn.Location = new System.Drawing.Point(614, 147);
            this.kitapSilBtn.Name = "kitapSilBtn";
            this.kitapSilBtn.Size = new System.Drawing.Size(77, 80);
            this.kitapSilBtn.TabIndex = 17;
            this.kitapSilBtn.Text = "Kitap Sil";
            this.kitapSilBtn.UseVisualStyleBackColor = false;
            this.kitapSilBtn.Click += new System.EventHandler(this.kitapSilBtn_Click);
            // 
            // kitapDuzenleBtn
            // 
            this.kitapDuzenleBtn.BackColor = System.Drawing.Color.Green;
            this.kitapDuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitapDuzenleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleBtn.ForeColor = System.Drawing.Color.White;
            this.kitapDuzenleBtn.Location = new System.Drawing.Point(534, 53);
            this.kitapDuzenleBtn.Name = "kitapDuzenleBtn";
            this.kitapDuzenleBtn.Size = new System.Drawing.Size(157, 80);
            this.kitapDuzenleBtn.TabIndex = 16;
            this.kitapDuzenleBtn.Text = "Kitap Düzenle";
            this.kitapDuzenleBtn.UseVisualStyleBackColor = false;
            this.kitapDuzenleBtn.Click += new System.EventHandler(this.kitapDuzenleBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Raf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ISBN No";
            // 
            // durumCb
            // 
            this.durumCb.FormattingEnabled = true;
            this.durumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.durumCb.Location = new System.Drawing.Point(400, 167);
            this.durumCb.Name = "durumCb";
            this.durumCb.Size = new System.Drawing.Size(100, 23);
            this.durumCb.TabIndex = 7;
            // 
            // resimTxt
            // 
            this.resimTxt.Location = new System.Drawing.Point(401, 54);
            this.resimTxt.Name = "resimTxt";
            this.resimTxt.Size = new System.Drawing.Size(100, 23);
            this.resimTxt.TabIndex = 6;
            // 
            // aciklamaRtb
            // 
            this.aciklamaRtb.Location = new System.Drawing.Point(194, 54);
            this.aciklamaRtb.Name = "aciklamaRtb";
            this.aciklamaRtb.Size = new System.Drawing.Size(159, 191);
            this.aciklamaRtb.TabIndex = 5;
            this.aciklamaRtb.Text = "";
            // 
            // rafCb
            // 
            this.rafCb.FormattingEnabled = true;
            this.rafCb.Location = new System.Drawing.Point(400, 110);
            this.rafCb.Name = "rafCb";
            this.rafCb.Size = new System.Drawing.Size(101, 23);
            this.rafCb.TabIndex = 4;
            // 
            // turCb
            // 
            this.turCb.FormattingEnabled = true;
            this.turCb.Location = new System.Drawing.Point(45, 222);
            this.turCb.Name = "turCb";
            this.turCb.Size = new System.Drawing.Size(100, 23);
            this.turCb.TabIndex = 3;
            // 
            // yazarCb
            // 
            this.yazarCb.FormattingEnabled = true;
            this.yazarCb.Location = new System.Drawing.Point(45, 166);
            this.yazarCb.Name = "yazarCb";
            this.yazarCb.Size = new System.Drawing.Size(100, 23);
            this.yazarCb.TabIndex = 2;
            // 
            // kitapAdiTxt
            // 
            this.kitapAdiTxt.Location = new System.Drawing.Point(45, 110);
            this.kitapAdiTxt.Name = "kitapAdiTxt";
            this.kitapAdiTxt.Size = new System.Drawing.Size(100, 23);
            this.kitapAdiTxt.TabIndex = 1;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(45, 54);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(100, 23);
            this.isbnTxt.TabIndex = 0;
            // 
            // kitapDuzenleHeaderPanel
            // 
            this.kitapDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.kitapDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleCikisBtn);
            this.kitapDuzenleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitapDuzenleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.kitapDuzenleHeaderPanel.Name = "kitapDuzenleHeaderPanel";
            this.kitapDuzenleHeaderPanel.Size = new System.Drawing.Size(780, 80);
            this.kitapDuzenleHeaderPanel.TabIndex = 2;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(26, 25);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(145, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Kitap Düzenle";
            // 
            // kitapDuzenleCikisBtn
            // 
            this.kitapDuzenleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.kitapDuzenleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.kitapDuzenleCikisBtn.Location = new System.Drawing.Point(729, 25);
            this.kitapDuzenleCikisBtn.Name = "kitapDuzenleCikisBtn";
            this.kitapDuzenleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.kitapDuzenleCikisBtn.TabIndex = 5;
            this.kitapDuzenleCikisBtn.Text = "X";
            this.kitapDuzenleCikisBtn.UseVisualStyleBackColor = false;
            this.kitapDuzenleCikisBtn.Click += new System.EventHandler(this.kitapDuzenleCikisBtn_Click);
            // 
            // KitapDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.kitapDuzenleContentPanel);
            this.Controls.Add(this.kitapDuzenleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapDuzenleForm";
            this.Load += new System.EventHandler(this.KitapDuzenleForm_Load);
            this.kitapDuzenleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapStokNud)).EndInit();
            this.kitapDuzenleHeaderPanel.ResumeLayout(false);
            this.kitapDuzenleHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kitapDuzenleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kitapDuzenleBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox durumCb;
        private System.Windows.Forms.TextBox resimTxt;
        private System.Windows.Forms.RichTextBox aciklamaRtb;
        private System.Windows.Forms.ComboBox rafCb;
        private System.Windows.Forms.ComboBox turCb;
        private System.Windows.Forms.ComboBox yazarCb;
        private System.Windows.Forms.TextBox kitapAdiTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.Panel kitapDuzenleHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitapDuzenleCikisBtn;
        private System.Windows.Forms.Button kitapSilBtn;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button KitapEkleBtn;
        private System.Windows.Forms.Label kitapStokLbl;
        private System.Windows.Forms.NumericUpDown kitapStokNud;
        private System.Windows.Forms.Button stokEkleBtn;
    }
}