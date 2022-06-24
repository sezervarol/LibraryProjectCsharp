using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=LastLibrary;Integrated Security=True");
        public DateTime VerildigiTarih = DateTime.Now;
        string KullaniciAdi = "";
        string Sifre = "";
        bool durum = false;
        string kitapIsbn = "";
        int UyeId;
        int KitapId;
        int kullaniciId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kutuphaneTc.Size = new Size(this.Width, this.Height - 80);
            kullaniciLbl.Location = new Point(140, 28);
            cikisBtn.Location = new Point(246, 25);
            kullaniciLbl.Visible = false;
            cikisBtn.Visible = false;
            kutuphaneTc.Enabled = false;
            kitapDgv.Size = new Size(kitaplarTp.Width, kitaplarTp.Height - 100);
            yazarlarDgv.Size = new Size(kitaplarTp.Width, kitaplarTp.Height - 100);
            uyelerDgv.Size = new Size(kitaplarTp.Width, kitaplarTp.Height - 100);
            kitapAraPanel.Size = new Size(kitaplarTp.Width, 100);
            yazarAraPanel.Size = new Size(kitaplarTp.Width, 100);
            uyeAraPanel.Size = new Size(kitaplarTp.Width, 100);
            kitapUyePanel.Size = new Size(kitapOduncTp.Width / 100 * 75, kitapOduncTp.Height);
            odunVerPanel.Size = new Size(kitapOduncTp.Width / 100 * 25, kitapOduncTp.Height);
            oduncKitapDgv.Size = new Size(kitapUyePanel.Width / 2, kitapUyePanel.Height);
            oduncUyeDgv.Size = new Size(kitapUyePanel.Width / 2, kitapUyePanel.Height);
            oduncHeaderPanel.Size = new Size(odunVerPanel.Width, 80);
            oduncContentPanel.Size = new Size(odunVerPanel.Width, kitaplarTp.Height - 80);
            textBox1.Text = "erhan";
            textBox2.Text = "123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void girisBtn_Click(object sender, EventArgs e)
        {
            KullaniciAdi = textBox1.Text;
            Sifre = textBox2.Text;

            if (KullaniciAdi != "" && Sifre != "")
            {
                baglanti.Open();

                SqlCommand giriskontrol = new SqlCommand("select * from Personel where Ad='" + KullaniciAdi + "' and Sifre='" + Sifre + "'", baglanti);

                SqlDataReader verioku = giriskontrol.ExecuteReader();

                if (verioku.Read())
                {
                    kullaniciId = Convert.ToInt32(verioku["Id"]);
                    durum = true;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    girisBtn.Visible = false;
                    cikisBtn.Visible = true;
                    kullaniciLbl.Visible = true;
                    kutuphaneTc.Enabled = true;
                    kullaniciLbl.Text = KullaniciAdi;
                    MessageBox.Show("Giriş Başarılı", "Işkur Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Girile Bilgiler Uyuşmuyor.\nLütfen Tekrar Deneyiniz", "Işkur Kütüphane", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

                baglanti.Close();

                if (durum == true)
                {
                    uyeTabloDoldur();
                    yazarTabloDoldur();
                    kitapTabloDoldur();
                    kitapTurCbDoldur();
                    rafCbDoldur();
                }
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Eksik", "Işkur Kütüphane", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            KullaniciAdi = "";
            Sifre = "";
            durum = false;
            girisBtn.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            cikisBtn.Visible = false;
            kullaniciLbl.Visible = false;
            kutuphaneTc.Enabled = false;
            MessageBox.Show("Çıkış İşlemi Başarılı", "Işkur Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void kitapTabloDoldur()
        {
            baglanti.Open();

            string sorgu = "Select Kitap.Id, Kitap.ISBN,Kitap.KitapAdi,Yazar.Ad as 'Yazar Adı',Yazar.Soyad as 'Yazar Soyadı',Tur.TurAdi,Raf.RafAdi,Kitap.Aciklama,Stok.Adet as 'Stok Adedi',Kitap.Durum from Kitap " +
                "inner join Yazar on (Kitap.YazarId=Yazar.Id) inner join Tur on (Kitap.TurId=Tur.Id) " +
                "inner join Raf on (Kitap.RafId=Raf.Id) inner join Stok on (Kitap.Id=Stok.KitapId)";
            DataTable tablo = new DataTable();

            SqlDataAdapter kitapgetir = new SqlDataAdapter(sorgu, baglanti);

            kitapgetir.Fill(tablo);

            kitapDgv.DataSource = tablo;
            oduncKitapDgv.DataSource = tablo;
            baglanti.Close();
        }
        public void yazarTabloDoldur()
        {
            baglanti.Open();

            string sorgu = "select * from Yazar";
            DataTable tablo = new DataTable();

            SqlDataAdapter yazargetir = new SqlDataAdapter(sorgu, baglanti);

            yazargetir.Fill(tablo);

            yazarlarDgv.DataSource = tablo;
            baglanti.Close();
        }
        public void uyeTabloDoldur()
        {
            baglanti.Open();

            string sorgu = "select * from Uye";
            DataTable tablo = new DataTable();

            SqlDataAdapter uyegetir = new SqlDataAdapter(sorgu, baglanti);

            uyegetir.Fill(tablo);

            uyelerDgv.DataSource = tablo;
            oduncUyeDgv.DataSource = tablo;
            baglanti.Close();
        }
        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            string isbnno = "";
            string kitapad = "";
            string yazarad = "";
            string kitaptur = "";
            string kitapraf = "";
            if (isbnTxt.Text == "" && kitapAdTxt.Text == "" && yazarAdTxt.Text == "" && kitapTurCb.SelectedIndex == -1 && rafCb.SelectedIndex == -1)
            {
                isbnTxt.Clear();
                yazarAdTxt.Clear();
                kitapAdTxt.Clear();
                kitapTurCb.SelectedIndex = -1;
                rafCb.SelectedIndex = -1;
                kitapTabloDoldur();
            }
            else
            {
                if (isbnTxt.Text != "")
                {
                    isbnno = isbnTxt.Text;
                }
                if (kitapAdTxt.Text != "")
                {
                    kitapad = kitapAdTxt.Text;
                }
                if (yazarAdTxt.Text != "")
                {
                    yazarad = yazarAdTxt.Text;
                }

                if (kitapTurCb.SelectedIndex != -1)
                {
                    kitaptur = kitapTurCb.SelectedItem.ToString();

                }
                if (rafCb.SelectedIndex != -1)
                {
                    kitapraf = rafCb.SelectedItem.ToString();
                }
                baglanti.Open();

                string sorgu = "select Kitap.ISBN as 'ISBN No',Kitap.KitapAdi as 'Kitap Adı',Yazar.Ad as 'Yazar Adı',Yazar.Soyad as 'Yazar Soyadı',Tur.TurAdi as 'Kitap Türü',Raf.RafAdi as 'Raf Adı',Kitap.Aciklama as 'Açıklama',Stok.Adet as 'Stok Adeti',Kitap.Durum as 'Kitap Durumu' from Kitap inner join Yazar on(Kitap.YazarId=Yazar.Id) inner join Tur on(Kitap.TurId=Tur.Id) inner join Raf on (Kitap.RafId=Raf.Id) inner join Stok on(Kitap.Id=Stok.KitapId) where Kitap.KitapAdi='" + kitapad + "' or Kitap.ISBN='" + isbnno + "' or Yazar.Ad='" + yazarad + "' or Tur.TurAdi='" + kitaptur + "' or Raf.RafAdi='" + kitapraf + "'";
                DataTable tablo = new DataTable();

                SqlDataAdapter kitapgetir = new SqlDataAdapter(sorgu, baglanti);

                kitapgetir.Fill(tablo);

                kitapDgv.DataSource = tablo;
                baglanti.Close();
            }

        }
        public void kitapTurCbDoldur()
        {
            baglanti.Open();

            string sorgu = "select * from Tur where Durum=1";
            SqlCommand turgetir = new SqlCommand(sorgu, baglanti);
            SqlDataReader turoku = turgetir.ExecuteReader();

            kitapTurCb.Items.Clear();

            while (turoku.Read())
            {
                kitapTurCb.Items.Add(turoku["TurAdi"]);
            }

            baglanti.Close();
        }
        public void rafCbDoldur()
        {
            baglanti.Open();

            string sorgu = "select * from Raf where Durum=1";
            SqlCommand rafgetir = new SqlCommand(sorgu, baglanti);
            SqlDataReader rafoku = rafgetir.ExecuteReader();

            rafCb.Items.Clear();

            while (rafoku.Read())
            {
                rafCb.Items.Add(rafoku["RafAdi"]);
            }

            baglanti.Close();
        }

        private void araTemizlemeBtn_Click(object sender, EventArgs e)
        {
            isbnTxt.Clear();
            yazarAdTxt.Clear();
            kitapAdTxt.Clear();
            kitapTurCb.SelectedIndex = -1;
            rafCb.SelectedIndex = -1;
            kitapTabloDoldur();
        }

        private void yazarAraBtn_Click(object sender, EventArgs e)
        {

            string yazarad = "";
            string yazarsoyad = "";

            if (yazarSoyadAraTxt.Text == "" && yazarAdAraTxt.Text == "")
            {
                yazarSoyadAraTxt.Clear();
                yazarAdAraTxt.Clear();
                yazarTabloDoldur();
            }
            else
            {
                if (yazarSoyadAraTxt.Text != "")
                {
                    yazarsoyad = yazarSoyadAraTxt.Text;
                }
                if (yazarAdAraTxt.Text != "")
                {
                    yazarad = yazarAdAraTxt.Text;
                }

                baglanti.Open();

                string sorgu = "select Ad,Soyad,Aciklama,Durum from Yazar where Ad='" + yazarad + "' or Soyad='" + yazarsoyad + "'";

                DataTable tablo = new DataTable();

                SqlDataAdapter yazargetir = new SqlDataAdapter(sorgu, baglanti);

                yazargetir.Fill(tablo);

                yazarlarDgv.DataSource = tablo;
                baglanti.Close();
            }
        }

        private void yazarAraTemizleBtn_Click(object sender, EventArgs e)
        {
            yazarSoyadAraTxt.Clear();
            yazarAdAraTxt.Clear();
            yazarTabloDoldur();
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            KitapEkleForm kef = new KitapEkleForm();

            kef.ShowDialog();
        }

        private void turEkleBtn_Click(object sender, EventArgs e)
        {
            TurEkleForm tef = new TurEkleForm();

            tef.ShowDialog();
        }

        private void rafEkleBtn_Click(object sender, EventArgs e)
        {
            RafEkleForm Ref = new RafEkleForm();

            Ref.ShowDialog();
        }

        private void yazarEkleBtn_Click(object sender, EventArgs e)
        {
            YazarEkleForm yef = new YazarEkleForm();

            yef.ShowDialog();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            UyeEkleForm uef = new UyeEkleForm();
            uef.ShowDialog();
        }

        private void personelEkleBtn_Click(object sender, EventArgs e)
        {
            PersonelEkleForm pef = new PersonelEkleForm();

            pef.ShowDialog();
        }

        private void kitapDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string isbnNo = kitapDgv.CurrentRow.Cells["ISBN"].Value.ToString();

            KitapDuzenleForm kdf = new KitapDuzenleForm();
            kdf.isbnNo = isbnNo;

            kdf.ShowDialog();
        }

        private void oduncKitapDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            kitapAdiOduncTxt.Text = oduncKitapDgv.CurrentRow.Cells["KitapAdi"].Value.ToString();
            KitapId = Convert.ToInt32(oduncKitapDgv.CurrentRow.Cells["Id"].Value);

        }

        private void oduncUyeDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uyeAdiOduncTxt.Text = oduncUyeDgv.CurrentRow.Cells["Ad"].Value.ToString() + " " + oduncUyeDgv.CurrentRow.Cells["Soyad"].Value.ToString();

            UyeId = Convert.ToInt32(oduncUyeDgv.CurrentRow.Cells["Id"].Value);
        }

        private void kitapVerBtn_Click(object sender, EventArgs e)
        {
            var Tarih = VerildigiTarih.Date;
            DialogResult odunckontrol = new DialogResult();

            odunckontrol = MessageBox.Show("Kitap Ödünç Verilsin mi?", "Kitap Ödünç Sistemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (odunckontrol == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand oduncver = new SqlCommand();
                oduncver.Connection = baglanti;
                oduncver.CommandType = CommandType.StoredProcedure;
                oduncver.CommandText = "KitapVer";
                oduncver.Parameters.Add("PersonelId", SqlDbType.Int).Value = kullaniciId;
                oduncver.Parameters.Add("UyeId", SqlDbType.Int).Value = UyeId;
                oduncver.Parameters.Add("KitapId", SqlDbType.Int).Value = KitapId;
                oduncver.Parameters.Add("VerildigiTarih", SqlDbType.DateTime).Value = Tarih.ToString("dd/MM/yyyy");
                oduncver.ExecuteNonQuery();

                kitapAdiOduncTxt.Clear();
                uyeAdiOduncTxt.Clear();
                kitapIsbn = "";
                UyeId = 0;
                KitapId = 0;

                baglanti.Close();

                uyeTabloDoldur();
                kitapTabloDoldur();
            }
            else
            {
                MessageBox.Show("Kitap Ödüç Verme İptal Edildi");
            }
            baglanti.InfoMessage += new SqlInfoMessageEventHandler(baglanti_InfoMessage);
        }

        private void baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message, "Kitap Ödünç Verme");
        }

        private void yazarlarDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string isbnNo = yazarlarDgv.CurrentRow.Cells["ISBN No"].Value.ToString();
            //yazarId = Convert.ToInt32(yazarlarDgv.CurrentRow.Cells["Id"].Value);

            YazarDüzenleForm ydf = new YazarDüzenleForm();
            ydf.yazarId = Convert.ToInt32(yazarlarDgv.CurrentRow.Cells["Id"].Value);
            ydf.ShowDialog();

        }

        private void uyelerDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ÜyeDüzenleForm üdf = new ÜyeDüzenleForm();
            üdf.uyeId = Convert.ToInt32(uyelerDgv.CurrentRow.Cells["Id"].Value);
            üdf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uyeAdtxt.Clear();
            uyeSoyadtxt.Clear();
            uyeTCNotxt.Clear();
            uyeemailtxt.Clear();
            uyeTabloDoldur();
        }

        private void oduncKitapAlbtn_Click(object sender, EventArgs e)
        {
            DialogResult gerialmakontrol = new DialogResult();
            gerialmakontrol = MessageBox.Show("Kitap Geri Alınsın Mı?", "Kitap Geri Alma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gerialmakontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();
                frm.baglanti.Open();

                SqlCommand gerial = new SqlCommand();
                gerial.Connection = frm.baglanti;
                gerial.CommandType = CommandType.StoredProcedure;
                gerial.CommandText = "KitapGeriAl";
                gerial.Parameters.Add("PersonelId", SqlDbType.Int).Value = kullaniciId;
                gerial.Parameters.Add("UyeId", SqlDbType.Int).Value = UyeId;
                gerial.Parameters.Add("KitapId", SqlDbType.Int).Value = KitapId;
                gerial.ExecuteNonQuery();

                MessageBox.Show("Kitap Geri Alma İşlemi Başarılı.");
                kitapAdiOduncTxt.Clear();
                uyeAdiOduncTxt.Clear();
                UyeId = 0;
                KitapId = 0;

                frm.baglanti.Close();
                uyeTabloDoldur();
                kitapTabloDoldur();
            }
            else
            {
                MessageBox.Show("Geri Verme İşlemi İptal Edildi.");
            }
        }

        private void oduncverilenlerbtn_Click(object sender, EventArgs e)
        {
            kitapoduncverilenform kov = new kitapoduncverilenform();
            kov.ShowDialog();
        }

    }
}

