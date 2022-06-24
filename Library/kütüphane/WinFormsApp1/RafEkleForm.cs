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
    public partial class RafEkleForm : Form
    {
        public RafEkleForm()
        {
            InitializeComponent();
        }

        private void RafEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RafEkleForm_Load(object sender, EventArgs e)
        {
            RafEkleHeaderPanel.Size = new Size(this.Width, 80);
            RafEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
        }

        private void rafEkleBtn_Click(object sender, EventArgs e)
        {
            if(rafAdiTxt.Text!="" && rafDurumCb.SelectedIndex != -1)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();
                string sorgu = "insert into Raf(RafAdi,Durum) values('"+rafAdiTxt.Text+"',"+rafDurumCb.SelectedIndex+")";
                SqlCommand rafekle = new SqlCommand(sorgu, frm.baglanti);
                rafekle.ExecuteNonQuery();

                MessageBox.Show("Raf Ekleme Başarılı");
                frm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekara Deneyiniz");
            }
        }
    }
}
