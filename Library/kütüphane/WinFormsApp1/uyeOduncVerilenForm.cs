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
    public partial class uyeOduncVerilenForm : Form
    {
        public int uyeIdNo;
        public uyeOduncVerilenForm()
        {
            InitializeComponent();
        }

        private void kitapDuzenleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OduncVerilenForm_Load(object sender, EventArgs e)
        {
            üyeDuzenleHeaderPanel.Size = new Size(this.Width, 80);
            üyeDuzenleContentPanel.Size = new Size(this.Width, this.Height - 80);

            verilenkitaplardgv.Size = new Size(üyeoduncekrantc.Width, üyeoduncekrantc.Height - 100);
            gecikenkitaplardgv.Size = new Size(üyeoduncekrantc.Width, üyeoduncekrantc.Height - 100);
            teslimedilenkitapdgv.Size = new Size(üyeoduncekrantc.Width, üyeoduncekrantc.Height - 100);

            UyeVerilenKitaplar();
            UyeGecikenKitaplar();
            UyeTeslimKitaplar();
        }

        public void UyeVerilenKitaplar()
        {

            Form1 frm = new Form1();
            frm.baglanti.Open();

            string sorgu = "Select Odunc.UyeId, Uye.Ad as 'Üye Adı', Odunc.KitapId, Kitap.KitapAdi as 'Kitap Adı',Stok.Adet as 'Kitap Adedi', Odunc.VerildigiTarih as 'Verildiği Tarih', Odunc.OduncSuresi as 'Ödünç Süresi', Odunc.OduncDurumu as 'Ödünç Durumu' from Odunc inner join Kitap on (Kitap.Id=Odunc.KitapId) inner join Uye on (Uye.Id=Odunc.UyeId) inner join Stok on (Stok.KitapId=Odunc.KitapId) where OduncDurumu='Verildi' and UyeId=" + uyeIdNo + " ";

            DataTable dt = new DataTable();

            SqlDataAdapter verilengetir = new SqlDataAdapter(sorgu, frm.baglanti);
            verilengetir.Fill(dt);

            verilenkitaplardgv.DataSource = dt;

            frm.baglanti.Close();
        }
        public void UyeGecikenKitaplar()
        {
            Form1 frm = new Form1();
            frm.baglanti.Open();

            string sorgu = "Select Odunc.UyeId,Uye.Ad as 'Üye Adı', Odunc.KitapId, Kitap.KitapAdi as 'Kitap Adı',Stok.Adet as 'Kitap Adedi',Odunc.VerildigiTarih as 'Verildiği Tarih', Odunc.OduncSuresi as 'Ödünç Süresi', Odunc.OduncDurumu as 'Ödünç Durumu' from Odunc inner join Kitap on (Kitap.Id=Odunc.KitapId) inner join Uye on (Uye.Id=Odunc.UyeId) inner join Stok on (Stok.KitapId=Odunc.KitapId) where OduncDurumu='Gecikti' and UyeId=" + uyeIdNo + " ";

            DataTable dt = new DataTable();

            SqlDataAdapter gecikengetir = new SqlDataAdapter(sorgu, frm.baglanti);
            gecikengetir.Fill(dt);

            gecikenkitaplardgv.DataSource = dt;

            frm.baglanti.Close();
        }
        public void UyeTeslimKitaplar()
        {
            Form1 frm = new Form1();
            frm.baglanti.Open();

            string sorgu = "Select Odunc.UyeId,Uye.Ad as 'Üye Adı', Odunc.KitapId, Kitap.KitapAdi as 'Kitap Adı',Stok.Adet as 'Kitap Adedi',Odunc.VerildigiTarih as 'Verildiği Tarih', Odunc.OduncSuresi as 'Ödünç Süresi', Odunc.OduncDurumu as 'Ödünç Durumu' from Odunc inner join Kitap on (Kitap.Id=Odunc.KitapId) inner join Uye on (Uye.Id=Odunc.UyeId) inner join Stok on (Stok.KitapId=Odunc.KitapId) where OduncDurumu='Alindi' and UyeId=" + uyeIdNo + " ";

            DataTable dt = new DataTable();

            SqlDataAdapter teslimgetir = new SqlDataAdapter(sorgu, frm.baglanti);
            teslimgetir.Fill(dt);

            teslimedilenkitapdgv.DataSource = dt;

            frm.baglanti.Close();
        }
    }
}
