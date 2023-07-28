namespace VeganFit.UI
{
    partial class NewRegisterForm
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
            btnKaydiTamamla = new Buttons.DesignButton();
            txtAd = new TextBoxs.TextBox.DesignTextBox();
            txtSoyad = new TextBoxs.TextBox.DesignTextBox();
            txtEMail = new TextBoxs.TextBox.DesignTextBox();
            txtSifre = new TextBoxs.TextBox.DesignTextBox();
            txtSifreyiTekrarGirin = new TextBoxs.TextBox.DesignTextBox();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            dtpDogumTatihi = new DateTimePicker();
            label1 = new Label();
            pnlNewRegisterForm = new Panel();
            lblSifreTekrari = new Label();
            lblSifre = new Label();
            lblEmail = new Label();
            lblDogumTarihi = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            label4 = new Label();
            label3 = new Label();
            lblUyari = new Label();
            label2 = new Label();
            pnlNewRegisterForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnKaydiTamamla
            // 
            btnKaydiTamamla.BackColor = Color.Transparent;
            btnKaydiTamamla.BackgroundColor = Color.Transparent;
            btnKaydiTamamla.BorderColor = Color.DarkViolet;
            btnKaydiTamamla.BorderRadius = 10;
            btnKaydiTamamla.BorderSize = 2;
            btnKaydiTamamla.Enabled = false;
            btnKaydiTamamla.FlatAppearance.BorderSize = 0;
            btnKaydiTamamla.FlatStyle = FlatStyle.Popup;
            btnKaydiTamamla.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydiTamamla.ForeColor = Color.DarkViolet;
            btnKaydiTamamla.Location = new Point(90, 385);
            btnKaydiTamamla.Name = "btnKaydiTamamla";
            btnKaydiTamamla.Size = new Size(120, 30);
            btnKaydiTamamla.TabIndex = 7;
            btnKaydiTamamla.Text = "Kaydı Tamamla";
            btnKaydiTamamla.TextColor = Color.DarkViolet;
            btnKaydiTamamla.UseVisualStyleBackColor = false;
            btnKaydiTamamla.Click += btnKaydiTamamla_Click;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Window;
            txtAd.BorderColor = Color.DarkViolet;
            txtAd.BorderFocusColor = Color.Red;
            txtAd.BorderRadius = 14;
            txtAd.BorderSize = 1;
            txtAd.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAd.Location = new Point(25, 79);
            txtAd.Multiline = false;
            txtAd.Name = "txtAd";
            txtAd.Padding = new Padding(7);
            txtAd.PasswordChar = false;
            txtAd.PlaceholderColor = Color.DarkGray;
            txtAd.PlaceholderText = "";
            txtAd.Size = new Size(250, 28);
            txtAd.TabIndex = 1;
            txtAd.TabStop = false;
            txtAd.UnderlinedStyle = false;
            txtAd._TextChanged += txtAd__TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Window;
            txtSoyad.BorderColor = Color.DarkViolet;
            txtSoyad.BorderFocusColor = Color.Red;
            txtSoyad.BorderRadius = 14;
            txtSoyad.BorderSize = 1;
            txtSoyad.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.Location = new Point(25, 131);
            txtSoyad.Multiline = false;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Padding = new Padding(7);
            txtSoyad.PasswordChar = false;
            txtSoyad.PlaceholderColor = Color.DarkGray;
            txtSoyad.PlaceholderText = "";
            txtSoyad.Size = new Size(250, 28);
            txtSoyad.TabIndex = 2;
            txtSoyad.TabStop = false;
            txtSoyad.UnderlinedStyle = false;
            txtSoyad._TextChanged += txtSoyad__TextChanged;
            // 
            // txtEMail
            // 
            txtEMail.BackColor = SystemColors.Window;
            txtEMail.BorderColor = Color.DarkViolet;
            txtEMail.BorderFocusColor = Color.Red;
            txtEMail.BorderRadius = 14;
            txtEMail.BorderSize = 1;
            txtEMail.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEMail.Location = new Point(25, 230);
            txtEMail.Multiline = false;
            txtEMail.Name = "txtEMail";
            txtEMail.Padding = new Padding(7);
            txtEMail.PasswordChar = false;
            txtEMail.PlaceholderColor = Color.DarkGray;
            txtEMail.PlaceholderText = "";
            txtEMail.Size = new Size(250, 28);
            txtEMail.TabIndex = 4;
            txtEMail.TabStop = false;
            txtEMail.UnderlinedStyle = false;
            txtEMail._TextChanged += txtEMail__TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Window;
            txtSifre.BorderColor = Color.DarkViolet;
            txtSifre.BorderFocusColor = Color.Red;
            txtSifre.BorderRadius = 14;
            txtSifre.BorderSize = 1;
            txtSifre.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(25, 282);
            txtSifre.Multiline = false;
            txtSifre.Name = "txtSifre";
            txtSifre.Padding = new Padding(7);
            txtSifre.PasswordChar = true;
            txtSifre.PlaceholderColor = Color.DarkGray;
            txtSifre.PlaceholderText = "";
            txtSifre.Size = new Size(250, 28);
            txtSifre.TabIndex = 5;
            txtSifre.TabStop = false;
            txtSifre.UnderlinedStyle = false;
            txtSifre._TextChanged += txtSifre__TextChanged;
            // 
            // txtSifreyiTekrarGirin
            // 
            txtSifreyiTekrarGirin.BackColor = SystemColors.Window;
            txtSifreyiTekrarGirin.BorderColor = Color.DarkViolet;
            txtSifreyiTekrarGirin.BorderFocusColor = Color.Red;
            txtSifreyiTekrarGirin.BorderRadius = 14;
            txtSifreyiTekrarGirin.BorderSize = 1;
            txtSifreyiTekrarGirin.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifreyiTekrarGirin.Location = new Point(25, 332);
            txtSifreyiTekrarGirin.Multiline = false;
            txtSifreyiTekrarGirin.Name = "txtSifreyiTekrarGirin";
            txtSifreyiTekrarGirin.Padding = new Padding(7);
            txtSifreyiTekrarGirin.PasswordChar = true;
            txtSifreyiTekrarGirin.PlaceholderColor = Color.DarkGray;
            txtSifreyiTekrarGirin.PlaceholderText = "";
            txtSifreyiTekrarGirin.Size = new Size(250, 28);
            txtSifreyiTekrarGirin.TabIndex = 6;
            txtSifreyiTekrarGirin.TabStop = false;
            txtSifreyiTekrarGirin.UnderlinedStyle = false;
            txtSifreyiTekrarGirin._TextChanged += txtSifreyiTekrarGirin__TextChanged;
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(255, 28);
            lblKapat.Name = "lblKapat";
            lblKapat.Size = new Size(44, 13);
            lblKapat.TabIndex = 8;
            lblKapat.Text = "Kapat";
            lblKapat.Visible = false;
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
            btnKapat.Location = new Point(274, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 8;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // dtpDogumTatihi
            // 
            dtpDogumTatihi.Location = new Point(25, 183);
            dtpDogumTatihi.Name = "dtpDogumTatihi";
            dtpDogumTatihi.Size = new Size(250, 22);
            dtpDogumTatihi.TabIndex = 3;
            dtpDogumTatihi.Value = new DateTime(1978, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(103, 31);
            label1.Name = "label1";
            label1.Size = new Size(95, 14);
            label1.TabIndex = 10;
            label1.Text = "Üyelik Formu";
            // 
            // pnlNewRegisterForm
            // 
            pnlNewRegisterForm.Controls.Add(lblSifreTekrari);
            pnlNewRegisterForm.Controls.Add(lblSifre);
            pnlNewRegisterForm.Controls.Add(lblEmail);
            pnlNewRegisterForm.Controls.Add(lblDogumTarihi);
            pnlNewRegisterForm.Controls.Add(lblSoyad);
            pnlNewRegisterForm.Controls.Add(lblAd);
            pnlNewRegisterForm.Controls.Add(label4);
            pnlNewRegisterForm.Controls.Add(label3);
            pnlNewRegisterForm.Controls.Add(lblUyari);
            pnlNewRegisterForm.Controls.Add(label2);
            pnlNewRegisterForm.Dock = DockStyle.Fill;
            pnlNewRegisterForm.Location = new Point(0, 0);
            pnlNewRegisterForm.Name = "pnlNewRegisterForm";
            pnlNewRegisterForm.Size = new Size(300, 500);
            pnlNewRegisterForm.TabIndex = 11;
            pnlNewRegisterForm.MouseDown += pnlNewRegisterForm_MouseDown;
            pnlNewRegisterForm.MouseMove += pnlNewRegisterForm_MouseMove;
            pnlNewRegisterForm.MouseUp += pnlNewRegisterForm_MouseUp;
            // 
            // lblSifreTekrari
            // 
            lblSifreTekrari.AutoSize = true;
            lblSifreTekrari.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifreTekrari.ForeColor = Color.DarkViolet;
            lblSifreTekrari.Location = new Point(25, 317);
            lblSifreTekrari.Name = "lblSifreTekrari";
            lblSifreTekrari.Size = new Size(96, 14);
            lblSifreTekrari.TabIndex = 10;
            lblSifreTekrari.Text = "Şifre Tekrarı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = Color.DarkViolet;
            lblSifre.Location = new Point(25, 265);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 14);
            lblSifre.TabIndex = 10;
            lblSifre.Text = "Şifre:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.DarkViolet;
            lblEmail.Location = new Point(25, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 14);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDogumTarihi.ForeColor = Color.DarkViolet;
            lblDogumTarihi.Location = new Point(25, 166);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(100, 14);
            lblDogumTarihi.TabIndex = 10;
            lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoyad.ForeColor = Color.DarkViolet;
            lblSoyad.Location = new Point(25, 114);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 14);
            lblSoyad.TabIndex = 10;
            lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAd.ForeColor = Color.DarkViolet;
            lblAd.Location = new Point(25, 62);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 14);
            lblAd.TabIndex = 10;
            lblAd.Text = "Ad:";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(3, 484);
            label4.Name = "label4";
            label4.Size = new Size(272, 15);
            label4.TabIndex = 0;
            label4.Text = "!,:,+.* karakterlerinden en az 1 tanesini içermelidir.";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkViolet;
            label3.Location = new Point(3, 470);
            label3.Name = "label3";
            label3.Size = new Size(285, 15);
            label3.TabIndex = 0;
            label3.Text = "En az 1 büyük harf, 1 küçük harf, 1 rakam içermelidir.";
            // 
            // lblUyari
            // 
            lblUyari.Font = new Font("Verdana", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUyari.ForeColor = Color.DarkViolet;
            lblUyari.Location = new Point(3, 440);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(195, 15);
            lblUyari.TabIndex = 0;
            lblUyari.Text = "UYARI:";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(3, 455);
            label2.Name = "label2";
            label2.Size = new Size(195, 15);
            label2.TabIndex = 0;
            label2.Text = "Şifreniz en az 4 karakterli olmalıdır.";
            // 
            // NewRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 500);
            Controls.Add(label1);
            Controls.Add(dtpDogumTatihi);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(txtSifreyiTekrarGirin);
            Controls.Add(txtSifre);
            Controls.Add(txtEMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnKaydiTamamla);
            Controls.Add(pnlNewRegisterForm);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(70, 205, 207);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewRegisterForm";
            pnlNewRegisterForm.ResumeLayout(false);
            pnlNewRegisterForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBoxs.TextBox.DesignTextBox txtAd;
        private TextBoxs.TextBox.DesignTextBox txtSoyad;
        private TextBoxs.TextBox.DesignTextBox txtEMail;
        private TextBoxs.TextBox.DesignTextBox txtSifre;
        private TextBoxs.TextBox.DesignTextBox txtSifreyiTekrarGirin;
        public Buttons.DesignButton btnKaydiTamamla;
        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
        private DateTimePicker dtpDogumTatihi;
        private Label label1;
        private Panel pnlNewRegisterForm;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label lblUyari;
        private Label lblSifreTekrari;
        private Label lblSifre;
        private Label lblEmail;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblAd;
    }
}