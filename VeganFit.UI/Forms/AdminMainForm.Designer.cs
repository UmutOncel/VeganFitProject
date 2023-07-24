namespace VeganFit.UI
{
    partial class AdminMainForm
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
            pnlMenu = new Panel();
            lblKayitliKullaniciSayisi = new Label();
            lblBilgi = new Label();
            btnCikisYap = new Buttons.DesignButton();
            pnlSecim2 = new Panel();
            pnlSecim1 = new Panel();
            btnBildirimleriGor = new Buttons.DesignButton();
            btnUrunEkle = new Buttons.DesignButton();
            pbxLogo = new PictureBox();
            btnSimgeDurumunaKucult = new Buttons.DesignButton();
            lblSimgeDurumunaKucult = new Label();
            pnlUstMenu = new Panel();
            lblAdminPanel = new Label();
            pnlChildForm = new Panel();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            pnlUstMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.SlateGray;
            pnlMenu.Controls.Add(lblKayitliKullaniciSayisi);
            pnlMenu.Controls.Add(lblBilgi);
            pnlMenu.Controls.Add(btnCikisYap);
            pnlMenu.Controls.Add(pnlSecim2);
            pnlMenu.Controls.Add(pnlSecim1);
            pnlMenu.Controls.Add(btnBildirimleriGor);
            pnlMenu.Controls.Add(btnUrunEkle);
            pnlMenu.Controls.Add(pbxLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(275, 768);
            pnlMenu.TabIndex = 0;
            // 
            // lblKayitliKullaniciSayisi
            // 
            lblKayitliKullaniciSayisi.BackColor = Color.DarkBlue;
            lblKayitliKullaniciSayisi.ForeColor = Color.White;
            lblKayitliKullaniciSayisi.Location = new Point(0, 399);
            lblKayitliKullaniciSayisi.Name = "lblKayitliKullaniciSayisi";
            lblKayitliKullaniciSayisi.Size = new Size(25, 25);
            lblKayitliKullaniciSayisi.TabIndex = 3;
            lblKayitliKullaniciSayisi.Text = "x";
            lblKayitliKullaniciSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBilgi
            // 
            lblBilgi.BackColor = Color.DarkBlue;
            lblBilgi.ForeColor = Color.White;
            lblBilgi.ImageAlign = ContentAlignment.TopCenter;
            lblBilgi.Location = new Point(0, 364);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(155, 25);
            lblBilgi.TabIndex = 3;
            lblBilgi.Text = "Kayıtlı Kullanıcı Sayısı";
            lblBilgi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Transparent;
            btnCikisYap.BackgroundColor = Color.Transparent;
            btnCikisYap.BorderColor = Color.DarkRed;
            btnCikisYap.BorderRadius = 15;
            btnCikisYap.BorderSize = 2;
            btnCikisYap.FlatAppearance.BorderColor = Color.Black;
            btnCikisYap.FlatAppearance.BorderSize = 0;
            btnCikisYap.FlatStyle = FlatStyle.Popup;
            btnCikisYap.ForeColor = Color.White;
            btnCikisYap.Image = Properties.Resources.Çıkış_Butonu;
            btnCikisYap.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikisYap.Location = new Point(0, 715);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(150, 50);
            btnCikisYap.TabIndex = 2;
            btnCikisYap.Text = "                  Çıkış Yap";
            btnCikisYap.TextColor = Color.White;
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // pnlSecim2
            // 
            pnlSecim2.BackColor = Color.ForestGreen;
            pnlSecim2.Location = new Point(0, 285);
            pnlSecim2.Name = "pnlSecim2";
            pnlSecim2.Size = new Size(10, 50);
            pnlSecim2.TabIndex = 1;
            pnlSecim2.Visible = false;
            // 
            // pnlSecim1
            // 
            pnlSecim1.BackColor = Color.ForestGreen;
            pnlSecim1.Location = new Point(0, 225);
            pnlSecim1.Name = "pnlSecim1";
            pnlSecim1.Size = new Size(10, 50);
            pnlSecim1.TabIndex = 1;
            pnlSecim1.Visible = false;
            // 
            // btnBildirimleriGor
            // 
            btnBildirimleriGor.BackColor = Color.Transparent;
            btnBildirimleriGor.BackgroundColor = Color.Transparent;
            btnBildirimleriGor.BorderColor = Color.DarkBlue;
            btnBildirimleriGor.BorderRadius = 10;
            btnBildirimleriGor.BorderSize = 2;
            btnBildirimleriGor.FlatAppearance.BorderSize = 0;
            btnBildirimleriGor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBildirimleriGor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBildirimleriGor.FlatStyle = FlatStyle.Popup;
            btnBildirimleriGor.ForeColor = Color.White;
            btnBildirimleriGor.Image = Properties.Resources.Bildirim_Butonu;
            btnBildirimleriGor.ImageAlign = ContentAlignment.BottomLeft;
            btnBildirimleriGor.Location = new Point(12, 285);
            btnBildirimleriGor.Name = "btnBildirimleriGor";
            btnBildirimleriGor.Size = new Size(260, 50);
            btnBildirimleriGor.TabIndex = 1;
            btnBildirimleriGor.Text = "                Bildirimleri Gör";
            btnBildirimleriGor.TextColor = Color.White;
            btnBildirimleriGor.UseVisualStyleBackColor = false;
            btnBildirimleriGor.Click += btnBildirimleriGor_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.Transparent;
            btnUrunEkle.BackgroundColor = Color.Transparent;
            btnUrunEkle.BorderColor = Color.DarkBlue;
            btnUrunEkle.BorderRadius = 10;
            btnUrunEkle.BorderSize = 2;
            btnUrunEkle.FlatAppearance.BorderSize = 0;
            btnUrunEkle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUrunEkle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUrunEkle.FlatStyle = FlatStyle.Popup;
            btnUrunEkle.ForeColor = Color.White;
            btnUrunEkle.Image = Properties.Resources.Ürün_Ekle_Butonu;
            btnUrunEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrunEkle.Location = new Point(12, 225);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(260, 50);
            btnUrunEkle.TabIndex = 1;
            btnUrunEkle.Text = "                         Ürün Ekle";
            btnUrunEkle.TextColor = Color.White;
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.Logo;
            pbxLogo.Location = new Point(12, 0);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(250, 150);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // btnSimgeDurumunaKucult
            // 
            btnSimgeDurumunaKucult.BackColor = Color.DimGray;
            btnSimgeDurumunaKucult.BackgroundColor = Color.DimGray;
            btnSimgeDurumunaKucult.BorderColor = Color.PaleVioletRed;
            btnSimgeDurumunaKucult.BorderRadius = 10;
            btnSimgeDurumunaKucult.BorderSize = 0;
            btnSimgeDurumunaKucult.FlatAppearance.BorderSize = 0;
            btnSimgeDurumunaKucult.FlatStyle = FlatStyle.Flat;
            btnSimgeDurumunaKucult.ForeColor = Color.White;
            btnSimgeDurumunaKucult.Location = new Point(1064, 1);
            btnSimgeDurumunaKucult.Name = "btnSimgeDurumunaKucult";
            btnSimgeDurumunaKucult.Size = new Size(25, 25);
            btnSimgeDurumunaKucult.TabIndex = 9;
            btnSimgeDurumunaKucult.Text = "_";
            btnSimgeDurumunaKucult.TextAlign = ContentAlignment.TopRight;
            btnSimgeDurumunaKucult.TextColor = Color.White;
            btnSimgeDurumunaKucult.UseVisualStyleBackColor = false;
            btnSimgeDurumunaKucult.Click += btnSimgeDurumunaKucult_Click;
            btnSimgeDurumunaKucult.MouseEnter += btnSimgeDurumunaKucult_MouseEnter;
            btnSimgeDurumunaKucult.MouseLeave += btnSimgeDurumunaKucult_MouseLeave;
            // 
            // lblSimgeDurumunaKucult
            // 
            lblSimgeDurumunaKucult.AutoSize = true;
            lblSimgeDurumunaKucult.BackColor = Color.Transparent;
            lblSimgeDurumunaKucult.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSimgeDurumunaKucult.ForeColor = Color.Black;
            lblSimgeDurumunaKucult.Location = new Point(927, 31);
            lblSimgeDurumunaKucult.Name = "lblSimgeDurumunaKucult";
            lblSimgeDurumunaKucult.Size = new Size(162, 13);
            lblSimgeDurumunaKucult.TabIndex = 8;
            lblSimgeDurumunaKucult.Text = "Simge Durumuna Küçült";
            lblSimgeDurumunaKucult.Visible = false;
            // 
            // pnlUstMenu
            // 
            pnlUstMenu.BackColor = Color.SlateGray;
            pnlUstMenu.Controls.Add(lblAdminPanel);
            pnlUstMenu.Controls.Add(btnSimgeDurumunaKucult);
            pnlUstMenu.Controls.Add(lblSimgeDurumunaKucult);
            pnlUstMenu.Dock = DockStyle.Top;
            pnlUstMenu.Location = new Point(275, 0);
            pnlUstMenu.Name = "pnlUstMenu";
            pnlUstMenu.Size = new Size(1091, 50);
            pnlUstMenu.TabIndex = 10;
            pnlUstMenu.MouseDown += pnlUstMenu_MouseDown;
            pnlUstMenu.MouseMove += pnlUstMenu_MouseMove;
            pnlUstMenu.MouseUp += pnlUstMenu_MouseUp;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Location = new Point(519, 20);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(89, 14);
            lblAdminPanel.TabIndex = 11;
            lblAdminPanel.Text = "Admin Panel";
            // 
            // pnlChildForm
            // 
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Location = new Point(275, 50);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1091, 718);
            pnlChildForm.TabIndex = 11;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlChildForm);
            Controls.Add(pnlUstMenu);
            Controls.Add(pnlMenu);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            FormClosing += AdminMainForm_FormClosing;
            Load += AdminMainForm_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            pnlUstMenu.ResumeLayout(false);
            pnlUstMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private PictureBox pbxLogo;
        private Buttons.DesignButton btnUrunEkle;
        private Buttons.DesignButton btnBildirimleriGor;
        private Panel pnlSecim2;
        private Panel pnlSecim1;
        private Buttons.DesignButton btnCikisYap;
        private Label lblKayitliKullaniciSayisi;
        private Label lblBilgi;
        private Buttons.DesignButton btnSimgeDurumunaKucult;
        private Label lblSimgeDurumunaKucult;
        private Panel pnlUstMenu;
        private Label lblAdminPanel;
        private Panel pnlChildForm;
    }
}