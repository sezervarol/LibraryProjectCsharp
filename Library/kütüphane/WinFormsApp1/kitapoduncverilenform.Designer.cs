
namespace WinFormsApp1
{
    partial class kitapoduncverilenform
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
            this.kitapoduncekrantc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.oduncverilenkitaplardgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.oduncgecikenkitaplardgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.oduncteslimedilenkitapdgv = new System.Windows.Forms.DataGridView();
            this.kitapoduncHeaderPanel = new System.Windows.Forms.Panel();
            this.kitapDuzenleLbl = new System.Windows.Forms.Label();
            this.kitapDuzenleCikisBtn = new System.Windows.Forms.Button();
            this.kitapodunccontentPanel = new System.Windows.Forms.Panel();
            this.kitapoduncekrantc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oduncverilenkitaplardgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oduncgecikenkitaplardgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oduncteslimedilenkitapdgv)).BeginInit();
            this.kitapoduncHeaderPanel.SuspendLayout();
            this.kitapodunccontentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitapoduncekrantc
            // 
            this.kitapoduncekrantc.Controls.Add(this.tabPage1);
            this.kitapoduncekrantc.Controls.Add(this.tabPage2);
            this.kitapoduncekrantc.Controls.Add(this.tabPage3);
            this.kitapoduncekrantc.Location = new System.Drawing.Point(3, 3);
            this.kitapoduncekrantc.Name = "kitapoduncekrantc";
            this.kitapoduncekrantc.SelectedIndex = 0;
            this.kitapoduncekrantc.Size = new System.Drawing.Size(644, 307);
            this.kitapoduncekrantc.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.oduncverilenkitaplardgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verilen Kitaplar";
            // 
            // oduncverilenkitaplardgv
            // 
            this.oduncverilenkitaplardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncverilenkitaplardgv.Location = new System.Drawing.Point(3, 3);
            this.oduncverilenkitaplardgv.Name = "oduncverilenkitaplardgv";
            this.oduncverilenkitaplardgv.RowTemplate.Height = 25;
            this.oduncverilenkitaplardgv.Size = new System.Drawing.Size(640, 273);
            this.oduncverilenkitaplardgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.oduncgecikenkitaplardgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geciken Kitaplar";
            // 
            // oduncgecikenkitaplardgv
            // 
            this.oduncgecikenkitaplardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncgecikenkitaplardgv.Location = new System.Drawing.Point(0, 3);
            this.oduncgecikenkitaplardgv.Name = "oduncgecikenkitaplardgv";
            this.oduncgecikenkitaplardgv.RowTemplate.Height = 25;
            this.oduncgecikenkitaplardgv.Size = new System.Drawing.Size(640, 270);
            this.oduncgecikenkitaplardgv.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.oduncteslimedilenkitapdgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Teslim Edilen Kitaplar";
            // 
            // oduncteslimedilenkitapdgv
            // 
            this.oduncteslimedilenkitapdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncteslimedilenkitapdgv.Location = new System.Drawing.Point(4, 4);
            this.oduncteslimedilenkitapdgv.Name = "oduncteslimedilenkitapdgv";
            this.oduncteslimedilenkitapdgv.RowTemplate.Height = 25;
            this.oduncteslimedilenkitapdgv.Size = new System.Drawing.Size(639, 269);
            this.oduncteslimedilenkitapdgv.TabIndex = 0;
            // 
            // kitapoduncHeaderPanel
            // 
            this.kitapoduncHeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.kitapoduncHeaderPanel.Controls.Add(this.kitapDuzenleLbl);
            this.kitapoduncHeaderPanel.Controls.Add(this.kitapDuzenleCikisBtn);
            this.kitapoduncHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitapoduncHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.kitapoduncHeaderPanel.Name = "kitapoduncHeaderPanel";
            this.kitapoduncHeaderPanel.Size = new System.Drawing.Size(658, 80);
            this.kitapoduncHeaderPanel.TabIndex = 8;
            // 
            // kitapDuzenleLbl
            // 
            this.kitapDuzenleLbl.AutoSize = true;
            this.kitapDuzenleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.kitapDuzenleLbl.Location = new System.Drawing.Point(26, 25);
            this.kitapDuzenleLbl.Name = "kitapDuzenleLbl";
            this.kitapDuzenleLbl.Size = new System.Drawing.Size(127, 28);
            this.kitapDuzenleLbl.TabIndex = 6;
            this.kitapDuzenleLbl.Text = "Kitap Listesi";
            // 
            // kitapDuzenleCikisBtn
            // 
            this.kitapDuzenleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.kitapDuzenleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapDuzenleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.kitapDuzenleCikisBtn.Location = new System.Drawing.Point(615, 28);
            this.kitapDuzenleCikisBtn.Name = "kitapDuzenleCikisBtn";
            this.kitapDuzenleCikisBtn.Size = new System.Drawing.Size(32, 31);
            this.kitapDuzenleCikisBtn.TabIndex = 5;
            this.kitapDuzenleCikisBtn.Text = "X";
            this.kitapDuzenleCikisBtn.UseVisualStyleBackColor = false;
            this.kitapDuzenleCikisBtn.Click += new System.EventHandler(this.kitapDuzenleCikisBtn_Click);
            // 
            // kitapodunccontentPanel
            // 
            this.kitapodunccontentPanel.Controls.Add(this.kitapoduncekrantc);
            this.kitapodunccontentPanel.Location = new System.Drawing.Point(0, 87);
            this.kitapodunccontentPanel.Name = "kitapodunccontentPanel";
            this.kitapodunccontentPanel.Size = new System.Drawing.Size(650, 313);
            this.kitapodunccontentPanel.TabIndex = 9;
            // 
            // kitapoduncverilenform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 412);
            this.Controls.Add(this.kitapodunccontentPanel);
            this.Controls.Add(this.kitapoduncHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitapoduncverilenform";
            this.Text = "kitapoduncverilenform";
            this.Load += new System.EventHandler(this.kitapoduncverilenform_Load);
            this.kitapoduncekrantc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oduncverilenkitaplardgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oduncgecikenkitaplardgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oduncteslimedilenkitapdgv)).EndInit();
            this.kitapoduncHeaderPanel.ResumeLayout(false);
            this.kitapoduncHeaderPanel.PerformLayout();
            this.kitapodunccontentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl kitapoduncekrantc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView oduncverilenkitaplardgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView oduncgecikenkitaplardgv;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView oduncteslimedilenkitapdgv;
        private System.Windows.Forms.Panel kitapoduncHeaderPanel;
        private System.Windows.Forms.Label kitapDuzenleLbl;
        private System.Windows.Forms.Button kitapDuzenleCikisBtn;
        private System.Windows.Forms.Panel kitapodunccontentPanel;
    }
}