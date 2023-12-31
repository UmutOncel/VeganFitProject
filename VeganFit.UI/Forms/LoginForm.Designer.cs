﻿namespace VeganFit.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLoginUI = new Panel();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            btnSimgeDurumunaKucult = new Buttons.DesignButton();
            lblSimgeDurumunaKucult = new Label();
            lblKapat = new Label();
            btnUyeOl = new Buttons.DesignButton();
            pbxLogo = new PictureBox();
            btnKapat = new Buttons.DesignButton();
            btnGiris = new Buttons.DesignButton();
            txtSifre = new TextBoxs.TextBox.DesignTextBox();
            txtKullaniciAdi = new TextBoxs.TextBox.DesignTextBox();
            pnlLoginUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginUI
            // 
            pnlLoginUI.BackgroundImage = (Image)resources.GetObject("pnlLoginUI.BackgroundImage");
            pnlLoginUI.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLoginUI.Controls.Add(lblKullaniciAdi);
            pnlLoginUI.Controls.Add(lblSifre);
            pnlLoginUI.Controls.Add(btnSimgeDurumunaKucult);
            pnlLoginUI.Controls.Add(lblSimgeDurumunaKucult);
            pnlLoginUI.Controls.Add(lblKapat);
            pnlLoginUI.Controls.Add(btnUyeOl);
            pnlLoginUI.Controls.Add(pbxLogo);
            pnlLoginUI.Controls.Add(btnKapat);
            pnlLoginUI.Controls.Add(btnGiris);
            pnlLoginUI.Controls.Add(txtSifre);
            pnlLoginUI.Controls.Add(txtKullaniciAdi);
            pnlLoginUI.Dock = DockStyle.Fill;
            pnlLoginUI.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pnlLoginUI.Location = new Point(0, 0);
            pnlLoginUI.Name = "pnlLoginUI";
            pnlLoginUI.Size = new Size(800, 600);
            pnlLoginUI.TabIndex = 0;
            pnlLoginUI.MouseDown += pnlLoginUI_MouseDown;
            pnlLoginUI.MouseMove += pnlLoginUI_MouseMove;
            pnlLoginUI.MouseUp += pnlLoginUI_MouseUp;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.FlatStyle = FlatStyle.Flat;
            lblKullaniciAdi.ForeColor = Color.FromArgb(70, 205, 207);
            lblKullaniciAdi.Location = new Point(385, 255);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(88, 14);
            lblKullaniciAdi.TabIndex = 7;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.ForeColor = Color.FromArgb(70, 205, 207);
            lblSifre.Location = new Point(405, 314);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(39, 14);
            lblSifre.TabIndex = 7;
            lblSifre.Text = "Şifre";
            // 
            // btnSimgeDurumunaKucult
            // 
            btnSimgeDurumunaKucult.BackColor = Color.Gray;
            btnSimgeDurumunaKucult.BackgroundColor = Color.Gray;
            btnSimgeDurumunaKucult.BorderColor = Color.PaleVioletRed;
            btnSimgeDurumunaKucult.BorderRadius = 10;
            btnSimgeDurumunaKucult.BorderSize = 0;
            btnSimgeDurumunaKucult.FlatAppearance.BorderSize = 0;
            btnSimgeDurumunaKucult.FlatStyle = FlatStyle.Flat;
            btnSimgeDurumunaKucult.ForeColor = Color.White;
            btnSimgeDurumunaKucult.Location = new Point(747, 1);
            btnSimgeDurumunaKucult.Name = "btnSimgeDurumunaKucult";
            btnSimgeDurumunaKucult.Size = new Size(25, 25);
            btnSimgeDurumunaKucult.TabIndex = 5;
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
            lblSimgeDurumunaKucult.ForeColor = Color.Gray;
            lblSimgeDurumunaKucult.Location = new Point(612, 32);
            lblSimgeDurumunaKucult.Name = "lblSimgeDurumunaKucult";
            lblSimgeDurumunaKucult.Size = new Size(162, 13);
            lblSimgeDurumunaKucult.TabIndex = 6;
            lblSimgeDurumunaKucult.Text = "Simge Durumuna Küçült";
            lblSimgeDurumunaKucult.Visible = false;
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(757, 32);
            lblKapat.Name = "lblKapat";
            lblKapat.Size = new Size(44, 13);
            lblKapat.TabIndex = 6;
            lblKapat.Text = "Kapat";
            lblKapat.Visible = false;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.Transparent;
            btnUyeOl.BackgroundColor = Color.Transparent;
            btnUyeOl.BorderColor = Color.DarkViolet;
            btnUyeOl.BorderRadius = 5;
            btnUyeOl.BorderSize = 2;
            btnUyeOl.FlatAppearance.BorderSize = 0;
            btnUyeOl.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnUyeOl.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnUyeOl.FlatStyle = FlatStyle.Popup;
            btnUyeOl.ForeColor = Color.DarkViolet;
            btnUyeOl.Location = new Point(576, 578);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(225, 22);
            btnUyeOl.TabIndex = 4;
            btnUyeOl.Text = "Üye değil misin ? Hemen üye ol.";
            btnUyeOl.TextColor = Color.DarkViolet;
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.Transparent;
            pbxLogo.Image = Properties.Resources.Logo;
            pbxLogo.Location = new Point(300, 116);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(250, 150);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 3;
            pbxLogo.TabStop = false;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.Red;
            btnKapat.BackgroundColor = Color.Red;
            btnKapat.BorderColor = Color.PaleVioletRed;
            btnKapat.BorderRadius = 10;
            btnKapat.BorderSize = 0;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(774, 1);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 6;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Transparent;
            btnGiris.BackgroundColor = Color.Transparent;
            btnGiris.BorderColor = Color.FromArgb(70, 205, 207);
            btnGiris.BorderRadius = 15;
            btnGiris.BorderSize = 2;
            btnGiris.Enabled = false;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Popup;
            btnGiris.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.FromArgb(70, 205, 207);
            btnGiris.Location = new Point(374, 381);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(110, 40);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.TextColor = Color.FromArgb(70, 205, 207);
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.WhiteSmoke;
            txtSifre.BorderColor = Color.FromArgb(70, 205, 207);
            txtSifre.BorderFocusColor = Color.SeaGreen;
            txtSifre.BorderRadius = 14;
            txtSifre.BorderSize = 1;
            txtSifre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.ForeColor = Color.FromArgb(70, 205, 207);
            txtSifre.Location = new Point(300, 331);
            txtSifre.Multiline = false;
            txtSifre.Name = "txtSifre";
            txtSifre.Padding = new Padding(7);
            txtSifre.PasswordChar = true;
            txtSifre.PlaceholderColor = Color.DarkGray;
            txtSifre.PlaceholderText = "";
            txtSifre.Size = new Size(250, 29);
            txtSifre.TabIndex = 2;
            txtSifre.TabStop = false;
            txtSifre.UnderlinedStyle = false;
            txtSifre._TextChanged += txtKullaniciAdi__TextChanged;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.WhiteSmoke;
            txtKullaniciAdi.BorderColor = Color.FromArgb(70, 205, 207);
            txtKullaniciAdi.BorderFocusColor = Color.Red;
            txtKullaniciAdi.BorderRadius = 14;
            txtKullaniciAdi.BorderSize = 1;
            txtKullaniciAdi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtKullaniciAdi.ForeColor = Color.FromArgb(70, 205, 207);
            txtKullaniciAdi.Location = new Point(300, 272);
            txtKullaniciAdi.Multiline = false;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Padding = new Padding(7);
            txtKullaniciAdi.PasswordChar = false;
            txtKullaniciAdi.PlaceholderColor = Color.DarkGray;
            txtKullaniciAdi.PlaceholderText = "";
            txtKullaniciAdi.Size = new Size(250, 29);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TabStop = false;
            txtKullaniciAdi.UnderlinedStyle = false;
            txtKullaniciAdi._TextChanged += txtKullaniciAdi__TextChanged;
            // 
            // LoginForm
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(800, 600);
            Controls.Add(pnlLoginUI);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            pnlLoginUI.ResumeLayout(false);
            pnlLoginUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginUI;
        private TextBoxs.TextBox.DesignTextBox txtSifre;
        private TextBoxs.TextBox.DesignTextBox txtKullaniciAdi;
        private Buttons.DesignButton btnGiris;
        private Buttons.DesignButton btnKapat;
        private PictureBox pbxLogo;
        private Buttons.DesignButton btnUyeOl;
        private Label lblKapat;
        private Label lblSimgeDurumunaKucult;
        private Buttons.DesignButton btnSimgeDurumunaKucult;
        private Label lblKullaniciAdi;
        private Label lblSifre;
    }
}