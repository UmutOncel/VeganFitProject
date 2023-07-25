﻿namespace VeganFit.UI
{
    partial class UserAddWeigthForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            txtKilo = new TextBoxs.TextBox.DesignTextBox();
            btnKaydet = new Buttons.DesignButton();
            dgvGunlukKiloTakibi = new DataGridView();
            dtpTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvGunlukKiloTakibi).BeginInit();
            SuspendLayout();
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(1049, 28);
            lblKapat.Name = "lblKapat";
            lblKapat.Size = new Size(44, 13);
            lblKapat.TabIndex = 14;
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
            btnKapat.Location = new Point(1065, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 13;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // txtKilo
            // 
            txtKilo.BackColor = Color.MediumAquamarine;
            txtKilo.BorderColor = Color.DarkGreen;
            txtKilo.BorderFocusColor = Color.Red;
            txtKilo.BorderRadius = 14;
            txtKilo.BorderSize = 1;
            txtKilo.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtKilo.ForeColor = Color.Black;
            txtKilo.Location = new Point(66, 338);
            txtKilo.Multiline = false;
            txtKilo.Name = "txtKilo";
            txtKilo.Padding = new Padding(7);
            txtKilo.PasswordChar = false;
            txtKilo.PlaceholderColor = Color.Black;
            txtKilo.PlaceholderText = "";
            txtKilo.Size = new Size(250, 29);
            txtKilo.TabIndex = 15;
            txtKilo.TabStop = false;
            txtKilo.UnderlinedStyle = false;
            txtKilo._TextChanged += txtKilo__TextChanged;
            txtKilo.Enter += txtKilo_Enter;
            txtKilo.Leave += txtKilo_Leave;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Transparent;
            btnKaydet.BackgroundColor = Color.Transparent;
            btnKaydet.BorderColor = Color.DarkGreen;
            btnKaydet.BorderRadius = 15;
            btnKaydet.BorderSize = 2;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(206, 386);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(110, 40);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextColor = Color.Black;
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dgvGunlukKiloTakibi
            // 
            dataGridViewCellStyle1.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvGunlukKiloTakibi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGunlukKiloTakibi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGunlukKiloTakibi.BackgroundColor = Color.DarkSeaGreen;
            dgvGunlukKiloTakibi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunlukKiloTakibi.Location = new Point(527, 100);
            dgvGunlukKiloTakibi.Name = "dgvGunlukKiloTakibi";
            dgvGunlukKiloTakibi.ReadOnly = true;
            dgvGunlukKiloTakibi.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvGunlukKiloTakibi.RowTemplate.Height = 25;
            dgvGunlukKiloTakibi.Size = new Size(500, 500);
            dgvGunlukKiloTakibi.TabIndex = 17;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(66, 293);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 22);
            dtpTarih.TabIndex = 18;
            // 
            // UserAddWeigthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1091, 718);
            Controls.Add(dtpTarih);
            Controls.Add(dgvGunlukKiloTakibi);
            Controls.Add(btnKaydet);
            Controls.Add(txtKilo);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAddWeigthForm";
            Text = "UserAddWeigthForm";
            Load += UserAddWeigthForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGunlukKiloTakibi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
        private TextBoxs.TextBox.DesignTextBox txtKilo;
        private Buttons.DesignButton btnKaydet;
        private DataGridView dgvGunlukKiloTakibi;
        private DateTimePicker dtpTarih;
    }
}