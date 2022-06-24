
namespace WinFormsApp1
{
    partial class uyeOduncVerilenForm
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
            this.üyeoduncekrantc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.verilenkitaplardgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gecikenkitaplardgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.teslimedilenkitapdgv = new System.Windows.Forms.DataGridView();
            this.üyeDuzenleHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.kitapDuzenleCikisBtn = new System.Windows.Forms.Button();
            this.üyeDuzenleContentPanel = new System.Windows.Forms.Panel();
            this.üyeoduncekrantc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verilenkitaplardgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecikenkitaplardgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teslimedilenkitapdgv)).BeginInit();
            this.üyeDuzenleHeaderPanel.SuspendLayout();
            this.üyeDuzenleContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // üyeoduncekrantc
            // 
            this.üyeoduncekrantc.Controls.Add(this.tabPage1);
            this.üyeoduncekrantc.Controls.Add(this.tabPage2);
            this.üyeoduncekrantc.Controls.Add(this.tabPage3);
            this.üyeoduncekrantc.Location = new System.Drawing.Point(3, 3);
            this.üyeoduncekrantc.Name = "üyeoduncekrantc";
            this.üyeoduncekrantc.SelectedIndex = 0;
            this.üyeoduncekrantc.Size = new System.Drawing.Size(654, 307);
            this.üyeoduncekrantc.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.verilenkitaplardgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verilen Kitaplar";
            // 
            // verilenkitaplardgv
            // 
            this.verilenkitaplardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verilenkitaplardgv.Location = new System.Drawing.Point(3, 3);
            this.verilenkitaplardgv.Name = "verilenkitaplardgv";
            this.verilenkitaplardgv.RowTemplate.Height = 25;
            this.verilenkitaplardgv.Size = new System.Drawing.Size(640, 273);
            this.verilenkitaplardgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gecikenkitaplardgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geciken Kitaplar";
            // 
            // gecikenkitaplardgv
            // 
            this.gecikenkitaplardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gecikenkitaplardgv.Location = new System.Drawing.Point(0, 3);
            this.gecikenkitaplardgv.Name = "gecikenkitaplardgv";
            this.gecikenkitaplardgv.RowTemplate.Height = 25;
            this.gecikenkitaplardgv.Size = new System.Drawing.Size(640, 270);
            this.gecikenkitaplardgv.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.teslimedilenkitapdgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Teslim Edilen Kitaplar";
            // 
            // teslimedilenkitapdgv
            // 
            this.teslimedilenkitapdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teslimedilenkitapdgv.Location = new System.Drawing.Point(4, 4);
            this.teslimedilenkitapdgv.Name = "teslimedilenkitapdgv";
            this.teslimedilenkitapdgv.RowTemplate.Height = 25;
            this.teslimedilenkitapdgv.Size = new System.Drawing.Size(639, 269);
            this.teslimedilenkitapdgv.TabIndex = 0;
            // 
            // üyeDuzenleHeaderPanel
            // 
            this.üyeDuzenleHeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.üyeDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.üyeDuzenleHeaderPanel.Controls.Add(this.kitapDuzenleCikisBtn);
            this.üyeDuzenleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.üyeDuzenleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.üyeDuzenleHeaderPanel.Name = "üyeDuzenleHeaderPanel";
            this.üyeDuzenleHeaderPanel.Size = new System.Drawing.Size(654, 80);
            this.üyeDuzenleHeaderPanel.TabIndex = 6;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(26, 25);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(169, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Üye Kitap Listesi";
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
            this.üyeDuzenleContentPanel.Controls.Add(this.üyeoduncekrantc);
            this.üyeDuzenleContentPanel.Location = new System.Drawing.Point(0, 87);
            this.üyeDuzenleContentPanel.Name = "üyeDuzenleContentPanel";
            this.üyeDuzenleContentPanel.Size = new System.Drawing.Size(654, 307);
            this.üyeDuzenleContentPanel.TabIndex = 7;
            // 
            // OduncVerilenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 395);
            this.Controls.Add(this.üyeDuzenleContentPanel);
            this.Controls.Add(this.üyeDuzenleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OduncVerilenForm";
            this.Text = "uyeOduncForm";
            this.Load += new System.EventHandler(this.OduncVerilenForm_Load);
            this.üyeoduncekrantc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verilenkitaplardgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gecikenkitaplardgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teslimedilenkitapdgv)).EndInit();
            this.üyeDuzenleHeaderPanel.ResumeLayout(false);
            this.üyeDuzenleHeaderPanel.PerformLayout();
            this.üyeDuzenleContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl üyeoduncekrantc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel üyeDuzenleHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button kitapDuzenleCikisBtn;
        private System.Windows.Forms.DataGridView verilenkitaplardgv;
        private System.Windows.Forms.DataGridView gecikenkitaplardgv;
        private System.Windows.Forms.DataGridView teslimedilenkitapdgv;
        private System.Windows.Forms.Panel üyeDuzenleContentPanel;
    }
}