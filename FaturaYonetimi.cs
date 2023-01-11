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
namespace OgrenciKayitSistemi
{
    public partial class FaturaYonetimi : MetroFramework.Forms.MetroForm
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./nuans.accdb;");
        string faturaid;
        string ucret = "";
        faturalar form;
        public FaturaYonetimi(string faturaid,faturalar form)
        {
            this.faturaid = faturaid;
            this.form = form;
            InitializeComponent();
        }

        private void FaturaYonetimi_Load(object sender, EventArgs e)
        {
            string ID = "", ad = "", soyad = "", fatura_tarihi = "", odenenmiktar = "", _tc = "", _adi = "", _soyadi = "";
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from ucret_tablosu where FATURA_ID="+faturaid, baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ID = okuyucu["ID"].ToString();
                fatura_tarihi = okuyucu["FATURA_TARIHI"].ToString();
                odenenmiktar = okuyucu["ODENEN_MIKTAR"].ToString();
            }
            okuyucu.Close();

            OleDbCommand komut2 = new OleDbCommand("select * from kayit where ID=" + ID, baglanti);
            OleDbDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                _tc = okuyucu2["TC"].ToString();
                _adi = okuyucu2["ISIM"].ToString();
                _soyadi = okuyucu2["SOYISIM"].ToString();
                ucret = okuyucu2["UCRET"].ToString();
            }
            okuyucu2.Close();

            string kalanmiktar = (Convert.ToInt32(ucret) - Convert.ToInt32(odenenmiktar)).ToString();

            tc.Text = _tc;
            isim.Text = _adi;
            soyisim.Text = _soyadi;
            fatura.Text = fatura_tarihi;
            kalan.Text = kalanmiktar;
            odenen.Text = odenenmiktar;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
            string odemetarihi = "";

            if (kalan.Text =="0")
            {
                odemetarihi = DateTime.Now.ToString("MM/dd/yyyy");
            }
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update ucret_tablosu SET ODEME_TARIHI='"+odemetarihi+"',ODENEN_MIKTAR='"+odenen.Text+"',KALAN_MIKTAR='"+kalan.Text+"' where FATURA_ID=" + faturaid,baglanti);
            await komut.ExecuteNonQueryAsync();
            metroButton1.Enabled = true;

        }

        private void odenen_Click(object sender, EventArgs e)
        {

        }

        private void odenen_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            
                e.Handled = false;

            else
            

                e.Handled = true;

           


        }

        private void odenen_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void odenen_KeyUp(object sender, KeyEventArgs e)
        {
            int sonuc = 0;
            if (odenen.Text != "")
            {
                int _odenen = Convert.ToInt32(odenen.Text);
                int _kalan = Convert.ToInt32(ucret);
                sonuc= _kalan - _odenen;
                if (sonuc < 0)
                {
                    _kalan = 0;
                    _odenen = Convert.ToInt32(ucret);
                }
                else
                {
                    _kalan = sonuc;
                }
                kalan.Text = _kalan.ToString();
                odenen.Text = _odenen.ToString();
            }
            else
            {
                kalan.Text = ucret;
            }

        }

        private void FaturaYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.VeriGoster();
        }
    }
    
}
