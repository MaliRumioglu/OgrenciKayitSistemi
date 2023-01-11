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
    public partial class TumFaturalar : MetroFramework.Forms.MetroForm
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./nuans.accdb;");

        string id = "";
        void VeriGoster()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter okuyucu = new OleDbDataAdapter("select FATURA_TARIHI,ODEME_TARIHI,ODENEN_MIKTAR,KALAN_MIKTAR from ucret_tablosu WHERE ID=" + id, baglanti);
            okuyucu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            this.dataGridView1.Sort(this.dataGridView1.Columns["FATURA_TARIHI"], ListSortDirection.Descending);

        }
        public TumFaturalar(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void TumFaturalar_Load(object sender, EventArgs e)
        {
            VeriGoster();
        }
    }
}
