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
    public partial class PersonelEkleForm : Form
    {
        public PersonelEkleForm()
        {
            InitializeComponent();
        }

        private void PersonelEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            PersonelEkleHeaderPanel.Size = new Size(this.Width, 80);
            PersonelEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
            yetkiCbDoldur();
            personelYetkiCb.SelectedIndex = -1;
        }
        public void yetkiCbDoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("Yetki");
            string sorgu = "select * from Yetki where Durum=1";
            SqlCommand yetkigetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader yetkioku = yetkigetir.ExecuteReader();
            tablo.Load(yetkioku);

            personelYetkiCb.DisplayMember = "Yetki";
            personelYetkiCb.ValueMember = "Id";
            personelYetkiCb.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            if (personelAdiTxt.Text != "" && personelSoyadiTxt.Text != "" && personelSifreTxt.Text != "" && personelYetkiCb.SelectedIndex != -1 && porsonelDurumCb.SelectedIndex != -1)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();
                string sorgu = "insert into Personel(Ad,Soyad,Sifre,YetkiId,Durum) values('" + personelAdiTxt.Text + "','" + personelSoyadiTxt.Text + "','" + personelSifreTxt.Text + "'," + personelYetkiCb.SelectedValue + "," + porsonelDurumCb.SelectedIndex + ")";
                SqlCommand personelekle = new SqlCommand(sorgu, frm.baglanti);
                personelekle.ExecuteNonQuery();

                MessageBox.Show("Personel Ekleme Başarılı");

                personelAdiTxt.Clear();
                personelSoyadiTxt.Clear();
                personelSifreTxt.Clear();
                porsonelDurumCb.SelectedIndex = -1;
                personelYetkiCb.SelectedIndex = -1;

                personelAdiTxt.Focus();




                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekara Deneyiniz");
            }
        }
    }
}
