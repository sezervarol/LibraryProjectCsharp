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
    public partial class kitapoduncverilenform : Form
    {
        public kitapoduncverilenform()
        {
            InitializeComponent();
        }

        private void kitapoduncverilenform_Load(object sender, EventArgs e)
        {
            kitapoduncHeaderPanel.Size = new Size(this.Width, 80);
            kitapodunccontentPanel.Size = new Size(this.Width, this.Height - 80);

            oduncverilenkitaplardgv.Size = new Size(kitapoduncekrantc.Width, kitapoduncekrantc.Height - 100);
            oduncgecikenkitaplardgv.Size = new Size(kitapoduncekrantc.Width, kitapoduncekrantc.Height - 100);
            oduncteslimedilenkitapdgv.Size = new Size(kitapoduncekrantc.Width, kitapoduncekrantc.Height - 100);

            kitapoduncverilenkitaplar();
            kitapoduncgecikenkitaplar();
            kitapoduncteslimkitaplar();
        }
        public void kitapoduncverilenkitaplar()
        {
            Form1 frm = new Form1();
            frm.baglanti.Open();

            string sorgu = "Select Odunc.UyeId,Uye.Ad as 'Üye Adı', Odunc.KitapId, Kitap.KitapAdi as 'Kitap Adı',Stok.Adet as 'Kitap Adedi', Odunc.VerildigiTarih as 'Verildiği Tarih', Odunc.OduncSuresi as 'Ödünç Süresi', Odunc.OduncDurumu as 'Ödünç Durumu' from Odunc inner join Kitap on (Kitap.Id=Odunc.KitapId) inner join Uye on (Uye.Id=Odunc.UyeId) inner join Stok on (Stok.KitapId=Odunc.KitapId) where OduncDurumu='Verildi' ";

            DataTable dt = new DataTable();

            SqlDataAdapter verilengetir = new SqlDataAdapter(sorgu, frm.baglanti);
            verilengetir.Fill(dt);

            oduncverilenkitaplardgv.DataSource = dt;

            frm.baglanti.Close();
        }
        public void kitapoduncgecikenkitaplar()
        {
            Form1 frm = new Form1();
            frm.baglanti.Open();

            string sorgu = "Select Odunc.UyeId,Uye.Ad as 'Üye Adı', Odunc.KitapId, Kitap.KitapAdi as 'Kitap Adı',Stok.Adet as 'Kitap Adedi',Odunc.VerildigiTarih as 'Verildiği Tarih', Odunc.OduncSuresi as 'Ödünç Süresi', Odunc.OduncDurumu as 'Ödünç Durumu' from Odunc inner join Kitap on (Kitap.Id=Odunc.KitapId) inner join Uye on (Uye.Id=Odunc.UyeId) inner join Stok on (Stok.KitapId=Odunc.KitapId) where OduncDurumu='Gecikti' ";

            DataTable dt = new DataTable();

            SqlDataAdapter gecikengetir = new SqlDataAdapter(sorgu, frm.baglanti);
            gecikengetir.Fill(dt);

            oduncgecikenkitaplardgv.DataSource = dt;

            frm.baglanti.Close();
        }
        public void kitapoduncteslimkitaplar()
        {
            Form1 frm = new Form1();
            frm.baglanti.Open();
            string sorgu = "Select Odunc.UyeId,Uye.Ad as 'Üye Adı', Odunc.KitapId, Kitap.KitapAdi as 'Kitap Adı',Stok.Adet as 'Kitap Adedi',Odunc.VerildigiTarih as 'Verildiği Tarih', Odunc.OduncSuresi as 'Ödünç Süresi', Odunc.OduncDurumu as 'Ödünç Durumu' from Odunc inner join Kitap on (Kitap.Id=Odunc.KitapId) inner join Uye on (Uye.Id=Odunc.UyeId) inner join Stok on (Stok.KitapId=Odunc.KitapId) where OduncDurumu='Alindi' ";
            DataTable dt = new DataTable();
            SqlDataAdapter teslimgetir = new SqlDataAdapter(sorgu, frm.baglanti);
            teslimgetir.Fill(dt);
            oduncteslimedilenkitapdgv.DataSource = dt;
            frm.baglanti.Close();


        }

        private void kitapDuzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
