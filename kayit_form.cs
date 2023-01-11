using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.OleDb;
namespace OgrenciKayitSistemi
{
    public partial class kayit_form : MetroFramework.Forms.MetroForm
    {
        string[] branslar = {"Konservatuar","Piyano","Gitar","Keman","Yan flüt","Bağlama","Şan" };
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./nuans.accdb;");
        

        void Clearfields()
        {
            TC.Text = "";
            isim.Text = "";
            soyisim.Text = "";
            telefonnumarasi.Text = "";
            veli_isim.Text = "";
            veli_no.Text = "" ;
            ucret.Text = "";
            adres.Text = "";
            kayittarihi.Text = "";
            brans.SelectedIndex = -1;
        }

        void handleKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        public kayit_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            
            foreach (var item in branslar)
            {
                brans.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TC.Text.Length < 11) MetroMessageBox.Show(this,"Lütfen geçerli bir kimlik numarası giriniz.");
            else if (isim.Text.Trim() == "") MetroMessageBox.Show(this,"Lütfen isim giriniz.");
            else if (soyisim.Text.Trim() == "") MetroMessageBox.Show(this,"Lütfen soyisim giriniz.");
            else if (telefonnumarasi.Text.Length < 11) MetroMessageBox.Show(this,"Lütfen geçerli bir telefon numarası giriniz.");
            else if (brans.Text == "") MetroMessageBox.Show(this,"Lütfen branş seçiniz.");
            else if (ucret.Text == "") MetroMessageBox.Show(this,"Lütfen bir ücret giriniz.");
            else if (kayittarihi.Text == "") MetroMessageBox.Show(this,"Lütfen bir tarih giriniz.");
            else if (adres.Text == "") MetroMessageBox.Show(this,"Lütfen bir adres giriniz.");
            else
            {
               DialogResult karar= MetroMessageBox.Show(this,"Kayit etmek istediginizden emin misiniz?","Kayit",MessageBoxButtons.YesNo);
                if (karar == DialogResult.Yes)
                {
                    if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
                    bool bulundu = false;

                    OleDbCommand bul = new OleDbCommand("SELECT * FROM kayit WHERE TC='"+TC.Text+"'",baglanti);

                    OleDbDataReader okuyucu = bul.ExecuteReader();
                    while (okuyucu.Read())
                    {
                        bulundu = true;
                    }
                    if (bulundu == true)
                    {
                        MetroMessageBox.Show(this,"BU T.C. kimlik numarasında bir kayıt zaten mevcut ");
                        return;
                    }

                    OleDbCommand komut = new OleDbCommand("insert into kayit(TC,ISIM,SOYISIM,TELEFON_NO,ADRES,UCRET,KAYITTARIHI,VELI_ADI,VELI_TEL,BRANS) values('" + TC.Text + "','" + isim.Text + "','" + soyisim.Text + "','" + telefonnumarasi.Text + "','" + adres.Text + "'," + ucret.Text + ",'" + kayittarihi.Text + "','" + veli_isim.Text + "','" + veli_no.Text + "','" + brans.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    Clearfields();
                    MetroMessageBox.Show(this, "Kayıt başarılı.");
                }
            }
        }

        private void TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleKeyPress(e);
        }

        private void telefonnumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleKeyPress(e);
        }

        private void Ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleKeyPress(e);
        }

        private void veli_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleKeyPress(e);
        }

        private void kayit_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Dispose();
        }

        private void TC_Click(object sender, EventArgs e)
        {

        }
    }
}
