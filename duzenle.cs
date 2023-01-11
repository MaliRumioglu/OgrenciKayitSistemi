using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework;

namespace OgrenciKayitSistemi
{
    public partial class duzenle : MetroFramework.Forms.MetroForm
    {
        string[] branslar = { "Konservatuar", "Piyano", "Gitar", "Keman", "Yan flüt", "Bağlama", "Şan" };
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./nuans.accdb;");
        string id;
        string tc,adi, soyadi, telefon,kayit_tarih,_adres,ucreT,veli_adi,veli_tel,Brans,IsDeleted;

        void changeState(bool deleted)
        {
            OleDbCommand sil = new OleDbCommand("UPDATE kayit SET IsDeleted="+deleted.ToString()+" WHERE ID=" + id, baglanti);
            sil.ExecuteNonQuery();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MetroMessageBox.Show(this, "Silmek istediğinize emin misiniz?", "Silme islemi", MessageBoxButtons.YesNo);
            if (secim == DialogResult.Yes)
                changeState(false);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();

            DialogResult secim = MetroMessageBox.Show(this, "Silmek istediğinize emin misiniz?", "Silme islemi", MessageBoxButtons.YesNo);
            if (secim == DialogResult.Yes)
            {


                    changeState(true);
                    MetroMessageBox.Show(this, "Kayıt silme işlemi başırılı .");
                    DialogResult secim3 = MetroMessageBox.Show(this, "Faturalari da silinsin mi?", "Silme islemi", MessageBoxButtons.YesNo);
                if (secim3 == DialogResult.Yes)
                {
                    DialogResult secim2 = MetroMessageBox.Show(this, "Faturaları silmek istediğinize emin misiniz? BU İŞLEM GERİ ÇEVİRİLEMEZ", "Silme islemi", MessageBoxButtons.YesNo);

                    if (secim2 == DialogResult.Yes)
                    {

                        OleDbCommand sil2 = new OleDbCommand("DELETE FROM ucret_tablosu WHERE ID=" + id, baglanti);
                        sil2.ExecuteNonQuery();
                    }
                }
                this.Dispose();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TumFaturalar faturalar = new TumFaturalar(id);
            faturalar.ShowDialog();
        }

        private void duzenle_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public duzenle(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            kaydet.Enabled = false;
            OleDbCommand guncelle = new OleDbCommand("UPDATE kayit SET TC = '"+TC.Text+"', ISIM='"+isim.Text+"',SOYISIM='"+soyisim.Text+"' , TELEFON_NO='"+telefonnumarasi.Text+"' , KAYITTARIHI='"+kayittarihi.Text+"' , ADRES='"+adres.Text+"' , UCRET="+ucret.Text+" , VELI_ADI='"+veli_isim.Text+"' , VELI_TEL='"+veli_no.Text+"' , BRANS='"+brans.Text+"' WHERE ID="+id, baglanti);           
            guncelle.ExecuteNonQuery();;

            kaydet.Enabled = true;
        }
        private void verioku()
        {
            OleDbCommand komut = new OleDbCommand("select * from kayit where ID  = " + id, baglanti);
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                tc = okuyucu["TC"].ToString();
                adi = okuyucu["ISIM"].ToString();
                soyadi = okuyucu["SOYISIM"].ToString();
                telefon = okuyucu["TELEFON_NO"].ToString();
                kayit_tarih = okuyucu["KAYITTARIHI"].ToString();
                _adres = okuyucu["ADRES"].ToString();
                ucreT = okuyucu["UCRET"].ToString();
                veli_adi = okuyucu["VELI_ADI"].ToString();
                veli_tel = okuyucu["VELI_TEL"].ToString();
                Brans = okuyucu["BRANS"].ToString();
                IsDeleted = okuyucu["IsDeleted"].ToString();
            }
            if (IsDeleted == "True")
            {
                metroButton2.Visible = false;
                metroButton3.Visible = true;
            }
            okuyucu.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            verioku();
            TC.Text = tc;
            isim.Text = adi;
            soyisim.Text = soyadi;
            telefonnumarasi.Text = telefon;
            kayittarihi.Text = kayit_tarih;
            adres.Text = _adres;
            ucret.Text = ucreT;
            veli_isim.Text = veli_adi;
            veli_no.Text = veli_tel;

            brans.Items.Add("");
            brans.SelectedIndex = 0;
            foreach (var item in branslar)
            {
                brans.Items.Add(item);
            }
            brans.Text = Brans; 
        }

    }
}
