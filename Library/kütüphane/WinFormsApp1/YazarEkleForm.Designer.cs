
namespace WinFormsApp1
{
    partial class YazarEkleForm
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
            this.YazarEkleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yazarDurumCb = new System.Windows.Forms.ComboBox();
            this.yazarAdiTxt = new System.Windows.Forms.TextBox();
            this.yazarEkleBtn = new System.Windows.Forms.Button();
            this.YazarEkleHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.YazarEkleCikisBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yazarSoyadiTxt = new System.Windows.Forms.TextBox();
            this.yazarAciklamaRtb = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.YazarEkleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.YazarEkleHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YazarEkleContentPanel
            // 
            this.YazarEkleContentPanel.Controls.Add(this.groupBox1);
            this.YazarEkleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.YazarEkleContentPanel.Location = new System.Drawing.Point(0, 136);
            this.YazarEkleContentPanel.Name = "YazarEkleContentPanel";
            this.YazarEkleContentPanel.Size = new System.Drawing.Size(661, 314);
            this.YazarEkleContentPanel.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.yazarAciklamaRtb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.yazarSoyadiTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.yazarDurumCb);
            this.groupBox1.Controls.Add(this.yazarAdiTxt);
            this.groupBox1.Controls.Add(this.yazarEkleBtn);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Yazar Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yazar Adı";
            // 
            // yazarDurumCb
            // 
            this.yazarDurumCb.FormattingEnabled = true;
            this.yazarDurumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.yazarDurumCb.Location = new System.Drawing.Point(37, 186);
            this.yazarDurumCb.Name = "yazarDurumCb";
            this.yazarDurumCb.Size = new System.Drawing.Size(157, 23);
            this.yazarDurumCb.TabIndex = 19;
            // 
            // yazarAdiTxt
            // 
            this.yazarAdiTxt.Location = new System.Drawing.Point(37, 58);
            this.yazarAdiTxt.Name = "yazarAdiTxt";
            this.yazarAdiTxt.Size = new System.Drawing.Size(157, 23);
            this.yazarAdiTxt.TabIndex = 18;
            // 
            // yazarEkleBtn
            // 
            this.yazarEkleBtn.BackColor = System.Drawing.Color.Green;
            this.yazarEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yazarEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yazarEkleBtn.ForeColor = System.Drawing.Color.White;
            this.yazarEkleBtn.Location = new System.Drawing.Point(424, 88);
            this.yazarEkleBtn.Name = "yazarEkleBtn";
            this.yazarEkleBtn.Size = new System.Drawing.Size(157, 80);
            this.yazarEkleBtn.TabIndex = 17;
            this.yazarEkleBtn.Text = "Yazar Ekle";
            this.yazarEkleBtn.UseVisualStyleBackColor = false;
            this.yazarEkleBtn.Click += new System.EventHandler(this.yazarEkleBtn_Click);
            // 
            // YazarEkleHeaderPanel
            // 
            this.YazarEkleHeaderPanel.Controls.Add(this.label1);
            this.YazarEkleHeaderPanel.Controls.Add(this.YazarEkleCikisBtn);
            this.YazarEkleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YazarEkleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.YazarEkleHeaderPanel.Name = "YazarEkleHeaderPanel";
            this.YazarEkleHeaderPanel.Size = new System.Drawing.Size(661, 84);
            this.YazarEkleHeaderPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yazar Ekle";
            // 
            // YazarEkleCikisBtn
            // 
            this.YazarEkleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.YazarEkleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YazarEkleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.YazarEkleCikisBtn.Location = new System.Drawing.Point(607, 27);
            this.YazarEkleCikisBtn.Name = "YazarEkleCikisBtn";
            this.YazarEkleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.YazarEkleCikisBtn.TabIndex = 6;
            this.YazarEkleCikisBtn.Text = "X";
            this.YazarEkleCikisBtn.UseVisualStyleBackColor = false;
            this.YazarEkleCikisBtn.Click += new System.EventHandler(this.YazarEkleCikisBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Yazar Soyadı";
            // 
            // yazarSoyadiTxt
            // 
            this.yazarSoyadiTxt.Location = new System.Drawing.Point(37, 122);
            this.yazarSoyadiTxt.Name = "yazarSoyadiTxt";
            this.yazarSoyadiTxt.Size = new System.Drawing.Size(157, 23);
            this.yazarSoyadiTxt.TabIndex = 22;
            // 
            // yazarAciklamaRtb
            // 
            this.yazarAciklamaRtb.Location = new System.Drawing.Point(229, 58);
            this.yazarAciklamaRtb.Name = "yazarAciklamaRtb";
            this.yazarAciklamaRtb.Size = new System.Drawing.Size(165, 151);
            this.yazarAciklamaRtb.TabIndex = 24;
            this.yazarAciklamaRtb.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Yazar Açıklama";
            // 
            // YazarEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.YazarEkleContentPanel);
            this.Controls.Add(this.YazarEkleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YazarEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazarEkleForm";
            this.Load += new System.EventHandler(this.YazarEkleForm_Load);
            this.YazarEkleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.YazarEkleHeaderPanel.ResumeLayout(false);
            this.YazarEkleHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel YazarEkleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yazarDurumCb;
        private System.Windows.Forms.TextBox yazarAdiTxt;
        private System.Windows.Forms.Button yazarEkleBtn;
        private System.Windows.Forms.Panel YazarEkleHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YazarEkleCikisBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox yazarAciklamaRtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yazarSoyadiTxt;
    }
}