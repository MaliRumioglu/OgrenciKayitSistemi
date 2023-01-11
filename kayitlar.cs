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
    public partial class kayitlar : MetroFramework.Forms.MetroForm
    {
        string[] branslar = { "Konservatuar", "Piyano", "Gitar", "Keman", "Yan flüt", "Bağlama", "Şan" };
        bool deleted = false;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./nuans.accdb;");

        public kayitlar(bool deleted)
        {
            this.deleted = deleted;
            InitializeComponent();
        }
        public void VeriGoster()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter okuyucu = new OleDbDataAdapter("select ID,TC,ISIM,SOYISIM,TELEFON_NO,KAYITTARIHI,ADRES,UCRET,VELI_ADI,VELI_TEL,BRANS,SON_ODEME from kayit where isDeleted=" + deleted.ToString(), baglanti);
            okuyucu.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void kayitlar_Load(object sender, EventArgs e)
        {
            VeriGoster();
            brans.Items.Add("");
            brans.SelectedIndex = 0;
            foreach (var item in branslar)
            {
                brans.Items.Add(item);
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter okuyucu = new OleDbDataAdapter("select * from kayit where TC LIKE '%" + TC.Text + "%' AND ISIM LIKE '%"+isim.Text+"%' AND SOYISIM LIKE '%"+soyisim.Text+"%' AND TELEFON_NO LIKE '%"+ telefonnumarasi.Text+"%' AND BRANS LIKE '%"+brans.Text+"%'", baglanti);          
            okuyucu.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            kayit_form kayitEt = new kayit_form();
            kayitEt.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            duzenle duzenle = new duzenle(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            duzenle.ShowDialog();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            VeriGoster();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            kayit_form kayit = new kayit_form();
            kayit.ShowDialog(); 
        }
    }
}
