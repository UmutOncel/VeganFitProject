namespace VeganFit.UI
{
    partial class UserAddMealForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvSabah = new DataGridView();
            dgvOgle = new DataGridView();
            dgvAksam = new DataGridView();
            btnUrunuSilSabah = new Buttons.DesignButton();
            btnUrunuSilOgle = new Buttons.DesignButton();
            btnUrunuSilAksam = new Buttons.DesignButton();
            lblSabah = new Label();
            lblOgle = new Label();
            lblAksam = new Label();
            dgvUrunlerListesi = new DataGridView();
            btnUrunEkle = new Buttons.DesignButton();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            txtAramaKutusu = new TextBoxs.TextBox.DesignTextBox();
            btnListeyiYenile = new Buttons.DesignButton();
            lblListeyiYenile = new Label();
            lblUrunAra = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSabah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAksam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunlerListesi).BeginInit();
            SuspendLayout();
            // 
            // dgvSabah
            // 
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvSabah.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSabah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSabah.BackgroundColor = Color.DarkSeaGreen;
            dgvSabah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSabah.Location = new Point(12, 30);
            dgvSabah.Name = "dgvSabah";
            dataGridViewCellStyle2.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dgvSabah.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvSabah.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dgvSabah.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSabah.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvSabah.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OliveDrab;
            dgvSabah.RowTemplate.Height = 25;
            dgvSabah.RowTemplate.ReadOnly = true;
            dgvSabah.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvSabah.Size = new Size(475, 154);
            dgvSabah.TabIndex = 1;
            // 
            // dgvOgle
            // 
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvOgle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvOgle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgle.BackgroundColor = Color.DarkSeaGreen;
            dgvOgle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgle.Location = new Point(12, 269);
            dgvOgle.Name = "dgvOgle";
            dgvOgle.ReadOnly = true;
            dgvOgle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvOgle.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dgvOgle.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvOgle.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OliveDrab;
            dgvOgle.RowTemplate.Height = 25;
            dgvOgle.RowTemplate.ReadOnly = true;
            dgvOgle.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvOgle.Size = new Size(475, 154);
            dgvOgle.TabIndex = 1;
            // 
            // dgvAksam
            // 
            dgvAksam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvAksam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAksam.BackgroundColor = Color.DarkSeaGreen;
            dgvAksam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAksam.Location = new Point(12, 508);
            dgvAksam.Name = "dgvAksam";
            dgvAksam.ReadOnly = true;
            dgvAksam.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvAksam.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dgvAksam.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvAksam.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OliveDrab;
            dgvAksam.RowTemplate.Height = 25;
            dgvAksam.RowTemplate.ReadOnly = true;
            dgvAksam.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvAksam.Size = new Size(475, 154);
            dgvAksam.TabIndex = 1;
            // 
            // btnUrunuSilSabah
            // 
            btnUrunuSilSabah.BackColor = Color.Transparent;
            btnUrunuSilSabah.BackgroundColor = Color.Transparent;
            btnUrunuSilSabah.BorderColor = Color.DarkRed;
            btnUrunuSilSabah.BorderRadius = 10;
            btnUrunuSilSabah.BorderSize = 2;
            btnUrunuSilSabah.FlatAppearance.BorderSize = 0;
            btnUrunuSilSabah.FlatStyle = FlatStyle.Flat;
            btnUrunuSilSabah.ForeColor = Color.Black;
            btnUrunuSilSabah.Location = new Point(407, 190);
            btnUrunuSilSabah.Name = "btnUrunuSilSabah";
            btnUrunuSilSabah.Size = new Size(80, 30);
            btnUrunuSilSabah.TabIndex = 1;
            btnUrunuSilSabah.Text = "Ürünü Sil";
            btnUrunuSilSabah.TextColor = Color.Black;
            btnUrunuSilSabah.UseVisualStyleBackColor = false;
            btnUrunuSilSabah.Click += btnUrunuSilSabah_Click;
            // 
            // btnUrunuSilOgle
            // 
            btnUrunuSilOgle.BackColor = Color.Transparent;
            btnUrunuSilOgle.BackgroundColor = Color.Transparent;
            btnUrunuSilOgle.BorderColor = Color.DarkRed;
            btnUrunuSilOgle.BorderRadius = 10;
            btnUrunuSilOgle.BorderSize = 2;
            btnUrunuSilOgle.FlatAppearance.BorderSize = 0;
            btnUrunuSilOgle.FlatStyle = FlatStyle.Flat;
            btnUrunuSilOgle.ForeColor = Color.Black;
            btnUrunuSilOgle.Location = new Point(407, 429);
            btnUrunuSilOgle.Name = "btnUrunuSilOgle";
            btnUrunuSilOgle.Size = new Size(80, 30);
            btnUrunuSilOgle.TabIndex = 2;
            btnUrunuSilOgle.Text = "Ürünü Sil";
            btnUrunuSilOgle.TextColor = Color.Black;
            btnUrunuSilOgle.UseVisualStyleBackColor = false;
            btnUrunuSilOgle.Click += btnUrunuSilOgle_Click;
            // 
            // btnUrunuSilAksam
            // 
            btnUrunuSilAksam.BackColor = Color.Transparent;
            btnUrunuSilAksam.BackgroundColor = Color.Transparent;
            btnUrunuSilAksam.BorderColor = Color.DarkRed;
            btnUrunuSilAksam.BorderRadius = 10;
            btnUrunuSilAksam.BorderSize = 2;
            btnUrunuSilAksam.FlatAppearance.BorderSize = 0;
            btnUrunuSilAksam.FlatStyle = FlatStyle.Flat;
            btnUrunuSilAksam.ForeColor = Color.Black;
            btnUrunuSilAksam.Location = new Point(407, 668);
            btnUrunuSilAksam.Name = "btnUrunuSilAksam";
            btnUrunuSilAksam.Size = new Size(80, 30);
            btnUrunuSilAksam.TabIndex = 3;
            btnUrunuSilAksam.Text = "Ürünü Sil";
            btnUrunuSilAksam.TextColor = Color.Black;
            btnUrunuSilAksam.UseVisualStyleBackColor = false;
            btnUrunuSilAksam.Click += btnUrunuSilAksam_Click;
            // 
            // lblSabah
            // 
            lblSabah.AutoSize = true;
            lblSabah.Location = new Point(12, 13);
            lblSabah.Name = "lblSabah";
            lblSabah.Size = new Size(53, 14);
            lblSabah.TabIndex = 7;
            lblSabah.Text = "SABAH";
            // 
            // lblOgle
            // 
            lblOgle.AutoSize = true;
            lblOgle.Location = new Point(12, 252);
            lblOgle.Name = "lblOgle";
            lblOgle.Size = new Size(44, 14);
            lblOgle.TabIndex = 7;
            lblOgle.Text = "ÖĞLE";
            // 
            // lblAksam
            // 
            lblAksam.AutoSize = true;
            lblAksam.Location = new Point(12, 491);
            lblAksam.Name = "lblAksam";
            lblAksam.Size = new Size(54, 14);
            lblAksam.TabIndex = 7;
            lblAksam.Text = "AKŞAM";
            // 
            // dgvUrunlerListesi
            // 
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvUrunlerListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUrunlerListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUrunlerListesi.BackgroundColor = Color.DarkSeaGreen;
            dgvUrunlerListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunlerListesi.Location = new Point(591, 69);
            dgvUrunlerListesi.Name = "dgvUrunlerListesi";
            dgvUrunlerListesi.ReadOnly = true;
            dgvUrunlerListesi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUrunlerListesi.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dgvUrunlerListesi.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvUrunlerListesi.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvUrunlerListesi.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OliveDrab;
            dgvUrunlerListesi.RowTemplate.Height = 25;
            dgvUrunlerListesi.RowTemplate.ReadOnly = true;
            dgvUrunlerListesi.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvUrunlerListesi.Size = new Size(488, 593);
            dgvUrunlerListesi.TabIndex = 8;
            dgvUrunlerListesi.CellClick += dgvUrunlerListesi_CellClick;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.Transparent;
            btnUrunEkle.BackgroundColor = Color.Transparent;
            btnUrunEkle.BorderColor = Color.DarkGreen;
            btnUrunEkle.BorderRadius = 10;
            btnUrunEkle.BorderSize = 2;
            btnUrunEkle.FlatAppearance.BorderSize = 0;
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.ForeColor = Color.Black;
            btnUrunEkle.Location = new Point(776, 668);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(120, 30);
            btnUrunEkle.TabIndex = 6;
            btnUrunEkle.Text = "Yeni Ürün Ekle";
            btnUrunEkle.TextColor = Color.Black;
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(1047, 30);
            lblKapat.Name = "lblKapat";
            lblKapat.Size = new Size(44, 13);
            lblKapat.TabIndex = 12;
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
            btnKapat.Location = new Point(1064, 0);
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
            // txtAramaKutusu
            // 
            txtAramaKutusu.BackColor = Color.DarkSeaGreen;
            txtAramaKutusu.BorderColor = Color.DarkGreen;
            txtAramaKutusu.BorderFocusColor = Color.Red;
            txtAramaKutusu.BorderRadius = 14;
            txtAramaKutusu.BorderSize = 1;
            txtAramaKutusu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAramaKutusu.ForeColor = Color.Black;
            txtAramaKutusu.Location = new Point(591, 30);
            txtAramaKutusu.Multiline = false;
            txtAramaKutusu.Name = "txtAramaKutusu";
            txtAramaKutusu.Padding = new Padding(7);
            txtAramaKutusu.PasswordChar = false;
            txtAramaKutusu.PlaceholderColor = Color.Black;
            txtAramaKutusu.PlaceholderText = "";
            txtAramaKutusu.Size = new Size(250, 29);
            txtAramaKutusu.TabIndex = 4;
            txtAramaKutusu.TabStop = false;
            txtAramaKutusu.UnderlinedStyle = false;
            txtAramaKutusu._TextChanged += txtAramaKutusu__TextChanged;
            // 
            // btnListeyiYenile
            // 
            btnListeyiYenile.BackColor = Color.Transparent;
            btnListeyiYenile.BackgroundColor = Color.Transparent;
            btnListeyiYenile.BackgroundImageLayout = ImageLayout.None;
            btnListeyiYenile.BorderColor = Color.DarkBlue;
            btnListeyiYenile.BorderRadius = 10;
            btnListeyiYenile.BorderSize = 2;
            btnListeyiYenile.FlatAppearance.BorderSize = 0;
            btnListeyiYenile.FlatStyle = FlatStyle.Flat;
            btnListeyiYenile.ForeColor = Color.Black;
            btnListeyiYenile.Image = Properties.Resources.Yenile_Butonu;
            btnListeyiYenile.ImageAlign = ContentAlignment.BottomCenter;
            btnListeyiYenile.Location = new Point(591, 668);
            btnListeyiYenile.Name = "btnListeyiYenile";
            btnListeyiYenile.Size = new Size(34, 34);
            btnListeyiYenile.TabIndex = 5;
            btnListeyiYenile.TextAlign = ContentAlignment.BottomLeft;
            btnListeyiYenile.TextColor = Color.Black;
            btnListeyiYenile.UseVisualStyleBackColor = false;
            btnListeyiYenile.Click += btnListeyiYenile_Click;
            btnListeyiYenile.MouseEnter += btnListeyiYenile_MouseEnter;
            btnListeyiYenile.MouseLeave += btnListeyiYenile_MouseLeave;
            // 
            // lblListeyiYenile
            // 
            lblListeyiYenile.AutoSize = true;
            lblListeyiYenile.Location = new Point(631, 664);
            lblListeyiYenile.Name = "lblListeyiYenile";
            lblListeyiYenile.Size = new Size(97, 14);
            lblListeyiYenile.TabIndex = 17;
            lblListeyiYenile.Text = "Listeyi Yenile";
            lblListeyiYenile.Visible = false;
            // 
            // lblUrunAra
            // 
            lblUrunAra.AutoSize = true;
            lblUrunAra.Location = new Point(591, 13);
            lblUrunAra.Name = "lblUrunAra";
            lblUrunAra.Size = new Size(66, 14);
            lblUrunAra.TabIndex = 18;
            lblUrunAra.Text = "Ürün Ara";
            // 
            // UserAddMealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1091, 718);
            Controls.Add(lblUrunAra);
            Controls.Add(lblListeyiYenile);
            Controls.Add(txtAramaKutusu);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(btnListeyiYenile);
            Controls.Add(btnUrunEkle);
            Controls.Add(dgvUrunlerListesi);
            Controls.Add(lblAksam);
            Controls.Add(lblOgle);
            Controls.Add(lblSabah);
            Controls.Add(btnUrunuSilAksam);
            Controls.Add(btnUrunuSilOgle);
            Controls.Add(btnUrunuSilSabah);
            Controls.Add(dgvAksam);
            Controls.Add(dgvOgle);
            Controls.Add(dgvSabah);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAddMealForm";
            Text = "UserAddMealForm";
            Load += UserAddMealForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSabah).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAksam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunlerListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSabah;
        private DataGridView dgvOgle;
        private DataGridView dgvAksam;
        private Buttons.DesignButton btnUrunuSilSabah;
        private Buttons.DesignButton btnUrunuSilOgle;
        private Buttons.DesignButton btnUrunuSilAksam;
        private Label lblSabah;
        private Label lblOgle;
        private Label lblAksam;
        private DataGridView dgvUrunlerListesi;
        private Buttons.DesignButton btnUrunEkle;
        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
        private TextBoxs.TextBox.DesignTextBox txtAramaKutusu;
        private Buttons.DesignButton btnListeyiYenile;
        private Label lblListeyiYenile;
        private Label lblUrunAra;
    }
}