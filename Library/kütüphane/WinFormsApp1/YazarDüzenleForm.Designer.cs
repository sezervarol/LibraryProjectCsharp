
namespace WinFormsApp1
{
    partial class YazarDüzenleForm
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
            this.yazarDuzenleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.kitapDuzenleCikisBtn = new System.Windows.Forms.Button();
            this.yazarDuzenleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yazaradtxt = new System.Windows.Forms.TextBox();
            this.yazarSilBtn = new System.Windows.Forms.Button();
            this.yazarDuzenleBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yazardurumCb = new System.Windows.Forms.ComboBox();
            this.yazaraciklamaRtb = new System.Windows.Forms.RichTextBox();
            this.yazarsoyadıxt = new System.Windows.Forms.TextBox();
            this.yazarDuzenleHeaderPanel.SuspendLayout();
            this.yazarDuzenleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yazarDuzenleHeaderPanel
            // 
            this.yazarDuzenleHeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.yazarDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.yazarDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleCikisBtn);
            this.yazarDuzenleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.yazarDuzenleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.yazarDuzenleHeaderPanel.Name = "yazarDuzenleHeaderPanel";
            this.yazarDuzenleHeaderPanel.Size = new System.Drawing.Size(419, 80);
            this.yazarDuzenleHeaderPanel.TabIndex = 3;
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
            this.kitapDuzenleLbl.Text = "Yazar Düzenle";
            // 
            // kitapDuzenleCikisBtn
            // 
            this.kitapDuzenleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.kitapDuzenleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.kitapDuzenleCikisBtn.Location = new System.Drawing.Point(349, 22);
            this.kitapDuzenleCikisBtn.Name = "kitapDuzenleCikisBtn";
            this.kitapDuzenleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.kitapDuzenleCikisBtn.TabIndex = 5;
            this.kitapDuzenleCikisBtn.Text = "X";
            this.kitapDuzenleCikisBtn.UseVisualStyleBackColor = false;
            this.kitapDuzenleCikisBtn.Click += new System.EventHandler(this.kitapDuzenleCikisBtn_Click);
            // 
            // yazarDuzenleContentPanel
            // 
            this.yazarDuzenleContentPanel.Controls.Add(this.groupBox1);
            this.yazarDuzenleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yazarDuzenleContentPanel.Location = new System.Drawing.Point(0, 108);
            this.yazarDuzenleContentPanel.Name = "yazarDuzenleContentPanel";
            this.yazarDuzenleContentPanel.Size = new System.Drawing.Size(419, 355);
            this.yazarDuzenleContentPanel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yazaradtxt);
            this.groupBox1.Controls.Add(this.yazarSilBtn);
            this.groupBox1.Controls.Add(this.yazarDuzenleBtn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.yazardurumCb);
            this.groupBox1.Controls.Add(this.yazaraciklamaRtb);
            this.groupBox1.Controls.Add(this.yazarsoyadıxt);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Yazar Adı";
            // 
            // yazaradtxt
            // 
            this.yazaradtxt.Location = new System.Drawing.Point(16, 44);
            this.yazaradtxt.Name = "yazaradtxt";
            this.yazaradtxt.Size = new System.Drawing.Size(100, 23);
            this.yazaradtxt.TabIndex = 19;
            // 
            // yazarSilBtn
            // 
            this.yazarSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yazarSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yazarSilBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yazarSilBtn.ForeColor = System.Drawing.Color.White;
            this.yazarSilBtn.Location = new System.Drawing.Point(255, 184);
            this.yazarSilBtn.Name = "yazarSilBtn";
            this.yazarSilBtn.Size = new System.Drawing.Size(100, 80);
            this.yazarSilBtn.TabIndex = 17;
            this.yazarSilBtn.Text = "Yazar Sil";
            this.yazarSilBtn.UseVisualStyleBackColor = false;
            this.yazarSilBtn.Click += new System.EventHandler(this.yazarSilBtn_Click);
            // 
            // yazarDuzenleBtn
            // 
            this.yazarDuzenleBtn.BackColor = System.Drawing.Color.Green;
            this.yazarDuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yazarDuzenleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yazarDuzenleBtn.ForeColor = System.Drawing.Color.White;
            this.yazarDuzenleBtn.Location = new System.Drawing.Point(255, 107);
            this.yazarDuzenleBtn.Name = "yazarDuzenleBtn";
            this.yazarDuzenleBtn.Size = new System.Drawing.Size(100, 71);
            this.yazarDuzenleBtn.TabIndex = 16;
            this.yazarDuzenleBtn.Text = "Yazar Düzenle";
            this.yazarDuzenleBtn.UseVisualStyleBackColor = false;
            this.yazarDuzenleBtn.Click += new System.EventHandler(this.yazarDuzenleBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Durum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yazar Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazar Soyadı";
            // 
            // yazardurumCb
            // 
            this.yazardurumCb.FormattingEnabled = true;
            this.yazardurumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.yazardurumCb.Location = new System.Drawing.Point(122, 44);
            this.yazardurumCb.Name = "yazardurumCb";
            this.yazardurumCb.Size = new System.Drawing.Size(100, 23);
            this.yazardurumCb.TabIndex = 7;
            // 
            // yazaraciklamaRtb
            // 
            this.yazaraciklamaRtb.Location = new System.Drawing.Point(1, 145);
            this.yazaraciklamaRtb.Name = "yazaraciklamaRtb";
            this.yazaraciklamaRtb.Size = new System.Drawing.Size(185, 163);
            this.yazaraciklamaRtb.TabIndex = 5;
            this.yazaraciklamaRtb.Text = "";
            // 
            // yazarsoyadıxt
            // 
            this.yazarsoyadıxt.Location = new System.Drawing.Point(16, 100);
            this.yazarsoyadıxt.Name = "yazarsoyadıxt";
            this.yazarsoyadıxt.Size = new System.Drawing.Size(100, 23);
            this.yazarsoyadıxt.TabIndex = 1;
            // 
            // YazarDüzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(419, 463);
            this.Controls.Add(this.yazarDuzenleContentPanel);
            this.Controls.Add(this.yazarDuzenleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YazarDüzenleForm";
            this.Text = "YazarDüzenleForm";
            this.Load += new System.EventHandler(this.YazarDüzenleForm_Load);
            this.yazarDuzenleHeaderPanel.ResumeLayout(false);
            this.yazarDuzenleHeaderPanel.PerformLayout();
            this.yazarDuzenleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel yazarDuzenleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button kitapDuzenleCikisBtn;
        private System.Windows.Forms.Panel yazarDuzenleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yazarSilBtn;
        private System.Windows.Forms.Button yazarDuzenleBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yazardurumCb;
        private System.Windows.Forms.RichTextBox yazaraciklamaRtb;
        private System.Windows.Forms.TextBox yazarsoyadıxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yazaradtxt;
    }
}