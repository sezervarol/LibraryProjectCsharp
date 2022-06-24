
namespace WinFormsApp1
{
    partial class ÜyeDüzenleForm
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
            this.üyeDuzenleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.kitapDuzenleCikisBtn = new System.Windows.Forms.Button();
            this.üyeDuzenleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.üyetelefontxt = new System.Windows.Forms.TextBox();
            this.üyeemailtxt = new System.Windows.Forms.TextBox();
            this.üyesoyadıtxt = new System.Windows.Forms.TextBox();
            this.üyekitapBölümBtn = new System.Windows.Forms.Button();
            this.üyeSilBtn = new System.Windows.Forms.Button();
            this.üyeDuzenleBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.üyedurumCb = new System.Windows.Forms.ComboBox();
            this.üyeresimTxt = new System.Windows.Forms.TextBox();
            this.üyeadresRtb = new System.Windows.Forms.RichTextBox();
            this.üyeAdiTxt = new System.Windows.Forms.TextBox();
            this.ÜyetcNo = new System.Windows.Forms.TextBox();
            this.üyeDuzenleHeaderPanel.SuspendLayout();
            this.üyeDuzenleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // üyeDuzenleHeaderPanel
            // 
            this.üyeDuzenleHeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.üyeDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.üyeDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleCikisBtn);
            this.üyeDuzenleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.üyeDuzenleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.üyeDuzenleHeaderPanel.Name = "üyeDuzenleHeaderPanel";
            this.üyeDuzenleHeaderPanel.Size = new System.Drawing.Size(622, 80);
            this.üyeDuzenleHeaderPanel.TabIndex = 5;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(26, 25);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(131, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Üye Düzenle";
            // 
            // kitapDuzenleCikisBtn
            // 
            this.kitapDuzenleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.kitapDuzenleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.kitapDuzenleCikisBtn.Location = new System.Drawing.Point(566, 22);
            this.kitapDuzenleCikisBtn.Name = "kitapDuzenleCikisBtn";
            this.kitapDuzenleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.kitapDuzenleCikisBtn.TabIndex = 5;
            this.kitapDuzenleCikisBtn.Text = "X";
            this.kitapDuzenleCikisBtn.UseVisualStyleBackColor = false;
            this.kitapDuzenleCikisBtn.Click += new System.EventHandler(this.kitapDuzenleCikisBtn_Click);
            // 
            // üyeDuzenleContentPanel
            // 
            this.üyeDuzenleContentPanel.Controls.Add(this.groupBox1);
            this.üyeDuzenleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.üyeDuzenleContentPanel.Location = new System.Drawing.Point(0, 102);
            this.üyeDuzenleContentPanel.Name = "üyeDuzenleContentPanel";
            this.üyeDuzenleContentPanel.Size = new System.Drawing.Size(622, 381);
            this.üyeDuzenleContentPanel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.üyetelefontxt);
            this.groupBox1.Controls.Add(this.üyeemailtxt);
            this.groupBox1.Controls.Add(this.üyesoyadıtxt);
            this.groupBox1.Controls.Add(this.üyekitapBölümBtn);
            this.groupBox1.Controls.Add(this.üyeSilBtn);
            this.groupBox1.Controls.Add(this.üyeDuzenleBtn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.üyedurumCb);
            this.groupBox1.Controls.Add(this.üyeresimTxt);
            this.groupBox1.Controls.Add(this.üyeadresRtb);
            this.groupBox1.Controls.Add(this.üyeAdiTxt);
            this.groupBox1.Controls.Add(this.ÜyetcNo);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Telefon";
            // 
            // üyetelefontxt
            // 
            this.üyetelefontxt.Location = new System.Drawing.Point(0, 222);
            this.üyetelefontxt.Name = "üyetelefontxt";
            this.üyetelefontxt.Size = new System.Drawing.Size(100, 23);
            this.üyetelefontxt.TabIndex = 21;
            // 
            // üyeemailtxt
            // 
            this.üyeemailtxt.Location = new System.Drawing.Point(0, 174);
            this.üyeemailtxt.Name = "üyeemailtxt";
            this.üyeemailtxt.Size = new System.Drawing.Size(100, 23);
            this.üyeemailtxt.TabIndex = 20;
            // 
            // üyesoyadıtxt
            // 
            this.üyesoyadıtxt.Location = new System.Drawing.Point(0, 128);
            this.üyesoyadıtxt.Name = "üyesoyadıtxt";
            this.üyesoyadıtxt.Size = new System.Drawing.Size(100, 23);
            this.üyesoyadıtxt.TabIndex = 19;
            // 
            // üyekitapBölümBtn
            // 
            this.üyekitapBölümBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.üyekitapBölümBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.üyekitapBölümBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.üyekitapBölümBtn.ForeColor = System.Drawing.Color.White;
            this.üyekitapBölümBtn.Location = new System.Drawing.Point(438, 109);
            this.üyekitapBölümBtn.Name = "üyekitapBölümBtn";
            this.üyekitapBölümBtn.Size = new System.Drawing.Size(157, 87);
            this.üyekitapBölümBtn.TabIndex = 18;
            this.üyekitapBölümBtn.Text = "Üye Kitap Bölümü";
            this.üyekitapBölümBtn.UseVisualStyleBackColor = false;
            this.üyekitapBölümBtn.Click += new System.EventHandler(this.üyekitapBölümBtn_Click);
            // 
            // üyeSilBtn
            // 
            this.üyeSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.üyeSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.üyeSilBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.üyeSilBtn.ForeColor = System.Drawing.Color.White;
            this.üyeSilBtn.Location = new System.Drawing.Point(438, 203);
            this.üyeSilBtn.Name = "üyeSilBtn";
            this.üyeSilBtn.Size = new System.Drawing.Size(157, 80);
            this.üyeSilBtn.TabIndex = 17;
            this.üyeSilBtn.Text = "Üye Sil";
            this.üyeSilBtn.UseVisualStyleBackColor = false;
            this.üyeSilBtn.Click += new System.EventHandler(this.üyeSilBtn_Click);
            // 
            // üyeDuzenleBtn
            // 
            this.üyeDuzenleBtn.BackColor = System.Drawing.Color.Green;
            this.üyeDuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.üyeDuzenleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.üyeDuzenleBtn.ForeColor = System.Drawing.Color.White;
            this.üyeDuzenleBtn.Location = new System.Drawing.Point(438, 19);
            this.üyeDuzenleBtn.Name = "üyeDuzenleBtn";
            this.üyeDuzenleBtn.Size = new System.Drawing.Size(157, 80);
            this.üyeDuzenleBtn.TabIndex = 16;
            this.üyeDuzenleBtn.Text = "Üye Düzenle";
            this.üyeDuzenleBtn.UseVisualStyleBackColor = false;
            this.üyeDuzenleBtn.Click += new System.EventHandler(this.üyeDuzenleBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Üye Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Üye Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Üye Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC No";
            // 
            // üyedurumCb
            // 
            this.üyedurumCb.FormattingEnabled = true;
            this.üyedurumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.üyedurumCb.Location = new System.Drawing.Point(122, 278);
            this.üyedurumCb.Name = "üyedurumCb";
            this.üyedurumCb.Size = new System.Drawing.Size(100, 23);
            this.üyedurumCb.TabIndex = 7;
            // 
            // üyeresimTxt
            // 
            this.üyeresimTxt.Location = new System.Drawing.Point(0, 278);
            this.üyeresimTxt.Name = "üyeresimTxt";
            this.üyeresimTxt.Size = new System.Drawing.Size(100, 23);
            this.üyeresimTxt.TabIndex = 6;
            // 
            // üyeadresRtb
            // 
            this.üyeadresRtb.Location = new System.Drawing.Point(122, 37);
            this.üyeadresRtb.Name = "üyeadresRtb";
            this.üyeadresRtb.Size = new System.Drawing.Size(246, 191);
            this.üyeadresRtb.TabIndex = 5;
            this.üyeadresRtb.Text = "";
            // 
            // üyeAdiTxt
            // 
            this.üyeAdiTxt.Location = new System.Drawing.Point(0, 82);
            this.üyeAdiTxt.Name = "üyeAdiTxt";
            this.üyeAdiTxt.Size = new System.Drawing.Size(100, 23);
            this.üyeAdiTxt.TabIndex = 1;
            // 
            // ÜyetcNo
            // 
            this.ÜyetcNo.Location = new System.Drawing.Point(0, 38);
            this.ÜyetcNo.Name = "ÜyetcNo";
            this.ÜyetcNo.Size = new System.Drawing.Size(100, 23);
            this.ÜyetcNo.TabIndex = 0;
            // 
            // ÜyeDüzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 483);
            this.Controls.Add(this.üyeDuzenleContentPanel);
            this.Controls.Add(this.üyeDuzenleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜyeDüzenleForm";
            this.Text = "ÜyeDüzenleForm";
            this.Load += new System.EventHandler(this.ÜyeDüzenleForm_Load);
            this.üyeDuzenleHeaderPanel.ResumeLayout(false);
            this.üyeDuzenleHeaderPanel.PerformLayout();
            this.üyeDuzenleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel üyeDuzenleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button kitapDuzenleCikisBtn;
        private System.Windows.Forms.Panel üyeDuzenleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button üyekitapBölümBtn;
        private System.Windows.Forms.Button üyeSilBtn;
        private System.Windows.Forms.Button üyeDuzenleBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox üyedurumCb;
        private System.Windows.Forms.TextBox üyeresimTxt;
        private System.Windows.Forms.RichTextBox üyeadresRtb;
        private System.Windows.Forms.TextBox üyeAdiTxt;
        private System.Windows.Forms.TextBox ÜyetcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox üyetelefontxt;
        private System.Windows.Forms.TextBox üyeemailtxt;
        private System.Windows.Forms.TextBox üyesoyadıtxt;
    }
}