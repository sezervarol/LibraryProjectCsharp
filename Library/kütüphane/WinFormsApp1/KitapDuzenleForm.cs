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
    public partial class KitapDuzenleForm : Form
    {
        public string isbnNo="";
        public int kitapId = 0;
        public bool durum = false;

        public KitapDuzenleForm()
        {
            InitializeComponent();
        }

        private void KitapDuzenleForm_Load(object sender, EventArgs e)
        {
            kitapDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            kitapDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);

            rafCbDoldur();
            turCbDoldur();
            yazarCbDoldur();
            
            kitapDuzenleLbl.Text += " - " + isbnNo;
            kitapGetir(isbnNo);
            isbnTxt.Enabled = false;

            kitapStokLbl.Visible = false;
            kitapStokNud.Visible = false;
            stokEkleBtn.Visible = false;
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

        private void kitapDuzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitapDuzenleBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update Kitap set KitapAdi='" + kitapAdiTxt.Text + "',YazarId="+(int)yazarCb.SelectedValue+", TurId="+ (int)turCb.SelectedValue+", RafId="+ (int)rafCb.SelectedValue+", Resim='"+resimTxt.Text+"',Durum="+durumCb.SelectedIndex+", Aciklama='"+aciklamaRtb.Text+"' where ISBN='" + isbnNo + "'";

            SqlCommand kitapduzenle = new SqlCommand(sorgu, frm.baglanti);
            kitapduzenle.ExecuteNonQuery();
            MessageBox.Show("Kitap Düzenleme Başarılı");
            
            frm.baglanti.Close();

            kitapGetir(isbnNo);
        }
        public void kitapGetir(string isbnNo)
        {
            rafCb.SelectedIndex = -1;
            turCb.SelectedIndex = -1;
            yazarCb.SelectedIndex = -1;

            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from Kitap inner join Yazar on(Kitap.YazarId=Yazar.Id) inner join Tur on(Kitap.TurId=Tur.Id) inner join Raf on(Kitap.RafId=Raf.Id) where ISBN='" + isbnNo + "'";

            SqlCommand kg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader kitapoku = kg.ExecuteReader();
            if (kitapoku.Read())
            {
                kitapId = Convert.ToInt32(kitapoku["Id"]);
                isbnTxt.Text = kitapoku["ISBN"].ToString();
                kitapAdiTxt.Text = kitapoku["KitapAdi"].ToString();
                yazarCb.SelectedValue = kitapoku["YazarId"].ToString();
                turCb.SelectedValue = kitapoku["TurId"].ToString();
                rafCb.SelectedValue = kitapoku["RafId"].ToString();
                aciklamaRtb.Text = kitapoku["Aciklama"].ToString();
                resimTxt.Text = kitapoku["Resim"].ToString();
                durumCb.SelectedIndex = Convert.ToInt32(kitapoku["Durum"]);
            }
            frm.baglanti.Close();
          
        }

        private void kitapSilBtn_Click(object sender, EventArgs e)
        {

            //frm.baglanti.Open();
            //string alissorgu = "delete from Alis where KitapId="+kitapId;
            //SqlCommand alisSil = new SqlCommand(alissorgu, frm.baglanti);
            //alisSil.ExecuteNonQuery();
            //frm.baglanti.Close();

            //frm.baglanti.Open();
            //string satissorgu = "delete from Satis where KitapId=" + kitapId;
            //SqlCommand satisSil = new SqlCommand(satissorgu, frm.baglanti);
            //satisSil.ExecuteNonQuery();
            //frm.baglanti.Close();

            //frm.baglanti.Open();
            //string stoksorgu = "delete from Stok where KitapId=" + kitapId;
            //SqlCommand stokSil = new SqlCommand(stoksorgu, frm.baglanti);
            //stokSil.ExecuteNonQuery();
            //frm.baglanti.Close();

            //frm.baglanti.Open();
            //string oduncsorgu = "delete from Odunc where KitapId=" + kitapId;
            //SqlCommand oduncSil = new SqlCommand(oduncsorgu, frm.baglanti);
            //oduncSil.ExecuteNonQuery();
            //frm.baglanti.Close();

            //frm.baglanti.Open();
            //string sorgu = "delete from Kitap where Id="+kitapId;
            //SqlCommand kitapsil = new SqlCommand(sorgu, frm.baglanti);
            //kitapsil.ExecuteNonQuery();
            //frm.baglanti.Close();

            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(kitapAdiTxt.Text + " Adlı Kitap Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "kitapSil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("kitapId", SqlDbType.Int).Value = kitapId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Kitap Silme İşlemi Başarılı");
                this.Close();
            }
            else {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }

            
        }

        private void KitapEkleBtn_Click(object sender, EventArgs e)
        {
            durum = !durum;

            if (durum != false)
            {
                kitapStokLbl.Visible = true;
                kitapStokNud.Visible = true;
                stokEkleBtn.Visible = true;
            }
            else
            {
                kitapStokLbl.Visible = false;
                kitapStokNud.Visible = false;
                stokEkleBtn.Visible = false;
            }
        }

        private void stokEkleBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();
            
            string sorgu = "insert into Alis(KitapId,Adet) values("+ kitapId +","+ kitapStokNud.Value + ")";
            SqlCommand alisekle = new SqlCommand(sorgu, frm.baglanti);
            alisekle.ExecuteNonQuery();

            MessageBox.Show("Stoğa " + kitapStokNud.Value + " Adet Kitap Eklendi");
            frm.baglanti.Close();
        }

       
    }
}
