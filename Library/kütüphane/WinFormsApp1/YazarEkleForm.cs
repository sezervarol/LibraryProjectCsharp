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
    public partial class YazarEkleForm : Form
    {
        public YazarEkleForm()
        {
            InitializeComponent();
        }

        private void YazarEkleForm_Load(object sender, EventArgs e)
        {
            YazarEkleHeaderPanel.Size = new Size(this.Width, 80);
            YazarEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
        }

        private void YazarEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yazarEkleBtn_Click(object sender, EventArgs e)
        {
            if (yazarAdiTxt.Text != "" && yazarSoyadiTxt.Text != "" && yazarDurumCb.SelectedIndex != -1)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();
                string sorgu = "insert into Yazar(Ad,Soyad,Aciklama,Durum) values('" + yazarAdiTxt.Text + "','"+yazarSoyadiTxt.Text+"','"+yazarAciklamaRtb.Text+"'," + yazarDurumCb.SelectedIndex + ")";
                SqlCommand yazarekle = new SqlCommand(sorgu, frm.baglanti);
                yazarekle.ExecuteNonQuery();

                MessageBox.Show("Yazar Ekleme Başarılı");
                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekara Deneyiniz");
            }
        }
    }
}
