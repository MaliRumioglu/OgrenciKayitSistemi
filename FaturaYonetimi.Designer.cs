
namespace OgrenciKayitSistemi
{
    partial class FaturaYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.odenen = new MetroFramework.Controls.MetroTextBox();
            this.kalan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.fatura = new MetroFramework.Controls.MetroTextBox();
            this.tc = new MetroFramework.Controls.MetroTextBox();
            this.isim = new MetroFramework.Controls.MetroTextBox();
            this.soyisim = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // odenen
            // 
            // 
            // 
            // 
            this.odenen.CustomButton.Image = null;
            this.odenen.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.odenen.CustomButton.Name = "";
            this.odenen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.odenen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.odenen.CustomButton.TabIndex = 1;
            this.odenen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.odenen.CustomButton.UseSelectable = true;
            this.odenen.CustomButton.Visible = false;
            this.odenen.Lines = new string[0];
            this.odenen.Location = new System.Drawing.Point(421, 62);
            this.odenen.MaxLength = 32767;
            this.odenen.Name = "odenen";
            this.odenen.PasswordChar = '\0';
            this.odenen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.odenen.SelectedText = "";
            this.odenen.SelectionLength = 0;
            this.odenen.SelectionStart = 0;
            this.odenen.ShortcutsEnabled = true;
            this.odenen.Size = new System.Drawing.Size(164, 23);
            this.odenen.TabIndex = 2;
            this.odenen.UseSelectable = true;
            this.odenen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.odenen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.odenen.Click += new System.EventHandler(this.odenen_Click);
            this.odenen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.odenen_KeyPress);
            this.odenen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.odenen_KeyUp);
            this.odenen.Layout += new System.Windows.Forms.LayoutEventHandler(this.odenen_Layout);
            // 
            // kalan
            // 
            this.kalan.BackColor = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.kalan.CustomButton.Image = null;
            this.kalan.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.kalan.CustomButton.Name = "";
            this.kalan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kalan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kalan.CustomButton.TabIndex = 1;
            this.kalan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kalan.CustomButton.UseSelectable = true;
            this.kalan.CustomButton.Visible = false;
            this.kalan.Enabled = false;
            this.kalan.Lines = new string[0];
            this.kalan.Location = new System.Drawing.Point(421, 91);
            this.kalan.MaxLength = 32767;
            this.kalan.Name = "kalan";
            this.kalan.PasswordChar = '\0';
            this.kalan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kalan.SelectedText = "";
            this.kalan.SelectionLength = 0;
            this.kalan.SelectionStart = 0;
            this.kalan.ShortcutsEnabled = true;
            this.kalan.Size = new System.Drawing.Size(164, 23);
            this.kalan.TabIndex = 4;
            this.kalan.UseCustomBackColor = true;
            this.kalan.UseSelectable = true;
            this.kalan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kalan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(93, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "T.C";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(87, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Isim";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Soyisim";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(334, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Kalan miktar";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(318, 62);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Odenen miktar";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(340, 33);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Fatura tarhi";
            // 
            // fatura
            // 
            this.fatura.BackColor = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.fatura.CustomButton.Image = null;
            this.fatura.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.fatura.CustomButton.Name = "";
            this.fatura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fatura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fatura.CustomButton.TabIndex = 1;
            this.fatura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fatura.CustomButton.UseSelectable = true;
            this.fatura.CustomButton.Visible = false;
            this.fatura.Enabled = false;
            this.fatura.Lines = new string[0];
            this.fatura.Location = new System.Drawing.Point(421, 33);
            this.fatura.MaxLength = 32767;
            this.fatura.Name = "fatura";
            this.fatura.PasswordChar = '\0';
            this.fatura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fatura.SelectedText = "";
            this.fatura.SelectionLength = 0;
            this.fatura.SelectionStart = 0;
            this.fatura.ShortcutsEnabled = true;
            this.fatura.Size = new System.Drawing.Size(164, 23);
            this.fatura.TabIndex = 12;
            this.fatura.UseCustomBackColor = true;
            this.fatura.UseSelectable = true;
            this.fatura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fatura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tc
            // 
            this.tc.BackColor = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tc.CustomButton.Image = null;
            this.tc.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tc.CustomButton.Name = "";
            this.tc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tc.CustomButton.TabIndex = 1;
            this.tc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tc.CustomButton.UseSelectable = true;
            this.tc.CustomButton.Visible = false;
            this.tc.Enabled = false;
            this.tc.Lines = new string[0];
            this.tc.Location = new System.Drawing.Point(125, 33);
            this.tc.MaxLength = 32767;
            this.tc.Name = "tc";
            this.tc.PasswordChar = '\0';
            this.tc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tc.SelectedText = "";
            this.tc.SelectionLength = 0;
            this.tc.SelectionStart = 0;
            this.tc.ShortcutsEnabled = true;
            this.tc.Size = new System.Drawing.Size(164, 23);
            this.tc.TabIndex = 13;
            this.tc.UseCustomBackColor = true;
            this.tc.UseSelectable = true;
            this.tc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.isim.CustomButton.Image = null;
            this.isim.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.isim.CustomButton.Name = "";
            this.isim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.isim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.isim.CustomButton.TabIndex = 1;
            this.isim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.isim.CustomButton.UseSelectable = true;
            this.isim.CustomButton.Visible = false;
            this.isim.Enabled = false;
            this.isim.Lines = new string[0];
            this.isim.Location = new System.Drawing.Point(125, 63);
            this.isim.MaxLength = 32767;
            this.isim.Name = "isim";
            this.isim.PasswordChar = '\0';
            this.isim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.isim.SelectedText = "";
            this.isim.SelectionLength = 0;
            this.isim.SelectionStart = 0;
            this.isim.ShortcutsEnabled = true;
            this.isim.Size = new System.Drawing.Size(164, 23);
            this.isim.TabIndex = 14;
            this.isim.UseCustomBackColor = true;
            this.isim.UseSelectable = true;
            this.isim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.isim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // soyisim
            // 
            this.soyisim.BackColor = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.soyisim.CustomButton.Image = null;
            this.soyisim.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.soyisim.CustomButton.Name = "";
            this.soyisim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.soyisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.soyisim.CustomButton.TabIndex = 1;
            this.soyisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.soyisim.CustomButton.UseSelectable = true;
            this.soyisim.CustomButton.Visible = false;
            this.soyisim.Enabled = false;
            this.soyisim.Lines = new string[0];
            this.soyisim.Location = new System.Drawing.Point(125, 95);
            this.soyisim.MaxLength = 32767;
            this.soyisim.Name = "soyisim";
            this.soyisim.PasswordChar = '\0';
            this.soyisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.soyisim.SelectedText = "";
            this.soyisim.SelectionLength = 0;
            this.soyisim.SelectionStart = 0;
            this.soyisim.ShortcutsEnabled = true;
            this.soyisim.Size = new System.Drawing.Size(164, 23);
            this.soyisim.TabIndex = 15;
            this.soyisim.UseCustomBackColor = true;
            this.soyisim.UseSelectable = true;
            this.soyisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.soyisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(628, 32);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(154, 82);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Kaydet";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FaturaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 269);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.fatura);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.kalan);
            this.Controls.Add(this.odenen);
            this.Name = "FaturaYonetimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaturaYonetimi_FormClosing);
            this.Load += new System.EventHandler(this.FaturaYonetimi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox odenen;
        private MetroFramework.Controls.MetroTextBox kalan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox fatura;
        private MetroFramework.Controls.MetroTextBox tc;
        private MetroFramework.Controls.MetroTextBox isim;
        private MetroFramework.Controls.MetroTextBox soyisim;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}