
namespace WinFormsApp1
{
    partial class PersonelEkleForm
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
            this.PersonelEkleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.personelSifreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personelSoyadiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.porsonelDurumCb = new System.Windows.Forms.ComboBox();
            this.personelAdiTxt = new System.Windows.Forms.TextBox();
            this.PersonelEkleBtn = new System.Windows.Forms.Button();
            this.PersonelEkleHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelEkleCikisBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.personelYetkiCb = new System.Windows.Forms.ComboBox();
            this.PersonelEkleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PersonelEkleHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonelEkleContentPanel
            // 
            this.PersonelEkleContentPanel.Controls.Add(this.groupBox1);
            this.PersonelEkleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PersonelEkleContentPanel.Location = new System.Drawing.Point(0, 97);
            this.PersonelEkleContentPanel.Name = "PersonelEkleContentPanel";
            this.PersonelEkleContentPanel.Size = new System.Drawing.Size(276, 448);
            this.PersonelEkleContentPanel.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.personelYetkiCb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.personelSifreTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.personelSoyadiTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.porsonelDurumCb);
            this.groupBox1.Controls.Add(this.personelAdiTxt);
            this.groupBox1.Controls.Add(this.PersonelEkleBtn);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Şifre";
            // 
            // personelSifreTxt
            // 
            this.personelSifreTxt.Location = new System.Drawing.Point(37, 164);
            this.personelSifreTxt.MaxLength = 11;
            this.personelSifreTxt.Name = "personelSifreTxt";
            this.personelSifreTxt.Size = new System.Drawing.Size(157, 23);
            this.personelSifreTxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Personel Soyadı";
            // 
            // personelSoyadiTxt
            // 
            this.personelSoyadiTxt.Location = new System.Drawing.Point(37, 111);
            this.personelSoyadiTxt.Name = "personelSoyadiTxt";
            this.personelSoyadiTxt.Size = new System.Drawing.Size(157, 23);
            this.personelSoyadiTxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Personel Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Personel Adı";
            // 
            // porsonelDurumCb
            // 
            this.porsonelDurumCb.FormattingEnabled = true;
            this.porsonelDurumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.porsonelDurumCb.Location = new System.Drawing.Point(37, 270);
            this.porsonelDurumCb.Name = "porsonelDurumCb";
            this.porsonelDurumCb.Size = new System.Drawing.Size(157, 23);
            this.porsonelDurumCb.TabIndex = 19;
            // 
            // personelAdiTxt
            // 
            this.personelAdiTxt.Location = new System.Drawing.Point(37, 58);
            this.personelAdiTxt.Name = "personelAdiTxt";
            this.personelAdiTxt.Size = new System.Drawing.Size(157, 23);
            this.personelAdiTxt.TabIndex = 18;
            // 
            // PersonelEkleBtn
            // 
            this.PersonelEkleBtn.BackColor = System.Drawing.Color.Green;
            this.PersonelEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PersonelEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelEkleBtn.ForeColor = System.Drawing.Color.White;
            this.PersonelEkleBtn.Location = new System.Drawing.Point(37, 308);
            this.PersonelEkleBtn.Name = "PersonelEkleBtn";
            this.PersonelEkleBtn.Size = new System.Drawing.Size(157, 80);
            this.PersonelEkleBtn.TabIndex = 17;
            this.PersonelEkleBtn.Text = "Personel Ekle";
            this.PersonelEkleBtn.UseVisualStyleBackColor = false;
            this.PersonelEkleBtn.Click += new System.EventHandler(this.PersonelEkleBtn_Click);
            // 
            // PersonelEkleHeaderPanel
            // 
            this.PersonelEkleHeaderPanel.Controls.Add(this.label1);
            this.PersonelEkleHeaderPanel.Controls.Add(this.PersonelEkleCikisBtn);
            this.PersonelEkleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonelEkleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.PersonelEkleHeaderPanel.Name = "PersonelEkleHeaderPanel";
            this.PersonelEkleHeaderPanel.Size = new System.Drawing.Size(276, 84);
            this.PersonelEkleHeaderPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personel Ekle";
            // 
            // PersonelEkleCikisBtn
            // 
            this.PersonelEkleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.PersonelEkleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelEkleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.PersonelEkleCikisBtn.Location = new System.Drawing.Point(222, 27);
            this.PersonelEkleCikisBtn.Name = "PersonelEkleCikisBtn";
            this.PersonelEkleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.PersonelEkleCikisBtn.TabIndex = 6;
            this.PersonelEkleCikisBtn.Text = "X";
            this.PersonelEkleCikisBtn.UseVisualStyleBackColor = false;
            this.PersonelEkleCikisBtn.Click += new System.EventHandler(this.PersonelEkleCikisBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Personel Yetki";
            // 
            // personelYetkiCb
            // 
            this.personelYetkiCb.FormattingEnabled = true;
            this.personelYetkiCb.Location = new System.Drawing.Point(37, 217);
            this.personelYetkiCb.Name = "personelYetkiCb";
            this.personelYetkiCb.Size = new System.Drawing.Size(157, 23);
            this.personelYetkiCb.TabIndex = 28;
            // 
            // PersonelEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(276, 545);
            this.Controls.Add(this.PersonelEkleContentPanel);
            this.Controls.Add(this.PersonelEkleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkleForm";
            this.Load += new System.EventHandler(this.PersonelEkleForm_Load);
            this.PersonelEkleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PersonelEkleHeaderPanel.ResumeLayout(false);
            this.PersonelEkleHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PersonelEkleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox personelSifreTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personelSoyadiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox porsonelDurumCb;
        private System.Windows.Forms.TextBox personelAdiTxt;
        private System.Windows.Forms.Button PersonelEkleBtn;
        private System.Windows.Forms.Panel PersonelEkleHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PersonelEkleCikisBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox personelYetkiCb;
    }
}