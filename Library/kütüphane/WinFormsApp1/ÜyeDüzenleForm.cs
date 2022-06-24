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
    public partial class ÜyeDüzenleForm : Form
    {
        public int uyeId = 0;
        public ÜyeDüzenleForm()
        {
            InitializeComponent();
        }

        private void kitapDuzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ÜyeDüzenleForm_Load(object sender, EventArgs e)
        {
            üyeDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            üyeDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);
            uyegetir(uyeId);
        }

        private void üyeDuzenleBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "update Uye set Ad='" + üyeAdiTxt.Text + "',Soyad='" + üyesoyadıtxt.Text + "', Durum=" + üyedurumCb.SelectedIndex + ", Adres='" + üyeadresRtb.Text + "',Email='" + üyeresimTxt.Text + "',Telefon='" + üyetelefontxt.Text + "',TcNo='" + ÜyetcNo.Text + "',Resim='" + üyeresimTxt.Text + "' where Id= " + uyeId + ""; ;

            SqlCommand yazarduzenle = new SqlCommand(sorgu, frm.baglanti);
            yazarduzenle.ExecuteNonQuery();
            MessageBox.Show("Üye Düzenleme Başarılı");

            frm.baglanti.Close();
        }

        public void uyegetir(int Id)
        {
            Form1 frm = new Form1();

            frm.baglanti.Open();

            string sorgu = "select * from Uye where Id=" + Id;

            SqlCommand ug = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader uyeoku = ug.ExecuteReader();
            if (uyeoku.Read())
            {
                uyeId = Convert.ToInt32(uyeoku["Id"]);
                üyeAdiTxt.Text = uyeoku["Ad"].ToString();
                üyesoyadıtxt.Text = uyeoku["Soyad"].ToString();
                üyeemailtxt.Text = uyeoku["Email"].ToString();
                üyetelefontxt.Text = uyeoku["Telefon"].ToString();
                ÜyetcNo.Text = uyeoku["TcNo"].ToString();
                üyeresimTxt.Text = uyeoku["Resim"].ToString();
                üyeadresRtb.Text = uyeoku["Adres"].ToString();
                üyedurumCb.SelectedIndex = Convert.ToInt32(uyeoku["Durum"]);
            }
            frm.baglanti.Close();
        }

        private void üyeSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(üyeAdiTxt.Text + " " + üyesoyadıtxt.Text + " Adlı üye Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                Form1 frm = new Form1();

                frm.baglanti.Open();

                SqlCommand silkomut = new SqlCommand();
                silkomut.Connection = frm.baglanti;
                silkomut.CommandType = CommandType.StoredProcedure;
                silkomut.CommandText = "uyeSil";//veri tabanında bulunan procedurenin adı
                silkomut.Parameters.Add("uyeId", SqlDbType.Int).Value = uyeId;
                silkomut.ExecuteNonQuery();
                frm.baglanti.Close();

                MessageBox.Show("üye Silme İşlemi Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("üye İşlemi İptal Edildi");
            }
        }

        private void üyekitapBölümBtn_Click(object sender, EventArgs e)
        {
            uyeOduncVerilenForm ovf = new uyeOduncVerilenForm();
            ovf.uyeIdNo = uyeId;
            ovf.ShowDialog();
            
        }
    }
}

