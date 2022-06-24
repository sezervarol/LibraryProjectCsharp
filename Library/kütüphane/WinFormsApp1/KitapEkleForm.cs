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
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }

        private void KitapEkleForm_Load(object sender, EventArgs e)
        {
            kitapEkleHeaderPanel.Size = new Size(this.Width, 80);
            kitapEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
            
            rafCbDoldur();
            turCbDoldur();
            yazarCbDoldur();
        }

        private void kitapEkleCikisBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "insert into Kitap(KitapAdi,ISBN,TurId,YazarId,RafId,Aciklama,Resim,Durum)" +
                "Values('"+kitapAdiTxt.Text+"','"+isbnTxt.Text+"',"+Convert.ToInt32(turCb.SelectedValue)+","+Convert.ToInt32(yazarCb.SelectedValue)+","+Convert.ToInt32(rafCb.SelectedValue)+",'"+aciklamaRtb.Text+"','"+resimTxt.Text+"',"+durumCb.SelectedIndex+")";

            SqlCommand kitapekle = new SqlCommand(sorgu, frm.baglanti);
            kitapekle.ExecuteNonQuery();
            MessageBox.Show("Kitap Ekleme Başarılı");

            frm.baglanti.Close();
        }
        public void rafCbDoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("Raf");
            string sorgu = "select * from Raf where Durum=1";
            SqlCommand rafgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader rafoku = rafgetir.ExecuteReader();
            tablo.Load(rafoku);

            rafCb.DisplayMember = "RafAdi";
            rafCb.ValueMember = "Id";
            rafCb.DataSource = tablo;

            frm.baglanti.Close();
        }
        public void turCbDoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("Tur");
            string sorgu = "select * from Tur where Durum=1";
            SqlCommand turgetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader turoku = turgetir.ExecuteReader();
            tablo.Load(turoku);

            turCb.DisplayMember = "TurAdi";
            turCb.ValueMember = "Id";
            turCb.DataSource = tablo;

            frm.baglanti.Close();
        }
        public void yazarCbDoldur()
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            DataTable tablo = new DataTable("Yazar");
            string sorgu = "select * from Yazar where Durum=1";
            SqlCommand yazargetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader yazaroku = yazargetir.ExecuteReader();
            tablo.Load(yazaroku);

            yazarCb.DisplayMember = "Ad";
            yazarCb.ValueMember = "Id";
            yazarCb.DataSource = tablo;
         
            frm.baglanti.Close();
        }

    }
}
