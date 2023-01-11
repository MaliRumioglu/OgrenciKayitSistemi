using System;

namespace OgrenciKayitSistemi
{
    public partial class dashboard : MetroFramework.Forms.MetroForm
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            tileItem1.Text = "Faturalar";
            
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            faturalar faturalar = new faturalar();
            faturalar.ShowDialog();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            kayit_form kayit = new kayit_form();
            kayit.ShowDialog();
        }

        private void Tileitem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            kayitlar kayitlar = new kayitlar(false);
            kayitlar.ShowDialog();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            kayitlar kayitlar = new kayitlar(true);
            kayitlar.Text = "Eski ögrenciler";
            kayitlar.ShowDialog();
        }
    }
}
