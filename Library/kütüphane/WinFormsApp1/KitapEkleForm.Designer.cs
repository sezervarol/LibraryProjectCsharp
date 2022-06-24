
namespace WinFormsApp1
{
    partial class KitapEkleForm
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
            this.kitapEkleHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapEkleCikisBtn = new System.Windows.Forms.Button();
            this.kitapEkleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kitapEkleBtn = new System.Windows.Forms.Button();
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
            this.kitapEkleHeaderPanel.SuspendLayout();
            this.kitapEkleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitapEkleHeaderPanel
            // 
            this.kitapEkleHeaderPanel.Controls.Add(this.label1);
            this.kitapEkleHeaderPanel.Controls.Add(this.kitapEkleCikisBtn);
            this.kitapEkleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitapEkleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.kitapEkleHeaderPanel.Name = "kitapEkleHeaderPanel";
            this.kitapEkleHeaderPanel.Size = new System.Drawing.Size(782, 80);
            this.kitapEkleHeaderPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap Ekle";
            // 
            // kitapEkleCikisBtn
            // 
            this.kitapEkleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.kitapEkleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapEkleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.kitapEkleCikisBtn.Location = new System.Drawing.Point(729, 25);
            this.kitapEkleCikisBtn.Name = "kitapEkleCikisBtn";
            this.kitapEkleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.kitapEkleCikisBtn.TabIndex = 5;
            this.kitapEkleCikisBtn.Text = "X";
            this.kitapEkleCikisBtn.UseVisualStyleBackColor = false;
            this.kitapEkleCikisBtn.Click += new System.EventHandler(this.kitapEkleCikisBtn_Click);
            // 
            // kitapEkleContentPanel
            // 
            this.kitapEkleContentPanel.Controls.Add(this.groupBox1);
            this.kitapEkleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitapEkleContentPanel.Location = new System.Drawing.Point(0, 106);
            this.kitapEkleContentPanel.Name = "kitapEkleContentPanel";
            this.kitapEkleContentPanel.Size = new System.Drawing.Size(782, 355);
            this.kitapEkleContentPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kitapEkleBtn);
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
            this.groupBox1.Size = new System.Drawing.Size(735, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // kitapEkleBtn
            // 
            this.kitapEkleBtn.BackColor = System.Drawing.Color.Green;
            this.kitapEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitapEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapEkleBtn.ForeColor = System.Drawing.Color.White;
            this.kitapEkleBtn.Location = new System.Drawing.Point(534, 53);
            this.kitapEkleBtn.Name = "kitapEkleBtn";
            this.kitapEkleBtn.Size = new System.Drawing.Size(157, 80);
            this.kitapEkleBtn.TabIndex = 16;
            this.kitapEkleBtn.Text = "Kitap Ekle";
            this.kitapEkleBtn.UseVisualStyleBackColor = false;
            this.kitapEkleBtn.Click += new System.EventHandler(this.kitapEkleBtn_Click);
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
            // KitapEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(782, 461);
            this.Controls.Add(this.kitapEkleContentPanel);
            this.Controls.Add(this.kitapEkleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEkleForm";
            this.Load += new System.EventHandler(this.KitapEkleForm_Load);
            this.kitapEkleHeaderPanel.ResumeLayout(false);
            this.kitapEkleHeaderPanel.PerformLayout();
            this.kitapEkleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kitapEkleHeaderPanel;
        private System.Windows.Forms.Panel kitapEkleContentPanel;
        private System.Windows.Forms.Button kitapEkleCikisBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kitapEkleBtn;
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
    }
}