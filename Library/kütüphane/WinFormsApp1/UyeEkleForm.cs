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
    public partial class UyeEkleForm : Form
    {
        public UyeEkleForm()
        {
            InitializeComponent();
        }

        private void UyeEkleForm_Load(object sender, EventArgs e)
        {
            UyeEkleHeaderPanel.Size = new Size(this.Width, 80);
            UyeEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
        }

        private void UyeEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UyeEkleBtn_Click(object sender, EventArgs e)
        {
            if (uyeAdiTxt.Text != "" && uyeSoyadiTxt.Text != "" && tcnoLbl.Text != "" && emailLbl.Text != "" && telefonTxt.Text != "" && uyeDurumCb.SelectedIndex != -1)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();
                string sorgu = "insert into Uye(Ad,Soyad,TcNo,Email,Telefon,Adres,Resim,Durum) values('" + uyeAdiTxt.Text + "','" + uyeSoyadiTxt.Text + "','" + tcnoLbl.Text + "','" + emailLbl.Text + "','" + telefonTxt.Text + "','" + adresRtb.Text + "','" + resimTxt.Text + "'," + uyeDurumCb.SelectedIndex + ")";
                SqlCommand uyeekle = new SqlCommand(sorgu, frm.baglanti);
                uyeekle.ExecuteNonQuery();

                MessageBox.Show("Üye Ekleme Başarılı");

                uyeAdiTxt.Clear();
                uyeSoyadiTxt.Clear();
                tcnoLbl.Text = "";
                emailLbl.Text="";
                telefonTxt.Clear();
                uyeDurumCb.SelectedIndex = -1;
                adresRtb.Clear();

                uyeAdiTxt.Focus();




                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekara Deneyiniz");
            }
        }

       
    }
}
