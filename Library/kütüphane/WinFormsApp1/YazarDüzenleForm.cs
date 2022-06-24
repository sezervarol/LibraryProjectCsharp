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
    public partial class YazarDüzenleForm : Form
    {
        public int yazarId = 0;
        public YazarDüzenleForm()
        {
            InitializeComponent();
        }

        private void kitapDuzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YazarDüzenleForm_Load(object sender, EventArgs e)
        {
            yazarDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            yazarDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            yazargetir(yazarId);
        }

        private void yazarDuzenleBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update Yazar set Ad='" + yazaradtxt.Text + "',Soyad='" + yazarsoyadıxt.Text + "', Durum=" + yazardurumCb.SelectedIndex + ", Aciklama='" + yazaraciklamaRtb.Text + "' where Id= " + yazarId + ""; ;

            SqlCommand yazarduzenle = new SqlCommand(sorgu, frm.baglanti);
            yazarduzenle.ExecuteNonQuery();
            MessageBox.Show("Yazar Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        public void yazargetir(int Id)
        {

            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from Yazar where Id=" + Id;

            SqlCommand yg = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader yazaroku = yg.ExecuteReader();
            if (yazaroku.Read())
            {
                yazarId = Convert.ToInt32(yazaroku["Id"]);
                yazaradtxt.Text = yazaroku["Ad"].ToString();
                yazarsoyadıxt.Text = yazaroku["Soyad"].ToString();
                yazaraciklamaRtb.Text = yazaroku["Aciklama"].ToString();
                yazardurumCb.SelectedIndex = Convert.ToInt32(yazaroku["Durum"]);
            }
            frm.baglanti.Close();

        }

        private void yazarSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(yazaradtxt.Text + " " + yazarsoyadıxt.Text +" Adlı Yazar Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "yazarSil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("yazarId", SqlDbType.Int).Value = yazarId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("Yazar Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Yazar İşlemi İptal Edildi");
            }
        }
    }
}

