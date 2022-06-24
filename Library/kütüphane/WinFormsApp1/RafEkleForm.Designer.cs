
namespace WinFormsApp1
{
    partial class RafEkleForm
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
            this.RafEkleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rafDurumCb = new System.Windows.Forms.ComboBox();
            this.rafAdiTxt = new System.Windows.Forms.TextBox();
            this.rafEkleBtn = new System.Windows.Forms.Button();
            this.RafEkleHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RafEkleCikisBtn = new System.Windows.Forms.Button();
            this.RafEkleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RafEkleHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RafEkleContentPanel
            // 
            this.RafEkleContentPanel.Controls.Add(this.groupBox1);
            this.RafEkleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RafEkleContentPanel.Location = new System.Drawing.Point(0, 97);
            this.RafEkleContentPanel.Name = "RafEkleContentPanel";
            this.RafEkleContentPanel.Size = new System.Drawing.Size(259, 314);
            this.RafEkleContentPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rafDurumCb);
            this.groupBox1.Controls.Add(this.rafAdiTxt);
            this.groupBox1.Controls.Add(this.rafEkleBtn);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raf Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Raf Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Raf Adı";
            // 
            // rafDurumCb
            // 
            this.rafDurumCb.FormattingEnabled = true;
            this.rafDurumCb.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.rafDurumCb.Location = new System.Drawing.Point(37, 121);
            this.rafDurumCb.Name = "rafDurumCb";
            this.rafDurumCb.Size = new System.Drawing.Size(157, 23);
            this.rafDurumCb.TabIndex = 19;
            // 
            // rafAdiTxt
            // 
            this.rafAdiTxt.Location = new System.Drawing.Point(37, 58);
            this.rafAdiTxt.Name = "rafAdiTxt";
            this.rafAdiTxt.Size = new System.Drawing.Size(157, 23);
            this.rafAdiTxt.TabIndex = 18;
            // 
            // rafEkleBtn
            // 
            this.rafEkleBtn.BackColor = System.Drawing.Color.Green;
            this.rafEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rafEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rafEkleBtn.ForeColor = System.Drawing.Color.White;
            this.rafEkleBtn.Location = new System.Drawing.Point(37, 171);
            this.rafEkleBtn.Name = "rafEkleBtn";
            this.rafEkleBtn.Size = new System.Drawing.Size(157, 80);
            this.rafEkleBtn.TabIndex = 17;
            this.rafEkleBtn.Text = "Raf Ekle";
            this.rafEkleBtn.UseVisualStyleBackColor = false;
            this.rafEkleBtn.Click += new System.EventHandler(this.rafEkleBtn_Click);
            // 
            // RafEkleHeaderPanel
            // 
            this.RafEkleHeaderPanel.Controls.Add(this.label1);
            this.RafEkleHeaderPanel.Controls.Add(this.RafEkleCikisBtn);
            this.RafEkleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RafEkleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.RafEkleHeaderPanel.Name = "RafEkleHeaderPanel";
            this.RafEkleHeaderPanel.Size = new System.Drawing.Size(259, 84);
            this.RafEkleHeaderPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Raf Ekle";
            // 
            // RafEkleCikisBtn
            // 
            this.RafEkleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.RafEkleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RafEkleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.RafEkleCikisBtn.Location = new System.Drawing.Point(215, 27);
            this.RafEkleCikisBtn.Name = "RafEkleCikisBtn";
            this.RafEkleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.RafEkleCikisBtn.TabIndex = 6;
            this.RafEkleCikisBtn.Text = "X";
            this.RafEkleCikisBtn.UseVisualStyleBackColor = false;
            this.RafEkleCikisBtn.Click += new System.EventHandler(this.RafEkleCikisBtn_Click);
            // 
            // RafEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(259, 411);
            this.Controls.Add(this.RafEkleContentPanel);
            this.Controls.Add(this.RafEkleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RafEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RafEkleForm";
            this.Load += new System.EventHandler(this.RafEkleForm_Load);
            this.RafEkleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RafEkleHeaderPanel.ResumeLayout(false);
            this.RafEkleHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RafEkleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rafDurumCb;
        private System.Windows.Forms.TextBox rafAdiTxt;
        private System.Windows.Forms.Button rafEkleBtn;
        private System.Windows.Forms.Panel RafEkleHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RafEkleCikisBtn;
    }
}