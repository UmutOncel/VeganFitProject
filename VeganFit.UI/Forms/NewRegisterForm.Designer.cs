﻿namespace VeganFit.UI
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
            SuspendLayout();
            // 
            // btnKaydiTamamla
            // 
            btnKaydiTamamla.BackColor = Color.Transparent;
            btnKaydiTamamla.BackgroundColor = Color.Transparent;
            btnKaydiTamamla.BorderColor = Color.DarkViolet;
            btnKaydiTamamla.BorderRadius = 10;
            btnKaydiTamamla.BorderSize = 2;
            btnKaydiTamamla.FlatAppearance.BorderSize = 0;
            btnKaydiTamamla.FlatStyle = FlatStyle.Popup;
            btnKaydiTamamla.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydiTamamla.ForeColor = Color.DarkViolet;
            btnKaydiTamamla.Location = new Point(90, 350);
            btnKaydiTamamla.Name = "btnKaydiTamamla";
            btnKaydiTamamla.Size = new Size(120, 30);
            btnKaydiTamamla.TabIndex = 0;
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
            txtAd.Location = new Point(25, 99);
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
            txtAd.Enter += txtAd_Enter;
            txtAd.Leave += txtAd_Leave;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Window;
            txtSoyad.BorderColor = Color.DarkViolet;
            txtSoyad.BorderFocusColor = Color.Red;
            txtSoyad.BorderRadius = 14;
            txtSoyad.BorderSize = 1;
            txtSoyad.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.Location = new Point(25, 139);
            txtSoyad.Multiline = false;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Padding = new Padding(7);
            txtSoyad.PasswordChar = false;
            txtSoyad.PlaceholderColor = Color.DarkGray;
            txtSoyad.PlaceholderText = "";
            txtSoyad.Size = new Size(250, 28);
            txtSoyad.TabIndex = 1;
            txtSoyad.TabStop = false;
            txtSoyad.UnderlinedStyle = false;
            txtSoyad.Enter += txtSoyad_Enter;
            txtSoyad.Leave += txtSoyad_Leave;
            // 
            // txtEMail
            // 
            txtEMail.BackColor = SystemColors.Window;
            txtEMail.BorderColor = Color.DarkViolet;
            txtEMail.BorderFocusColor = Color.Red;
            txtEMail.BorderRadius = 14;
            txtEMail.BorderSize = 1;
            txtEMail.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEMail.Location = new Point(25, 214);
            txtEMail.Multiline = false;
            txtEMail.Name = "txtEMail";
            txtEMail.Padding = new Padding(7);
            txtEMail.PasswordChar = false;
            txtEMail.PlaceholderColor = Color.DarkGray;
            txtEMail.PlaceholderText = "";
            txtEMail.Size = new Size(250, 28);
            txtEMail.TabIndex = 1;
            txtEMail.TabStop = false;
            txtEMail.UnderlinedStyle = false;
            txtEMail.Enter += txtEMail_Enter;
            txtEMail.Leave += txtEMail_Leave;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Window;
            txtSifre.BorderColor = Color.DarkViolet;
            txtSifre.BorderFocusColor = Color.Red;
            txtSifre.BorderRadius = 14;
            txtSifre.BorderSize = 1;
            txtSifre.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(25, 254);
            txtSifre.Multiline = false;
            txtSifre.Name = "txtSifre";
            txtSifre.Padding = new Padding(7);
            txtSifre.PasswordChar = false;
            txtSifre.PlaceholderColor = Color.DarkGray;
            txtSifre.PlaceholderText = "";
            txtSifre.Size = new Size(250, 28);
            txtSifre.TabIndex = 1;
            txtSifre.TabStop = false;
            txtSifre.UnderlinedStyle = false;
            txtSifre.Enter += txtSifre_Enter;
            txtSifre.Leave += txtSifre_Leave;
            // 
            // txtSifreyiTekrarGirin
            // 
            txtSifreyiTekrarGirin.BackColor = SystemColors.Window;
            txtSifreyiTekrarGirin.BorderColor = Color.DarkViolet;
            txtSifreyiTekrarGirin.BorderFocusColor = Color.Red;
            txtSifreyiTekrarGirin.BorderRadius = 14;
            txtSifreyiTekrarGirin.BorderSize = 1;
            txtSifreyiTekrarGirin.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifreyiTekrarGirin.Location = new Point(25, 294);
            txtSifreyiTekrarGirin.Multiline = false;
            txtSifreyiTekrarGirin.Name = "txtSifreyiTekrarGirin";
            txtSifreyiTekrarGirin.Padding = new Padding(7);
            txtSifreyiTekrarGirin.PasswordChar = false;
            txtSifreyiTekrarGirin.PlaceholderColor = Color.DarkGray;
            txtSifreyiTekrarGirin.PlaceholderText = "";
            txtSifreyiTekrarGirin.Size = new Size(250, 28);
            txtSifreyiTekrarGirin.TabIndex = 1;
            txtSifreyiTekrarGirin.TabStop = false;
            txtSifreyiTekrarGirin.UnderlinedStyle = false;
            txtSifreyiTekrarGirin.Enter += txtSifreyiTekrarGirin_Enter;
            txtSifreyiTekrarGirin.Leave += txtSifreyiTekrarGirin_Leave;
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
            btnKapat.TabIndex = 7;
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
            dtpDogumTatihi.Location = new Point(25, 179);
            dtpDogumTatihi.MaxDate = new DateTime(1978, 12, 31, 0, 0, 0, 0);
            dtpDogumTatihi.MinDate = new DateTime(1959, 12, 31, 0, 0, 0, 0);
            dtpDogumTatihi.Name = "dtpDogumTatihi";
            dtpDogumTatihi.Size = new Size(250, 22);
            dtpDogumTatihi.TabIndex = 9;
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
            pnlNewRegisterForm.Dock = DockStyle.Fill;
            pnlNewRegisterForm.Location = new Point(0, 0);
            pnlNewRegisterForm.Name = "pnlNewRegisterForm";
            pnlNewRegisterForm.Size = new Size(300, 400);
            pnlNewRegisterForm.TabIndex = 11;
            pnlNewRegisterForm.MouseDown += pnlNewRegisterForm_MouseDown;
            pnlNewRegisterForm.MouseMove += pnlNewRegisterForm_MouseMove;
            pnlNewRegisterForm.MouseUp += pnlNewRegisterForm_MouseUp;
            // 
            // NewRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
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
            Load += NewRegisterForm_Load;
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
    }
}