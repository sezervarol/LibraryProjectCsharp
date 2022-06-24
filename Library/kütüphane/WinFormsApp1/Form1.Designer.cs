
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kutuphaneTc = new System.Windows.Forms.TabControl();
            this.kitaplarTp = new System.Windows.Forms.TabPage();
            this.kitapAraPanel = new System.Windows.Forms.Panel();
            this.araTemizlemeBtn = new System.Windows.Forms.Button();
            this.kitapAraBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rafCb = new System.Windows.Forms.ComboBox();
            this.kitapTurCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yazarAdTxt = new System.Windows.Forms.TextBox();
            this.kitapAdTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.kitapDgv = new System.Windows.Forms.DataGridView();
            this.yazarlarTp = new System.Windows.Forms.TabPage();
            this.yazarAraPanel = new System.Windows.Forms.Panel();
            this.yazarAraTemizleBtn = new System.Windows.Forms.Button();
            this.yazarAraBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yazarSoyadAraTxt = new System.Windows.Forms.TextBox();
            this.yazarAdAraTxt = new System.Windows.Forms.TextBox();
            this.yazarlarDgv = new System.Windows.Forms.DataGridView();
            this.uyelerTp = new System.Windows.Forms.TabPage();
            this.uyeAraPanel = new System.Windows.Forms.Panel();
            this.uyeemailtxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.uyeTCNotxt = new System.Windows.Forms.TextBox();
            this.uyeSoyadtxt = new System.Windows.Forms.TextBox();
            this.uyeAdtxt = new System.Windows.Forms.TextBox();
            this.uyelerDgv = new System.Windows.Forms.DataGridView();
            this.ayarlarTp = new System.Windows.Forms.TabPage();
            this.personelEkleBtn = new System.Windows.Forms.Button();
            this.uyeEkleBtn = new System.Windows.Forms.Button();
            this.yazarEkleBtn = new System.Windows.Forms.Button();
            this.rafEkleBtn = new System.Windows.Forms.Button();
            this.turEkleBtn = new System.Windows.Forms.Button();
            this.kitapEkleBtn = new System.Windows.Forms.Button();
            this.kitapOduncTp = new System.Windows.Forms.TabPage();
            this.odunVerPanel = new System.Windows.Forms.Panel();
            this.oduncContentPanel = new System.Windows.Forms.Panel();
            this.oduncKitapAlbtn = new System.Windows.Forms.Button();
            this.oduncverilenlerbtn = new System.Windows.Forms.Button();
            this.kitapVerBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uyeAdiOduncTxt = new System.Windows.Forms.TextBox();
            this.kitapAdiOduncTxt = new System.Windows.Forms.TextBox();
            this.oduncHeaderPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.kitapUyePanel = new System.Windows.Forms.Panel();
            this.oduncUyeDgv = new System.Windows.Forms.DataGridView();
            this.oduncKitapDgv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullaniciLbl = new System.Windows.Forms.Label();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kutuphaneTc.SuspendLayout();
            this.kitaplarTp.SuspendLayout();
            this.kitapAraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDgv)).BeginInit();
            this.yazarlarTp.SuspendLayout();
            this.yazarAraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDgv)).BeginInit();
            this.uyelerTp.SuspendLayout();
            this.uyeAraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDgv)).BeginInit();
            this.ayarlarTp.SuspendLayout();
            this.kitapOduncTp.SuspendLayout();
            this.odunVerPanel.SuspendLayout();
            this.oduncContentPanel.SuspendLayout();
            this.oduncHeaderPanel.SuspendLayout();
            this.kitapUyePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oduncUyeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneTc
            // 
            this.kutuphaneTc.Controls.Add(this.kitaplarTp);
            this.kutuphaneTc.Controls.Add(this.yazarlarTp);
            this.kutuphaneTc.Controls.Add(this.uyelerTp);
            this.kutuphaneTc.Controls.Add(this.ayarlarTp);
            this.kutuphaneTc.Controls.Add(this.kitapOduncTp);
            this.kutuphaneTc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kutuphaneTc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kutuphaneTc.Location = new System.Drawing.Point(0, 84);
            this.kutuphaneTc.Name = "kutuphaneTc";
            this.kutuphaneTc.SelectedIndex = 0;
            this.kutuphaneTc.Size = new System.Drawing.Size(1064, 415);
            this.kutuphaneTc.TabIndex = 0;
            // 
            // kitaplarTp
            // 
            this.kitaplarTp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kitaplarTp.Controls.Add(this.kitapAraPanel);
            this.kitaplarTp.Controls.Add(this.kitapDgv);
            this.kitaplarTp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitaplarTp.Location = new System.Drawing.Point(4, 26);
            this.kitaplarTp.Name = "kitaplarTp";
            this.kitaplarTp.Padding = new System.Windows.Forms.Padding(3);
            this.kitaplarTp.Size = new System.Drawing.Size(1056, 385);
            this.kitaplarTp.TabIndex = 2;
            this.kitaplarTp.Text = "Kitaplar";
            // 
            // kitapAraPanel
            // 
            this.kitapAraPanel.Controls.Add(this.araTemizlemeBtn);
            this.kitapAraPanel.Controls.Add(this.kitapAraBtn);
            this.kitapAraPanel.Controls.Add(this.label5);
            this.kitapAraPanel.Controls.Add(this.rafCb);
            this.kitapAraPanel.Controls.Add(this.kitapTurCb);
            this.kitapAraPanel.Controls.Add(this.label4);
            this.kitapAraPanel.Controls.Add(this.label3);
            this.kitapAraPanel.Controls.Add(this.label2);
            this.kitapAraPanel.Controls.Add(this.label1);
            this.kitapAraPanel.Controls.Add(this.yazarAdTxt);
            this.kitapAraPanel.Controls.Add(this.kitapAdTxt);
            this.kitapAraPanel.Controls.Add(this.isbnTxt);
            this.kitapAraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kitapAraPanel.Location = new System.Drawing.Point(3, 3);
            this.kitapAraPanel.Name = "kitapAraPanel";
            this.kitapAraPanel.Size = new System.Drawing.Size(1050, 79);
            this.kitapAraPanel.TabIndex = 1;
            // 
            // araTemizlemeBtn
            // 
            this.araTemizlemeBtn.Image = global::WinFormsApp1.Properties.Resources.delete_button;
            this.araTemizlemeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.araTemizlemeBtn.Location = new System.Drawing.Point(684, 25);
            this.araTemizlemeBtn.Name = "araTemizlemeBtn";
            this.araTemizlemeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.araTemizlemeBtn.Size = new System.Drawing.Size(119, 43);
            this.araTemizlemeBtn.TabIndex = 13;
            this.araTemizlemeBtn.Text = "Temizle";
            this.araTemizlemeBtn.UseVisualStyleBackColor = true;
            this.araTemizlemeBtn.Click += new System.EventHandler(this.araTemizlemeBtn_Click);
            // 
            // kitapAraBtn
            // 
            this.kitapAraBtn.Image = global::WinFormsApp1.Properties.Resources.book__1_;
            this.kitapAraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapAraBtn.Location = new System.Drawing.Point(546, 24);
            this.kitapAraBtn.Name = "kitapAraBtn";
            this.kitapAraBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kitapAraBtn.Size = new System.Drawing.Size(131, 44);
            this.kitapAraBtn.TabIndex = 12;
            this.kitapAraBtn.Text = "Kitap Ara";
            this.kitapAraBtn.UseVisualStyleBackColor = true;
            this.kitapAraBtn.Click += new System.EventHandler(this.kitapAraBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Raf";
            // 
            // rafCb
            // 
            this.rafCb.FormattingEnabled = true;
            this.rafCb.Location = new System.Drawing.Point(438, 43);
            this.rafCb.Name = "rafCb";
            this.rafCb.Size = new System.Drawing.Size(91, 23);
            this.rafCb.TabIndex = 10;
            // 
            // kitapTurCb
            // 
            this.kitapTurCb.FormattingEnabled = true;
            this.kitapTurCb.Location = new System.Drawing.Point(341, 43);
            this.kitapTurCb.Name = "kitapTurCb";
            this.kitapTurCb.Size = new System.Drawing.Size(91, 23);
            this.kitapTurCb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISBN NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yazar Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap Adı";
            // 
            // yazarAdTxt
            // 
            this.yazarAdTxt.Location = new System.Drawing.Point(234, 43);
            this.yazarAdTxt.Name = "yazarAdTxt";
            this.yazarAdTxt.Size = new System.Drawing.Size(100, 23);
            this.yazarAdTxt.TabIndex = 2;
            // 
            // kitapAdTxt
            // 
            this.kitapAdTxt.Location = new System.Drawing.Point(128, 43);
            this.kitapAdTxt.Name = "kitapAdTxt";
            this.kitapAdTxt.Size = new System.Drawing.Size(100, 23);
            this.kitapAdTxt.TabIndex = 1;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(22, 43);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(100, 23);
            this.isbnTxt.TabIndex = 0;
            // 
            // kitapDgv
            // 
            this.kitapDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kitapDgv.Location = new System.Drawing.Point(3, 134);
            this.kitapDgv.Name = "kitapDgv";
            this.kitapDgv.RowTemplate.Height = 25;
            this.kitapDgv.Size = new System.Drawing.Size(1050, 248);
            this.kitapDgv.TabIndex = 0;
            this.kitapDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapDgv_CellDoubleClick);
            // 
            // yazarlarTp
            // 
            this.yazarlarTp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.yazarlarTp.Controls.Add(this.yazarAraPanel);
            this.yazarlarTp.Controls.Add(this.yazarlarDgv);
            this.yazarlarTp.Location = new System.Drawing.Point(4, 26);
            this.yazarlarTp.Name = "yazarlarTp";
            this.yazarlarTp.Padding = new System.Windows.Forms.Padding(3);
            this.yazarlarTp.Size = new System.Drawing.Size(1056, 385);
            this.yazarlarTp.TabIndex = 3;
            this.yazarlarTp.Text = "Yazarlar";
            // 
            // yazarAraPanel
            // 
            this.yazarAraPanel.Controls.Add(this.yazarAraTemizleBtn);
            this.yazarAraPanel.Controls.Add(this.yazarAraBtn);
            this.yazarAraPanel.Controls.Add(this.label7);
            this.yazarAraPanel.Controls.Add(this.label10);
            this.yazarAraPanel.Controls.Add(this.yazarSoyadAraTxt);
            this.yazarAraPanel.Controls.Add(this.yazarAdAraTxt);
            this.yazarAraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.yazarAraPanel.Location = new System.Drawing.Point(3, 3);
            this.yazarAraPanel.Name = "yazarAraPanel";
            this.yazarAraPanel.Size = new System.Drawing.Size(1050, 79);
            this.yazarAraPanel.TabIndex = 3;
            // 
            // yazarAraTemizleBtn
            // 
            this.yazarAraTemizleBtn.Image = global::WinFormsApp1.Properties.Resources.delete_button;
            this.yazarAraTemizleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yazarAraTemizleBtn.Location = new System.Drawing.Point(379, 25);
            this.yazarAraTemizleBtn.Name = "yazarAraTemizleBtn";
            this.yazarAraTemizleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.yazarAraTemizleBtn.Size = new System.Drawing.Size(119, 43);
            this.yazarAraTemizleBtn.TabIndex = 13;
            this.yazarAraTemizleBtn.Text = "Temizle";
            this.yazarAraTemizleBtn.UseVisualStyleBackColor = true;
            this.yazarAraTemizleBtn.Click += new System.EventHandler(this.yazarAraTemizleBtn_Click);
            // 
            // yazarAraBtn
            // 
            this.yazarAraBtn.Image = global::WinFormsApp1.Properties.Resources.book__1_;
            this.yazarAraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yazarAraBtn.Location = new System.Drawing.Point(241, 24);
            this.yazarAraBtn.Name = "yazarAraBtn";
            this.yazarAraBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.yazarAraBtn.Size = new System.Drawing.Size(131, 44);
            this.yazarAraBtn.TabIndex = 12;
            this.yazarAraBtn.Text = "Yazar Ara";
            this.yazarAraBtn.UseVisualStyleBackColor = true;
            this.yazarAraBtn.Click += new System.EventHandler(this.yazarAraBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yazar Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(128, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Yazar Soyadı";
            // 
            // yazarSoyadAraTxt
            // 
            this.yazarSoyadAraTxt.Location = new System.Drawing.Point(128, 43);
            this.yazarSoyadAraTxt.Name = "yazarSoyadAraTxt";
            this.yazarSoyadAraTxt.Size = new System.Drawing.Size(100, 25);
            this.yazarSoyadAraTxt.TabIndex = 1;
            // 
            // yazarAdAraTxt
            // 
            this.yazarAdAraTxt.Location = new System.Drawing.Point(22, 43);
            this.yazarAdAraTxt.Name = "yazarAdAraTxt";
            this.yazarAdAraTxt.Size = new System.Drawing.Size(100, 25);
            this.yazarAdAraTxt.TabIndex = 0;
            // 
            // yazarlarDgv
            // 
            this.yazarlarDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.yazarlarDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yazarlarDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yazarlarDgv.Location = new System.Drawing.Point(3, 232);
            this.yazarlarDgv.Name = "yazarlarDgv";
            this.yazarlarDgv.RowTemplate.Height = 25;
            this.yazarlarDgv.Size = new System.Drawing.Size(1050, 150);
            this.yazarlarDgv.TabIndex = 2;
            this.yazarlarDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yazarlarDgv_CellDoubleClick);
            // 
            // uyelerTp
            // 
            this.uyelerTp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uyelerTp.Controls.Add(this.uyeAraPanel);
            this.uyelerTp.Controls.Add(this.uyelerDgv);
            this.uyelerTp.Location = new System.Drawing.Point(4, 26);
            this.uyelerTp.Name = "uyelerTp";
            this.uyelerTp.Padding = new System.Windows.Forms.Padding(3);
            this.uyelerTp.Size = new System.Drawing.Size(1056, 385);
            this.uyelerTp.TabIndex = 4;
            this.uyelerTp.Text = "Üyeler";
            // 
            // uyeAraPanel
            // 
            this.uyeAraPanel.Controls.Add(this.uyeemailtxt);
            this.uyeAraPanel.Controls.Add(this.button4);
            this.uyeAraPanel.Controls.Add(this.button5);
            this.uyeAraPanel.Controls.Add(this.label12);
            this.uyeAraPanel.Controls.Add(this.label13);
            this.uyeAraPanel.Controls.Add(this.label14);
            this.uyeAraPanel.Controls.Add(this.label15);
            this.uyeAraPanel.Controls.Add(this.uyeTCNotxt);
            this.uyeAraPanel.Controls.Add(this.uyeSoyadtxt);
            this.uyeAraPanel.Controls.Add(this.uyeAdtxt);
            this.uyeAraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uyeAraPanel.Location = new System.Drawing.Point(3, 3);
            this.uyeAraPanel.Name = "uyeAraPanel";
            this.uyeAraPanel.Size = new System.Drawing.Size(1050, 79);
            this.uyeAraPanel.TabIndex = 5;
            // 
            // uyeemailtxt
            // 
            this.uyeemailtxt.Location = new System.Drawing.Point(340, 43);
            this.uyeemailtxt.Name = "uyeemailtxt";
            this.uyeemailtxt.Size = new System.Drawing.Size(100, 25);
            this.uyeemailtxt.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Image = global::WinFormsApp1.Properties.Resources.delete_button;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(587, 25);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(119, 43);
            this.button4.TabIndex = 13;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = global::WinFormsApp1.Properties.Resources.book__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(449, 24);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(131, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Üye Ara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "TC No";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(128, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Soyad";
            // 
            // uyeTCNotxt
            // 
            this.uyeTCNotxt.Location = new System.Drawing.Point(234, 43);
            this.uyeTCNotxt.Name = "uyeTCNotxt";
            this.uyeTCNotxt.Size = new System.Drawing.Size(100, 25);
            this.uyeTCNotxt.TabIndex = 2;
            // 
            // uyeSoyadtxt
            // 
            this.uyeSoyadtxt.Location = new System.Drawing.Point(128, 43);
            this.uyeSoyadtxt.Name = "uyeSoyadtxt";
            this.uyeSoyadtxt.Size = new System.Drawing.Size(100, 25);
            this.uyeSoyadtxt.TabIndex = 1;
            // 
            // uyeAdtxt
            // 
            this.uyeAdtxt.Location = new System.Drawing.Point(22, 43);
            this.uyeAdtxt.Name = "uyeAdtxt";
            this.uyeAdtxt.Size = new System.Drawing.Size(100, 25);
            this.uyeAdtxt.TabIndex = 0;
            // 
            // uyelerDgv
            // 
            this.uyelerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uyelerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyelerDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uyelerDgv.Location = new System.Drawing.Point(3, 232);
            this.uyelerDgv.Name = "uyelerDgv";
            this.uyelerDgv.RowTemplate.Height = 25;
            this.uyelerDgv.Size = new System.Drawing.Size(1050, 150);
            this.uyelerDgv.TabIndex = 4;
            this.uyelerDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uyelerDgv_CellDoubleClick);
            // 
            // ayarlarTp
            // 
            this.ayarlarTp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ayarlarTp.Controls.Add(this.personelEkleBtn);
            this.ayarlarTp.Controls.Add(this.uyeEkleBtn);
            this.ayarlarTp.Controls.Add(this.yazarEkleBtn);
            this.ayarlarTp.Controls.Add(this.rafEkleBtn);
            this.ayarlarTp.Controls.Add(this.turEkleBtn);
            this.ayarlarTp.Controls.Add(this.kitapEkleBtn);
            this.ayarlarTp.Location = new System.Drawing.Point(4, 26);
            this.ayarlarTp.Name = "ayarlarTp";
            this.ayarlarTp.Padding = new System.Windows.Forms.Padding(3);
            this.ayarlarTp.Size = new System.Drawing.Size(1056, 385);
            this.ayarlarTp.TabIndex = 5;
            this.ayarlarTp.Text = "Ayarlar";
            // 
            // personelEkleBtn
            // 
            this.personelEkleBtn.BackColor = System.Drawing.Color.Green;
            this.personelEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personelEkleBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personelEkleBtn.ForeColor = System.Drawing.Color.White;
            this.personelEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelEkleBtn.Location = new System.Drawing.Point(483, 188);
            this.personelEkleBtn.Name = "personelEkleBtn";
            this.personelEkleBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.personelEkleBtn.Size = new System.Drawing.Size(208, 110);
            this.personelEkleBtn.TabIndex = 5;
            this.personelEkleBtn.Text = "Personel Ekle";
            this.personelEkleBtn.UseVisualStyleBackColor = false;
            this.personelEkleBtn.Click += new System.EventHandler(this.personelEkleBtn_Click);
            // 
            // uyeEkleBtn
            // 
            this.uyeEkleBtn.BackColor = System.Drawing.Color.Green;
            this.uyeEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uyeEkleBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uyeEkleBtn.ForeColor = System.Drawing.Color.White;
            this.uyeEkleBtn.Image = global::WinFormsApp1.Properties.Resources.Untitled_12;
            this.uyeEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeEkleBtn.Location = new System.Drawing.Point(256, 188);
            this.uyeEkleBtn.Name = "uyeEkleBtn";
            this.uyeEkleBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uyeEkleBtn.Size = new System.Drawing.Size(208, 110);
            this.uyeEkleBtn.TabIndex = 4;
            this.uyeEkleBtn.Text = "Üye Ekle";
            this.uyeEkleBtn.UseVisualStyleBackColor = false;
            this.uyeEkleBtn.Click += new System.EventHandler(this.uyeEkleBtn_Click);
            // 
            // yazarEkleBtn
            // 
            this.yazarEkleBtn.BackColor = System.Drawing.Color.Green;
            this.yazarEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yazarEkleBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yazarEkleBtn.ForeColor = System.Drawing.Color.White;
            this.yazarEkleBtn.Image = global::WinFormsApp1.Properties.Resources.Untitled_12;
            this.yazarEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yazarEkleBtn.Location = new System.Drawing.Point(29, 188);
            this.yazarEkleBtn.Name = "yazarEkleBtn";
            this.yazarEkleBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.yazarEkleBtn.Size = new System.Drawing.Size(208, 110);
            this.yazarEkleBtn.TabIndex = 3;
            this.yazarEkleBtn.Text = "Yazar Ekle";
            this.yazarEkleBtn.UseVisualStyleBackColor = false;
            this.yazarEkleBtn.Click += new System.EventHandler(this.yazarEkleBtn_Click);
            // 
            // rafEkleBtn
            // 
            this.rafEkleBtn.BackColor = System.Drawing.Color.Green;
            this.rafEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rafEkleBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rafEkleBtn.ForeColor = System.Drawing.Color.White;
            this.rafEkleBtn.Image = global::WinFormsApp1.Properties.Resources.Untitled_12;
            this.rafEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rafEkleBtn.Location = new System.Drawing.Point(483, 55);
            this.rafEkleBtn.Name = "rafEkleBtn";
            this.rafEkleBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rafEkleBtn.Size = new System.Drawing.Size(208, 110);
            this.rafEkleBtn.TabIndex = 2;
            this.rafEkleBtn.Text = "Raf Ekle";
            this.rafEkleBtn.UseVisualStyleBackColor = false;
            this.rafEkleBtn.Click += new System.EventHandler(this.rafEkleBtn_Click);
            // 
            // turEkleBtn
            // 
            this.turEkleBtn.BackColor = System.Drawing.Color.Green;
            this.turEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turEkleBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.turEkleBtn.ForeColor = System.Drawing.Color.White;
            this.turEkleBtn.Image = global::WinFormsApp1.Properties.Resources.Untitled_12;
            this.turEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turEkleBtn.Location = new System.Drawing.Point(256, 55);
            this.turEkleBtn.Name = "turEkleBtn";
            this.turEkleBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.turEkleBtn.Size = new System.Drawing.Size(208, 110);
            this.turEkleBtn.TabIndex = 1;
            this.turEkleBtn.Text = "Tur Ekle";
            this.turEkleBtn.UseVisualStyleBackColor = false;
            this.turEkleBtn.Click += new System.EventHandler(this.turEkleBtn_Click);
            // 
            // kitapEkleBtn
            // 
            this.kitapEkleBtn.BackColor = System.Drawing.Color.Green;
            this.kitapEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitapEkleBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapEkleBtn.ForeColor = System.Drawing.Color.White;
            this.kitapEkleBtn.Image = global::WinFormsApp1.Properties.Resources.Untitled_12;
            this.kitapEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapEkleBtn.Location = new System.Drawing.Point(29, 55);
            this.kitapEkleBtn.Name = "kitapEkleBtn";
            this.kitapEkleBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.kitapEkleBtn.Size = new System.Drawing.Size(208, 110);
            this.kitapEkleBtn.TabIndex = 0;
            this.kitapEkleBtn.Text = " Kitap Ekle";
            this.kitapEkleBtn.UseVisualStyleBackColor = false;
            this.kitapEkleBtn.Click += new System.EventHandler(this.kitapEkleBtn_Click);
            // 
            // kitapOduncTp
            // 
            this.kitapOduncTp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kitapOduncTp.Controls.Add(this.odunVerPanel);
            this.kitapOduncTp.Controls.Add(this.kitapUyePanel);
            this.kitapOduncTp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitapOduncTp.Location = new System.Drawing.Point(4, 26);
            this.kitapOduncTp.Name = "kitapOduncTp";
            this.kitapOduncTp.Padding = new System.Windows.Forms.Padding(3);
            this.kitapOduncTp.Size = new System.Drawing.Size(1056, 385);
            this.kitapOduncTp.TabIndex = 6;
            this.kitapOduncTp.Text = "Kitap Ödünç Ver";
            // 
            // odunVerPanel
            // 
            this.odunVerPanel.Controls.Add(this.oduncContentPanel);
            this.odunVerPanel.Controls.Add(this.oduncHeaderPanel);
            this.odunVerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.odunVerPanel.Location = new System.Drawing.Point(689, 3);
            this.odunVerPanel.Name = "odunVerPanel";
            this.odunVerPanel.Size = new System.Drawing.Size(364, 379);
            this.odunVerPanel.TabIndex = 1;
            // 
            // oduncContentPanel
            // 
            this.oduncContentPanel.Controls.Add(this.oduncKitapAlbtn);
            this.oduncContentPanel.Controls.Add(this.oduncverilenlerbtn);
            this.oduncContentPanel.Controls.Add(this.kitapVerBtn);
            this.oduncContentPanel.Controls.Add(this.label9);
            this.oduncContentPanel.Controls.Add(this.label8);
            this.oduncContentPanel.Controls.Add(this.uyeAdiOduncTxt);
            this.oduncContentPanel.Controls.Add(this.kitapAdiOduncTxt);
            this.oduncContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oduncContentPanel.Location = new System.Drawing.Point(0, 50);
            this.oduncContentPanel.Name = "oduncContentPanel";
            this.oduncContentPanel.Size = new System.Drawing.Size(364, 329);
            this.oduncContentPanel.TabIndex = 1;
            // 
            // oduncKitapAlbtn
            // 
            this.oduncKitapAlbtn.BackColor = System.Drawing.Color.Green;
            this.oduncKitapAlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oduncKitapAlbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oduncKitapAlbtn.ForeColor = System.Drawing.Color.White;
            this.oduncKitapAlbtn.Location = new System.Drawing.Point(178, 139);
            this.oduncKitapAlbtn.Name = "oduncKitapAlbtn";
            this.oduncKitapAlbtn.Size = new System.Drawing.Size(159, 60);
            this.oduncKitapAlbtn.TabIndex = 6;
            this.oduncKitapAlbtn.Text = "Ödünç Kitap Al";
            this.oduncKitapAlbtn.UseVisualStyleBackColor = false;
            this.oduncKitapAlbtn.Click += new System.EventHandler(this.oduncKitapAlbtn_Click);
            // 
            // oduncverilenlerbtn
            // 
            this.oduncverilenlerbtn.BackColor = System.Drawing.Color.Blue;
            this.oduncverilenlerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oduncverilenlerbtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.oduncverilenlerbtn.Location = new System.Drawing.Point(0, 225);
            this.oduncverilenlerbtn.Name = "oduncverilenlerbtn";
            this.oduncverilenlerbtn.Size = new System.Drawing.Size(337, 48);
            this.oduncverilenlerbtn.TabIndex = 5;
            this.oduncverilenlerbtn.Text = "Ödünç Verilenler";
            this.oduncverilenlerbtn.UseVisualStyleBackColor = false;
            this.oduncverilenlerbtn.Click += new System.EventHandler(this.oduncverilenlerbtn_Click);
            // 
            // kitapVerBtn
            // 
            this.kitapVerBtn.BackColor = System.Drawing.Color.Green;
            this.kitapVerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kitapVerBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapVerBtn.ForeColor = System.Drawing.Color.White;
            this.kitapVerBtn.Location = new System.Drawing.Point(0, 139);
            this.kitapVerBtn.Name = "kitapVerBtn";
            this.kitapVerBtn.Size = new System.Drawing.Size(159, 60);
            this.kitapVerBtn.TabIndex = 4;
            this.kitapVerBtn.Text = "Kitap Ver";
            this.kitapVerBtn.UseVisualStyleBackColor = false;
            this.kitapVerBtn.Click += new System.EventHandler(this.kitapVerBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Üye Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kitap Adı";
            // 
            // uyeAdiOduncTxt
            // 
            this.uyeAdiOduncTxt.Enabled = false;
            this.uyeAdiOduncTxt.Location = new System.Drawing.Point(0, 99);
            this.uyeAdiOduncTxt.Name = "uyeAdiOduncTxt";
            this.uyeAdiOduncTxt.Size = new System.Drawing.Size(159, 34);
            this.uyeAdiOduncTxt.TabIndex = 1;
            // 
            // kitapAdiOduncTxt
            // 
            this.kitapAdiOduncTxt.Enabled = false;
            this.kitapAdiOduncTxt.Location = new System.Drawing.Point(0, 31);
            this.kitapAdiOduncTxt.Name = "kitapAdiOduncTxt";
            this.kitapAdiOduncTxt.Size = new System.Drawing.Size(159, 34);
            this.kitapAdiOduncTxt.TabIndex = 0;
            // 
            // oduncHeaderPanel
            // 
            this.oduncHeaderPanel.Controls.Add(this.label6);
            this.oduncHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oduncHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.oduncHeaderPanel.Name = "oduncHeaderPanel";
            this.oduncHeaderPanel.Size = new System.Drawing.Size(364, 44);
            this.oduncHeaderPanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kitap Ödünç Verme İşlemi";
            // 
            // kitapUyePanel
            // 
            this.kitapUyePanel.Controls.Add(this.oduncUyeDgv);
            this.kitapUyePanel.Controls.Add(this.oduncKitapDgv);
            this.kitapUyePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.kitapUyePanel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitapUyePanel.Location = new System.Drawing.Point(3, 3);
            this.kitapUyePanel.Name = "kitapUyePanel";
            this.kitapUyePanel.Size = new System.Drawing.Size(641, 379);
            this.kitapUyePanel.TabIndex = 0;
            // 
            // oduncUyeDgv
            // 
            this.oduncUyeDgv.AllowUserToAddRows = false;
            this.oduncUyeDgv.AllowUserToDeleteRows = false;
            this.oduncUyeDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oduncUyeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncUyeDgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.oduncUyeDgv.Location = new System.Drawing.Point(368, 0);
            this.oduncUyeDgv.Name = "oduncUyeDgv";
            this.oduncUyeDgv.ReadOnly = true;
            this.oduncUyeDgv.RowTemplate.Height = 25;
            this.oduncUyeDgv.Size = new System.Drawing.Size(273, 379);
            this.oduncUyeDgv.TabIndex = 0;
            this.oduncUyeDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oduncUyeDgv_CellDoubleClick);
            // 
            // oduncKitapDgv
            // 
            this.oduncKitapDgv.AllowUserToAddRows = false;
            this.oduncKitapDgv.AllowUserToDeleteRows = false;
            this.oduncKitapDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oduncKitapDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncKitapDgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.oduncKitapDgv.Location = new System.Drawing.Point(0, 0);
            this.oduncKitapDgv.Name = "oduncKitapDgv";
            this.oduncKitapDgv.ReadOnly = true;
            this.oduncKitapDgv.RowTemplate.Height = 25;
            this.oduncKitapDgv.Size = new System.Drawing.Size(291, 379);
            this.oduncKitapDgv.TabIndex = 0;
            this.oduncKitapDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oduncKitapDgv_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Kullanıcı Adı";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderText = "Şifre";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(246, 25);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kullaniciLbl);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.girisBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(693, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 84);
            this.panel1.TabIndex = 4;
            // 
            // kullaniciLbl
            // 
            this.kullaniciLbl.AutoSize = true;
            this.kullaniciLbl.Location = new System.Drawing.Point(140, 59);
            this.kullaniciLbl.Name = "kullaniciLbl";
            this.kullaniciLbl.Size = new System.Drawing.Size(52, 15);
            this.kullaniciLbl.TabIndex = 6;
            this.kullaniciLbl.Text = "Kullanıcı";
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(246, 55);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(75, 23);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.Text = "Çıkış Yap";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(327, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 84);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources._0acd5002683fbcf2b720004f201ee530;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kutuphaneTc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.kutuphaneTc.ResumeLayout(false);
            this.kitaplarTp.ResumeLayout(false);
            this.kitapAraPanel.ResumeLayout(false);
            this.kitapAraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDgv)).EndInit();
            this.yazarlarTp.ResumeLayout(false);
            this.yazarAraPanel.ResumeLayout(false);
            this.yazarAraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDgv)).EndInit();
            this.uyelerTp.ResumeLayout(false);
            this.uyeAraPanel.ResumeLayout(false);
            this.uyeAraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDgv)).EndInit();
            this.ayarlarTp.ResumeLayout(false);
            this.kitapOduncTp.ResumeLayout(false);
            this.odunVerPanel.ResumeLayout(false);
            this.oduncContentPanel.ResumeLayout(false);
            this.oduncContentPanel.PerformLayout();
            this.oduncHeaderPanel.ResumeLayout(false);
            this.oduncHeaderPanel.PerformLayout();
            this.kitapUyePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oduncUyeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl kutuphaneTc;
        private System.Windows.Forms.TabPage kitaplarTp;
        private System.Windows.Forms.TabPage yazarlarTp;
        private System.Windows.Forms.TabPage uyelerTp;
        private System.Windows.Forms.TabPage ayarlarTp;
        private System.Windows.Forms.TabPage kitapOduncTp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label kullaniciLbl;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.DataGridView kitapDgv;
        private System.Windows.Forms.Panel kitapAraPanel;
        private System.Windows.Forms.TextBox yazarAdTxt;
        private System.Windows.Forms.TextBox kitapAdTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.Button kitapAraBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rafCb;
        private System.Windows.Forms.ComboBox kitapTurCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button araTemizlemeBtn;
        private System.Windows.Forms.Panel yazarAraPanel;
        private System.Windows.Forms.Button yazarAraTemizleBtn;
        private System.Windows.Forms.Button yazarAraBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yazarSoyadAraTxt;
        private System.Windows.Forms.TextBox yazarAdAraTxt;
        private System.Windows.Forms.DataGridView yazarlarDgv;
        private System.Windows.Forms.Panel uyeAraPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox uyeTCNotxt;
        private System.Windows.Forms.TextBox uyeSoyadtxt;
        private System.Windows.Forms.TextBox uyeAdtxt;
        private System.Windows.Forms.DataGridView uyelerDgv;
        private System.Windows.Forms.TextBox uyeemailtxt;
        private System.Windows.Forms.Button personelEkleBtn;
        private System.Windows.Forms.Button uyeEkleBtn;
        private System.Windows.Forms.Button yazarEkleBtn;
        private System.Windows.Forms.Button rafEkleBtn;
        private System.Windows.Forms.Button turEkleBtn;
        private System.Windows.Forms.Button kitapEkleBtn;
        private System.Windows.Forms.Panel odunVerPanel;
        private System.Windows.Forms.Panel kitapUyePanel;
        private System.Windows.Forms.DataGridView oduncUyeDgv;
        private System.Windows.Forms.DataGridView oduncKitapDgv;
        private System.Windows.Forms.Panel oduncContentPanel;
        private System.Windows.Forms.Panel oduncHeaderPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kitapVerBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uyeAdiOduncTxt;
        private System.Windows.Forms.TextBox kitapAdiOduncTxt;
        private System.Windows.Forms.Button oduncKitapAlbtn;
        private System.Windows.Forms.Button oduncverilenlerbtn;
    }
}

