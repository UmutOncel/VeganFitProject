namespace VeganFit.UI
{
    partial class AdminAddProduct
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvUrunler = new DataGridView();
            txtAramaCubugu = new TextBoxs.TextBox.DesignTextBox();
            txtUrunAdi = new TextBoxs.TextBox.DesignTextBox();
            txtKalori = new TextBoxs.TextBox.DesignTextBox();
            txtPorsiyon = new TextBoxs.TextBox.DesignTextBox();
            btnResimEkle = new Buttons.DesignButton();
            btnUrunEkle = new Buttons.DesignButton();
            btnUrunGuncelle = new Buttons.DesignButton();
            btnUrunSil = new Buttons.DesignButton();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            lblUrunAra = new Label();
            pbxResim = new PictureBox();
            lblUrunAdi = new Label();
            lblKalori = new Label();
            lblPorisyon = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxResim).BeginInit();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUrunler.BackgroundColor = Color.LightSteelBlue;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(606, 82);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.Size = new Size(473, 576);
            dgvUrunler.TabIndex = 4;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
            // 
            // txtAramaCubugu
            // 
            txtAramaCubugu.BackColor = Color.LightBlue;
            txtAramaCubugu.BorderColor = Color.DarkBlue;
            txtAramaCubugu.BorderFocusColor = Color.Red;
            txtAramaCubugu.BorderRadius = 14;
            txtAramaCubugu.BorderSize = 1;
            txtAramaCubugu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAramaCubugu.ForeColor = Color.Black;
            txtAramaCubugu.Location = new Point(606, 47);
            txtAramaCubugu.Multiline = false;
            txtAramaCubugu.Name = "txtAramaCubugu";
            txtAramaCubugu.Padding = new Padding(7);
            txtAramaCubugu.PasswordChar = false;
            txtAramaCubugu.PlaceholderColor = Color.Black;
            txtAramaCubugu.PlaceholderText = "";
            txtAramaCubugu.Size = new Size(250, 29);
            txtAramaCubugu.TabIndex = 2;
            txtAramaCubugu.TabStop = false;
            txtAramaCubugu.UnderlinedStyle = false;
            txtAramaCubugu._TextChanged += txtAramaCubugu__TextChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.LightBlue;
            txtUrunAdi.BorderColor = Color.DarkBlue;
            txtUrunAdi.BorderFocusColor = Color.Red;
            txtUrunAdi.BorderRadius = 14;
            txtUrunAdi.BorderSize = 1;
            txtUrunAdi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUrunAdi.ForeColor = Color.Black;
            txtUrunAdi.Location = new Point(125, 283);
            txtUrunAdi.Multiline = false;
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Padding = new Padding(7);
            txtUrunAdi.PasswordChar = false;
            txtUrunAdi.PlaceholderColor = Color.Black;
            txtUrunAdi.PlaceholderText = "";
            txtUrunAdi.Size = new Size(250, 29);
            txtUrunAdi.TabIndex = 2;
            txtUrunAdi.TabStop = false;
            txtUrunAdi.UnderlinedStyle = false;
            txtUrunAdi.Enter += txtUrunAdi_Enter;
            txtUrunAdi.Leave += txtUrunAdi_Leave;
            // 
            // txtKalori
            // 
            txtKalori.BackColor = Color.LightBlue;
            txtKalori.BorderColor = Color.DarkBlue;
            txtKalori.BorderFocusColor = Color.Red;
            txtKalori.BorderRadius = 14;
            txtKalori.BorderSize = 1;
            txtKalori.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtKalori.ForeColor = Color.Black;
            txtKalori.Location = new Point(125, 333);
            txtKalori.Multiline = false;
            txtKalori.Name = "txtKalori";
            txtKalori.Padding = new Padding(7);
            txtKalori.PasswordChar = false;
            txtKalori.PlaceholderColor = Color.Black;
            txtKalori.PlaceholderText = "";
            txtKalori.Size = new Size(250, 29);
            txtKalori.TabIndex = 2;
            txtKalori.TabStop = false;
            txtKalori.UnderlinedStyle = false;
            txtKalori.Enter += txtKalori_Enter;
            txtKalori.Leave += txtKalori_Leave;
            // 
            // txtPorsiyon
            // 
            txtPorsiyon.BackColor = Color.LightBlue;
            txtPorsiyon.BorderColor = Color.DarkBlue;
            txtPorsiyon.BorderFocusColor = Color.Red;
            txtPorsiyon.BorderRadius = 14;
            txtPorsiyon.BorderSize = 1;
            txtPorsiyon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPorsiyon.ForeColor = Color.Black;
            txtPorsiyon.Location = new Point(125, 383);
            txtPorsiyon.Multiline = false;
            txtPorsiyon.Name = "txtPorsiyon";
            txtPorsiyon.Padding = new Padding(7);
            txtPorsiyon.PasswordChar = false;
            txtPorsiyon.PlaceholderColor = Color.Black;
            txtPorsiyon.PlaceholderText = "";
            txtPorsiyon.Size = new Size(250, 29);
            txtPorsiyon.TabIndex = 2;
            txtPorsiyon.TabStop = false;
            txtPorsiyon.UnderlinedStyle = false;
            txtPorsiyon.Enter += txtPorsiyon_Enter;
            txtPorsiyon.Leave += txtPorsiyon_Leave;
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.Transparent;
            btnResimEkle.BackgroundColor = Color.Transparent;
            btnResimEkle.BorderColor = Color.DarkGreen;
            btnResimEkle.BorderRadius = 15;
            btnResimEkle.BorderSize = 2;
            btnResimEkle.FlatAppearance.BorderSize = 0;
            btnResimEkle.FlatStyle = FlatStyle.Flat;
            btnResimEkle.ForeColor = Color.Black;
            btnResimEkle.Location = new Point(477, 418);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(110, 40);
            btnResimEkle.TabIndex = 5;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.TextColor = Color.Black;
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.Transparent;
            btnUrunEkle.BackgroundColor = Color.Transparent;
            btnUrunEkle.BorderColor = Color.DarkGreen;
            btnUrunEkle.BorderRadius = 15;
            btnUrunEkle.BorderSize = 2;
            btnUrunEkle.FlatAppearance.BorderSize = 0;
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.ForeColor = Color.Black;
            btnUrunEkle.Location = new Point(152, 666);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(110, 40);
            btnUrunEkle.TabIndex = 5;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.TextColor = Color.Black;
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.BackColor = Color.Transparent;
            btnUrunGuncelle.BackgroundColor = Color.Transparent;
            btnUrunGuncelle.BorderColor = Color.DarkBlue;
            btnUrunGuncelle.BorderRadius = 15;
            btnUrunGuncelle.BorderSize = 2;
            btnUrunGuncelle.FlatAppearance.BorderSize = 0;
            btnUrunGuncelle.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelle.ForeColor = Color.Black;
            btnUrunGuncelle.Location = new Point(286, 666);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(110, 40);
            btnUrunGuncelle.TabIndex = 5;
            btnUrunGuncelle.Text = "Ürün Güncelle";
            btnUrunGuncelle.TextColor = Color.Black;
            btnUrunGuncelle.UseVisualStyleBackColor = false;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.BackColor = Color.Transparent;
            btnUrunSil.BackgroundColor = Color.Transparent;
            btnUrunSil.BorderColor = Color.DarkRed;
            btnUrunSil.BorderRadius = 15;
            btnUrunSil.BorderSize = 2;
            btnUrunSil.FlatAppearance.BorderSize = 0;
            btnUrunSil.FlatStyle = FlatStyle.Flat;
            btnUrunSil.ForeColor = Color.Black;
            btnUrunSil.Location = new Point(969, 666);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(110, 40);
            btnUrunSil.TabIndex = 5;
            btnUrunSil.Text = "Ürünü Sil";
            btnUrunSil.TextColor = Color.Black;
            btnUrunSil.UseVisualStyleBackColor = false;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(1048, 30);
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
            btnKapat.Location = new Point(1065, 0);
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
            // lblUrunAra
            // 
            lblUrunAra.AutoSize = true;
            lblUrunAra.Location = new Point(606, 25);
            lblUrunAra.Name = "lblUrunAra";
            lblUrunAra.Size = new Size(66, 14);
            lblUrunAra.TabIndex = 9;
            lblUrunAra.Text = "Ürün Ara";
            // 
            // pbxResim
            // 
            pbxResim.BackColor = Color.Transparent;
            pbxResim.BorderStyle = BorderStyle.FixedSingle;
            pbxResim.Image = Properties.Resources.Logo;
            pbxResim.Location = new Point(381, 283);
            pbxResim.Name = "pbxResim";
            pbxResim.Size = new Size(202, 129);
            pbxResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxResim.TabIndex = 3;
            pbxResim.TabStop = false;
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.ForeColor = Color.Black;
            lblUrunAdi.Location = new Point(50, 288);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(69, 14);
            lblUrunAdi.TabIndex = 36;
            lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.ForeColor = Color.Black;
            lblKalori.Location = new Point(68, 341);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(51, 14);
            lblKalori.TabIndex = 37;
            lblKalori.Text = "Kalori:";
            // 
            // lblPorisyon
            // 
            lblPorisyon.AutoSize = true;
            lblPorisyon.ForeColor = Color.Black;
            lblPorisyon.Location = new Point(49, 389);
            lblPorisyon.Name = "lblPorisyon";
            lblPorisyon.Size = new Size(70, 14);
            lblPorisyon.TabIndex = 38;
            lblPorisyon.Text = "Porsiyon:";
            // 
            // AdminAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1091, 718);
            Controls.Add(lblUrunAdi);
            Controls.Add(lblKalori);
            Controls.Add(lblPorisyon);
            Controls.Add(lblUrunAra);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnResimEkle);
            Controls.Add(dgvUrunler);
            Controls.Add(pbxResim);
            Controls.Add(txtPorsiyon);
            Controls.Add(txtKalori);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtAramaCubugu);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddProduct";
            Text = "AdminAddProduct";
            Load += AdminAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvUrunler;
        private TextBoxs.TextBox.DesignTextBox txtAramaCubugu;
        private TextBoxs.TextBox.DesignTextBox txtUrunAdi;
        private TextBoxs.TextBox.DesignTextBox txtKalori;
        private TextBoxs.TextBox.DesignTextBox txtPorsiyon;
        private Buttons.DesignButton btnResimEkle;
        private Buttons.DesignButton btnUrunEkle;
        private Buttons.DesignButton btnUrunGuncelle;
        private Buttons.DesignButton btnUrunSil;
        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
        private Label lblUrunAra;
        private PictureBox pbxResim;
        private Label lblUrunAdi;
        private Label lblKalori;
        private Label lblPorisyon;
    }
}