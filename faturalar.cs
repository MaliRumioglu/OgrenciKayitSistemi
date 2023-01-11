using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace OgrenciKayitSistemi
{
    public partial class faturalar : MetroFramework.Forms.MetroForm
    {
        public faturalar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./nuans.accdb;");
        public void VeriGoster()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter okuyucu = new OleDbDataAdapter("select FATURA_ID,TC,ISIM,SOYISIM,UCRET,FATURA_TARIHI,ODEME_TARIHI,ODENEN_MIKTAR,KALAN_MIKTAR  from ucret_tablosu INNER JOIN kayit ON ucret_tablosu.ID = kayit.ID where ODEME_TARIHI IS NULL OR ODEME_TARIHI=''", baglanti);
            okuyucu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            this.dataGridView1.Sort(this.dataGridView1.Columns["FATURA_TARIHI"], ListSortDirection.Descending);
        }
        private void faturalar_Load(object sender, EventArgs e)
        {
            faturayenile();
            VeriGoster();
        }
        public int GetMonthDifference(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }
        async void faturayenile()
        {
            OleDbCommand komut = new OleDbCommand("select * from kayit", baglanti);
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            OleDbDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                string id = okuyucu["ID"].ToString();
                string kayit_tarih = okuyucu["KAYITTARIHI"].ToString();
                string ucreT = okuyucu["UCRET"].ToString();
                string sonodeme = okuyucu["SON_ODEME"].ToString();

                if (sonodeme == "")
                {
                    DateTime _kayit_old = Convert.ToDateTime(kayit_tarih);
                    DateTime kayit_tarihi = Convert.ToDateTime(_kayit_old.ToString("d/MM/yyyy"));
                    DateTime bugun = DateTime.Now;
                    int ay = GetMonthDifference(kayit_tarihi, bugun);

                    while (ay > 0)
                    {

                        DateTime faturatarihi = kayit_tarihi.AddMonths(ay);

                        bool bulundu = false;
                        string faturatarihi2 = faturatarihi.ToString("d/MM/yyyy");
                        OleDbCommand kontrol = new OleDbCommand("select * from ucret_tablosu where ID=" + id + " and FATURA_TARIHI LIKE '%" + faturatarihi2 + "%'", baglanti);

                        OleDbDataReader okuyucu2 = kontrol.ExecuteReader();
                        while (okuyucu2.Read())
                        {
                            bulundu = true;
                        }
                        okuyucu2.Close();
                        if (!bulundu)
                        {
                            OleDbCommand komut2 = new OleDbCommand("insert into ucret_tablosu(ID,FATURA_TARIHI,KALAN_MIKTAR) values(" + id + ",'" + faturatarihi2 + "','" + ucreT + "')", baglanti);
                            await komut2.ExecuteNonQueryAsync();

                        }
                        ay--;
                    }


                }
                else
                {
                    DateTime sonodemetarihi = Convert.ToDateTime(sonodeme);
                    DateTime bugun = DateTime.Now;
                    var fark = bugun - sonodemetarihi;
                    int ay = fark.Days / 30;


                    while (ay != 0)
                    {

                        DateTime faturatarihi = sonodemetarihi.AddMonths(ay);

                        bool bulundu = false;
                        string faturatarihi2 = faturatarihi.ToString("d/MM/yyyy");
                        OleDbCommand kontrol = new OleDbCommand("select * from ucret_tablosu where ID=" + id + " and FATURA_TARIHI LIKE '%" + faturatarihi2 + "%'", baglanti);

                        OleDbDataReader okuyucu2 = kontrol.ExecuteReader();
                        while (okuyucu2.Read())
                        {
                            bulundu = true;
                        }
                        okuyucu2.Close();
                        if (!bulundu)
                        {
                            OleDbCommand komut2 = new OleDbCommand("insert into ucret_tablosu(ID,FATURA_TARIHI,KALAN_MIKTAR) values(" + id + ",'" + faturatarihi2 + "','" + ucreT + "')", baglanti);
                            await komut2.ExecuteNonQueryAsync();

                        }
                        ay--;
                    }

                }


            }
            okuyucu.Close();

            VeriGoster();
        }
        private async void metroButton1_Click(object sender, EventArgs e)
        {
            faturayenile();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FaturaYonetimi FaturaYonetimi = new FaturaYonetimi(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), this);
            //  duzenle duzenle = new duzenle(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            FaturaYonetimi.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();

            OleDbDataAdapter okuyucu = new OleDbDataAdapter("select FATURA_ID, TC, ISIM, SOYISIM, UCRET, FATURA_TARIHI, ODEME_TARIHI, ODENEN_MIKTAR, KALAN_MIKTAR  from ucret_tablosu INNER JOIN kayit ON ucret_tablosu.ID = kayit.ID where (ODEME_TARIHI IS NULL OR ODEME_TARIHI = '') AND TC LIKE '%" + TC.Text + "%' AND ISIM LIKE '%" + isim.Text + "%' AND SOYISIM LIKE '%" + soyisim.Text + "%'", baglanti);
            okuyucu.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            VeriGoster();
        }
    }
}
