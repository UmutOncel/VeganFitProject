namespace VeganFit.UI
{
    partial class UserMainForm
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
            btnCikisYap = new Buttons.DesignButton();
            pnlSecim4 = new Panel();
            pnlSecim3 = new Panel();
            pnlSecim2 = new Panel();
            pnlSecim1 = new Panel();
            btnGeriBildirimGönder = new Buttons.DesignButton();
            btnOgununeUrunEkle = new Buttons.DesignButton();
            btnKiloTakip = new Buttons.DesignButton();
            btnVerileriGor = new Buttons.DesignButton();
            pbxLogo = new PictureBox();
            pnlUstMenu = new Panel();
            lblAdminPanel = new Label();
            btnSimgeDurumunaKucult = new Buttons.DesignButton();
            lblSimgeDurumunaKucult = new Label();
            pnlChildForm = new Panel();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            pnlUstMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(1, 121, 111);
            pnlMenu.Controls.Add(btnCikisYap);
            pnlMenu.Controls.Add(pnlSecim4);
            pnlMenu.Controls.Add(pnlSecim3);
            pnlMenu.Controls.Add(pnlSecim2);
            pnlMenu.Controls.Add(pnlSecim1);
            pnlMenu.Controls.Add(btnGeriBildirimGönder);
            pnlMenu.Controls.Add(btnOgununeUrunEkle);
            pnlMenu.Controls.Add(btnKiloTakip);
            pnlMenu.Controls.Add(btnVerileriGor);
            pnlMenu.Controls.Add(pbxLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(275, 768);
            pnlMenu.TabIndex = 1;
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
            btnCikisYap.Location = new Point(1, 716);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(150, 50);
            btnCikisYap.TabIndex = 2;
            btnCikisYap.Text = "                  Çıkış Yap";
            btnCikisYap.TextColor = Color.White;
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // pnlSecim4
            // 
            pnlSecim4.BackColor = Color.Orange;
            pnlSecim4.Location = new Point(0, 405);
            pnlSecim4.Name = "pnlSecim4";
            pnlSecim4.Size = new Size(10, 50);
            pnlSecim4.TabIndex = 1;
            pnlSecim4.Visible = false;
            // 
            // pnlSecim3
            // 
            pnlSecim3.BackColor = Color.Orange;
            pnlSecim3.Location = new Point(0, 345);
            pnlSecim3.Name = "pnlSecim3";
            pnlSecim3.Size = new Size(10, 50);
            pnlSecim3.TabIndex = 1;
            pnlSecim3.Visible = false;
            // 
            // pnlSecim2
            // 
            pnlSecim2.BackColor = Color.Orange;
            pnlSecim2.Location = new Point(0, 285);
            pnlSecim2.Name = "pnlSecim2";
            pnlSecim2.Size = new Size(10, 50);
            pnlSecim2.TabIndex = 1;
            pnlSecim2.Visible = false;
            // 
            // pnlSecim1
            // 
            pnlSecim1.BackColor = Color.Orange;
            pnlSecim1.Location = new Point(0, 225);
            pnlSecim1.Name = "pnlSecim1";
            pnlSecim1.Size = new Size(10, 50);
            pnlSecim1.TabIndex = 1;
            pnlSecim1.Visible = false;
            // 
            // btnGeriBildirimGönder
            // 
            btnGeriBildirimGönder.BackColor = Color.Transparent;
            btnGeriBildirimGönder.BackgroundColor = Color.Transparent;
            btnGeriBildirimGönder.BorderColor = Color.PaleGreen;
            btnGeriBildirimGönder.BorderRadius = 10;
            btnGeriBildirimGönder.BorderSize = 2;
            btnGeriBildirimGönder.FlatAppearance.BorderSize = 0;
            btnGeriBildirimGönder.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGeriBildirimGönder.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGeriBildirimGönder.FlatStyle = FlatStyle.Popup;
            btnGeriBildirimGönder.ForeColor = Color.White;
            btnGeriBildirimGönder.Image = Properties.Resources.Bildirim_Gönder_Butonu;
            btnGeriBildirimGönder.ImageAlign = ContentAlignment.BottomLeft;
            btnGeriBildirimGönder.Location = new Point(12, 405);
            btnGeriBildirimGönder.Name = "btnGeriBildirimGönder";
            btnGeriBildirimGönder.Size = new Size(260, 50);
            btnGeriBildirimGönder.TabIndex = 1;
            btnGeriBildirimGönder.Text = "           Geri Bildirim Gönder";
            btnGeriBildirimGönder.TextColor = Color.White;
            btnGeriBildirimGönder.UseVisualStyleBackColor = false;
            btnGeriBildirimGönder.Click += btnGeriBildirimGönder_Click;
            // 
            // btnOgununeUrunEkle
            // 
            btnOgununeUrunEkle.BackColor = Color.Transparent;
            btnOgununeUrunEkle.BackgroundColor = Color.Transparent;
            btnOgununeUrunEkle.BorderColor = Color.PaleGreen;
            btnOgununeUrunEkle.BorderRadius = 10;
            btnOgununeUrunEkle.BorderSize = 2;
            btnOgununeUrunEkle.FlatAppearance.BorderSize = 0;
            btnOgununeUrunEkle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOgununeUrunEkle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOgununeUrunEkle.FlatStyle = FlatStyle.Popup;
            btnOgununeUrunEkle.ForeColor = Color.White;
            btnOgununeUrunEkle.Image = Properties.Resources.Ürün_Ekle_Butonu;
            btnOgununeUrunEkle.ImageAlign = ContentAlignment.BottomLeft;
            btnOgununeUrunEkle.Location = new Point(12, 345);
            btnOgununeUrunEkle.Name = "btnOgununeUrunEkle";
            btnOgununeUrunEkle.Size = new Size(260, 50);
            btnOgununeUrunEkle.TabIndex = 1;
            btnOgununeUrunEkle.Text = "             Öğününe Ürün Ekle";
            btnOgununeUrunEkle.TextColor = Color.White;
            btnOgununeUrunEkle.UseVisualStyleBackColor = false;
            btnOgununeUrunEkle.Click += btnOgununeUrunEkle_Click;
            // 
            // btnKiloTakip
            // 
            btnKiloTakip.BackColor = Color.Transparent;
            btnKiloTakip.BackgroundColor = Color.Transparent;
            btnKiloTakip.BorderColor = Color.PaleGreen;
            btnKiloTakip.BorderRadius = 10;
            btnKiloTakip.BorderSize = 2;
            btnKiloTakip.FlatAppearance.BorderSize = 0;
            btnKiloTakip.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKiloTakip.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKiloTakip.FlatStyle = FlatStyle.Popup;
            btnKiloTakip.ForeColor = Color.White;
            btnKiloTakip.Image = Properties.Resources.Kilo_Takip_Butonu;
            btnKiloTakip.ImageAlign = ContentAlignment.BottomLeft;
            btnKiloTakip.Location = new Point(12, 285);
            btnKiloTakip.Name = "btnKiloTakip";
            btnKiloTakip.Size = new Size(260, 50);
            btnKiloTakip.TabIndex = 1;
            btnKiloTakip.Text = "                            Kilo Takip";
            btnKiloTakip.TextColor = Color.White;
            btnKiloTakip.UseVisualStyleBackColor = false;
            btnKiloTakip.Click += btnKiloTakip_Click;
            // 
            // btnVerileriGor
            // 
            btnVerileriGor.BackColor = Color.Transparent;
            btnVerileriGor.BackgroundColor = Color.Transparent;
            btnVerileriGor.BorderColor = Color.PaleGreen;
            btnVerileriGor.BorderRadius = 10;
            btnVerileriGor.BorderSize = 2;
            btnVerileriGor.FlatAppearance.BorderSize = 0;
            btnVerileriGor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVerileriGor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVerileriGor.FlatStyle = FlatStyle.Popup;
            btnVerileriGor.ForeColor = Color.White;
            btnVerileriGor.Image = Properties.Resources.Verileri_Gör_Butonu;
            btnVerileriGor.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerileriGor.Location = new Point(12, 225);
            btnVerileriGor.Name = "btnVerileriGor";
            btnVerileriGor.Size = new Size(260, 50);
            btnVerileriGor.TabIndex = 1;
            btnVerileriGor.Text = "                         Verileri Gör";
            btnVerileriGor.TextColor = Color.White;
            btnVerileriGor.UseVisualStyleBackColor = false;
            btnVerileriGor.Click += btnVerileriGor_Click;
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
            // pnlUstMenu
            // 
            pnlUstMenu.BackColor = Color.FromArgb(1, 121, 111);
            pnlUstMenu.Controls.Add(lblAdminPanel);
            pnlUstMenu.Controls.Add(btnSimgeDurumunaKucult);
            pnlUstMenu.Controls.Add(lblSimgeDurumunaKucult);
            pnlUstMenu.Dock = DockStyle.Top;
            pnlUstMenu.Location = new Point(275, 0);
            pnlUstMenu.Name = "pnlUstMenu";
            pnlUstMenu.Size = new Size(1091, 50);
            pnlUstMenu.TabIndex = 11;
            pnlUstMenu.MouseDown += pnlUstMenu_MouseDown;
            pnlUstMenu.MouseMove += pnlUstMenu_MouseMove;
            pnlUstMenu.MouseUp += pnlUstMenu_MouseUp;
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Location = new Point(519, 20);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(0, 14);
            lblAdminPanel.TabIndex = 11;
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
            lblSimgeDurumunaKucult.ForeColor = Color.White;
            lblSimgeDurumunaKucult.Location = new Point(927, 31);
            lblSimgeDurumunaKucult.Name = "lblSimgeDurumunaKucult";
            lblSimgeDurumunaKucult.Size = new Size(162, 13);
            lblSimgeDurumunaKucult.TabIndex = 8;
            lblSimgeDurumunaKucult.Text = "Simge Durumuna Küçült";
            lblSimgeDurumunaKucult.Visible = false;
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = Color.Transparent;
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Location = new Point(275, 50);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1091, 718);
            pnlChildForm.TabIndex = 12;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlChildForm);
            Controls.Add(pnlUstMenu);
            Controls.Add(pnlMenu);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMainForm";
            FormClosing += UserMainForm_FormClosing;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            pnlUstMenu.ResumeLayout(false);
            pnlUstMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Buttons.DesignButton btnCikisYap;
        private Panel pnlSecim2;
        private Panel pnlSecim1;
        private Buttons.DesignButton btnKiloTakip;
        private Buttons.DesignButton btnVerileriGor;
        private PictureBox pbxLogo;
        private Buttons.DesignButton btnOgununeUrunEkle;
        private Panel pnlSecim4;
        private Panel pnlSecim3;
        private Buttons.DesignButton btnGeriBildirimGönder;
        private Panel pnlUstMenu;
        private Label lblAdminPanel;
        private Buttons.DesignButton btnSimgeDurumunaKucult;
        private Label lblSimgeDurumunaKucult;
        private Panel pnlChildForm;
    }
}