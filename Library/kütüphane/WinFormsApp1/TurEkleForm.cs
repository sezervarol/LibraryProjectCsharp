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
    public partial class TurEkleForm : Form
    {
        public TurEkleForm()
        {
            InitializeComponent();
        }

        private void TurEkleForm_Load(object sender, EventArgs e)
        {
            TurEkleHeaderPanel.Size = new Size(this.Width, 80);
            TurEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
        }

        private void TurEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void turEkleBtn_Click(object sender, EventArgs e)
        {
            if(turAdiTxt.Text!="" && turDurumCb.SelectedIndex != -1)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();
                string sorgu = "insert into Tur(TurAdi,Durum) values('"+turAdiTxt.Text+"',"+turDurumCb.SelectedIndex+")";

                SqlCommand turekle = new SqlCommand(sorgu, frm.baglanti);
                turekle.ExecuteNonQuery();
                MessageBox.Show("Tur Ekleme Başarılı");

                turAdiTxt.Clear();
                turDurumCb.SelectedIndex = -1;
                turAdiTxt.Focus();

                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekara Deneyiniz");
            }
        }
    }
}
