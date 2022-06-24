
namespace WinFormsApp1
{
    partial class TurEkleForm
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
            this.TurEkleHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TurEkleCikisBtn = new System.Windows.Forms.Button();
            this.TurEkleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turDurumCb = new System.Windows.Forms.ComboBox();
            this.turAdiTxt = new System.Windows.Forms.TextBox();
            this.turEkleBtn = new System.Windows.Forms.Button();
            this.TurEkleHeaderPanel.SuspendLayout();
            this.TurEkleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurEkleHeaderPanel
            // 
            this.TurEkleHeaderPanel.Controls.Add(this.label1);
            this.TurEkleHeaderPanel.Controls.Add(this.TurEkleCikisBtn);
            this.TurEkleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TurEkleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.TurEkleHeaderPanel.Name = "TurEkleHeaderPanel";
            this.TurEkleHeaderPanel.Size = new System.Drawing.Size(275, 100);
            this.TurEkleHeaderPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tür Ekle";
            // 
            // TurEkleCikisBtn
            // 
            this.TurEkleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.TurEkleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurEkleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.TurEkleCikisBtn.Location = new System.Drawing.Point(221, 31);
            this.TurEkleCikisBtn.Name = "TurEkleCikisBtn";
            this.TurEkleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.TurEkleCikisBtn.TabIndex = 6;
            this.TurEkleCikisBtn.Text = "X";
            this.TurEkleCikisBtn.UseVisualStyleBackColor = false;
            this.TurEkleCikisBtn.Click += new System.EventHandler(this.TurEkleCikisBtn_Click);
            // 
            // TurEkleContentPanel
            // 
            this.TurEkleContentPanel.Controls.Add(this.groupBox1);
            this.TurEkleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TurEkleContentPanel.Location = new System.Drawing.Point(0, 124);
            this.TurEkleContentPanel.Name = "TurEkleContentPanel";
            this.TurEkleContentPanel.Size = new System.Drawing.Size(275, 326);
            this.TurEkleContentPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.turDurumCb);
            this.groupBox1.Controls.Add(this.turAdiTxt);
            this.groupBox1.Controls.Add(this.turEkleBtn);
            this.groupBox1.Location = new System.Drawing.Point(25, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tür Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tür Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tür Adı";
            // 
            // turDurumCb
            // 
            this.turDurumCb.FormattingEnabled = true;
            this.turDurumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.turDurumCb.Location = new System.Drawing.Point(37, 121);
            this.turDurumCb.Name = "turDurumCb";
            this.turDurumCb.Size = new System.Drawing.Size(157, 23);
            this.turDurumCb.TabIndex = 19;
            // 
            // turAdiTxt
            // 
            this.turAdiTxt.Location = new System.Drawing.Point(37, 58);
            this.turAdiTxt.Name = "turAdiTxt";
            this.turAdiTxt.Size = new System.Drawing.Size(157, 23);
            this.turAdiTxt.TabIndex = 18;
            // 
            // turEkleBtn
            // 
            this.turEkleBtn.BackColor = System.Drawing.Color.Green;
            this.turEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.turEkleBtn.ForeColor = System.Drawing.Color.White;
            this.turEkleBtn.Location = new System.Drawing.Point(37, 171);
            this.turEkleBtn.Name = "turEkleBtn";
            this.turEkleBtn.Size = new System.Drawing.Size(157, 80);
            this.turEkleBtn.TabIndex = 17;
            this.turEkleBtn.Text = "Tür Ekle";
            this.turEkleBtn.UseVisualStyleBackColor = false;
            this.turEkleBtn.Click += new System.EventHandler(this.turEkleBtn_Click);
            // 
            // TurEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.TurEkleContentPanel);
            this.Controls.Add(this.TurEkleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TurEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurEkleForm";
            this.Load += new System.EventHandler(this.TurEkleForm_Load);
            this.TurEkleHeaderPanel.ResumeLayout(false);
            this.TurEkleHeaderPanel.PerformLayout();
            this.TurEkleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TurEkleHeaderPanel;
        private System.Windows.Forms.Panel TurEkleContentPanel;
        private System.Windows.Forms.Button TurEkleCikisBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button turEkleBtn;
        private System.Windows.Forms.ComboBox turDurumCb;
        private System.Windows.Forms.TextBox turAdiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}