namespace VeganFit.UI
{
    partial class UserSetProductForm
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
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            pbxResim = new PictureBox();
            btnResimEkle = new Buttons.DesignButton();
            btnOguneEkle = new Buttons.DesignButton();
            txtPorsiyon = new TextBoxs.TextBox.DesignTextBox();
            txtKalori = new TextBoxs.TextBox.DesignTextBox();
            txtUrunAdi = new TextBoxs.TextBox.DesignTextBox();
            cbxOgunSec = new ComboBox();
            txtIstenilenPorsiyon = new TextBoxs.TextBox.DesignTextBox();
            lblPorsiyonGir = new Label();
            lblOgunSec = new Label();
            lblPorsiyon = new Label();
            lblKalori = new Label();
            lblUrunAdi = new Label();
            lblYeniUrunEkle = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxResim).BeginInit();
            SuspendLayout();
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(1323, 30);
            lblKapat.Name = "lblKapat";
            lblKapat.Size = new Size(44, 13);
            lblKapat.TabIndex = 29;
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
            btnKapat.Location = new Point(1340, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 28;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // pbxResim
            // 
            pbxResim.BorderStyle = BorderStyle.FixedSingle;
            pbxResim.Image = Properties.Resources.Logo;
            pbxResim.Location = new Point(747, 270);
            pbxResim.Name = "pbxResim";
            pbxResim.Size = new Size(248, 203);
            pbxResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbxResim.TabIndex = 27;
            pbxResim.TabStop = false;
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.Transparent;
            btnResimEkle.BackgroundColor = Color.Transparent;
            btnResimEkle.BorderColor = Color.DarkGreen;
            btnResimEkle.BorderRadius = 15;
            btnResimEkle.BorderSize = 2;
            btnResimEkle.Enabled = false;
            btnResimEkle.FlatAppearance.BorderSize = 0;
            btnResimEkle.FlatStyle = FlatStyle.Flat;
            btnResimEkle.ForeColor = Color.Black;
            btnResimEkle.Location = new Point(885, 479);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(110, 40);
            btnResimEkle.TabIndex = 25;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.TextColor = Color.Black;
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // btnOguneEkle
            // 
            btnOguneEkle.BackColor = Color.Transparent;
            btnOguneEkle.BackgroundColor = Color.Transparent;
            btnOguneEkle.BorderColor = Color.DarkGreen;
            btnOguneEkle.BorderRadius = 15;
            btnOguneEkle.BorderSize = 2;
            btnOguneEkle.Enabled = false;
            btnOguneEkle.FlatAppearance.BorderSize = 0;
            btnOguneEkle.FlatStyle = FlatStyle.Flat;
            btnOguneEkle.ForeColor = Color.Black;
            btnOguneEkle.Location = new Point(603, 479);
            btnOguneEkle.Name = "btnOguneEkle";
            btnOguneEkle.Size = new Size(110, 40);
            btnOguneEkle.TabIndex = 26;
            btnOguneEkle.Text = "Öğüne Ekle";
            btnOguneEkle.TextColor = Color.Black;
            btnOguneEkle.UseVisualStyleBackColor = false;
            btnOguneEkle.Click += btnOguneEkle_Click;
            // 
            // txtPorsiyon
            // 
            txtPorsiyon.BackColor = Color.MediumAquamarine;
            txtPorsiyon.BorderColor = Color.DarkGreen;
            txtPorsiyon.BorderFocusColor = Color.Red;
            txtPorsiyon.BorderRadius = 14;
            txtPorsiyon.BorderSize = 1;
            txtPorsiyon.Enabled = false;
            txtPorsiyon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPorsiyon.ForeColor = Color.Black;
            txtPorsiyon.Location = new Point(463, 358);
            txtPorsiyon.Multiline = false;
            txtPorsiyon.Name = "txtPorsiyon";
            txtPorsiyon.Padding = new Padding(7);
            txtPorsiyon.PasswordChar = false;
            txtPorsiyon.PlaceholderColor = Color.Black;
            txtPorsiyon.PlaceholderText = "";
            txtPorsiyon.Size = new Size(250, 29);
            txtPorsiyon.TabIndex = 22;
            txtPorsiyon.TabStop = false;
            txtPorsiyon.UnderlinedStyle = false;
            txtPorsiyon._TextChanged += txtPorsiyon__TextChanged;
            txtPorsiyon.Enter += txtPorsiyon_Enter;
            txtPorsiyon.Leave += txtPorsiyon_Leave;
            // 
            // txtKalori
            // 
            txtKalori.BackColor = Color.MediumAquamarine;
            txtKalori.BorderColor = Color.DarkGreen;
            txtKalori.BorderFocusColor = Color.Red;
            txtKalori.BorderRadius = 14;
            txtKalori.BorderSize = 1;
            txtKalori.Enabled = false;
            txtKalori.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtKalori.ForeColor = Color.Black;
            txtKalori.Location = new Point(463, 314);
            txtKalori.Multiline = false;
            txtKalori.Name = "txtKalori";
            txtKalori.Padding = new Padding(7);
            txtKalori.PasswordChar = false;
            txtKalori.PlaceholderColor = Color.Black;
            txtKalori.PlaceholderText = "";
            txtKalori.Size = new Size(250, 29);
            txtKalori.TabIndex = 23;
            txtKalori.TabStop = false;
            txtKalori.UnderlinedStyle = false;

            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.MediumAquamarine;
            txtUrunAdi.BorderColor = Color.DarkGreen;
            txtUrunAdi.BorderFocusColor = Color.Red;
            txtUrunAdi.BorderRadius = 14;
            txtUrunAdi.BorderSize = 1;
            txtUrunAdi.Enabled = false;
            txtUrunAdi.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUrunAdi.ForeColor = Color.Black;
            txtUrunAdi.Location = new Point(463, 270);
            txtUrunAdi.Multiline = false;
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Padding = new Padding(7);
            txtUrunAdi.PasswordChar = false;
            txtUrunAdi.PlaceholderColor = Color.Black;
            txtUrunAdi.PlaceholderText = "";
            txtUrunAdi.Size = new Size(250, 29);
            txtUrunAdi.TabIndex = 24;
            txtUrunAdi.TabStop = false;
            txtUrunAdi.UnderlinedStyle = false;


            // 
            // cbxOgunSec
            // 
            cbxOgunSec.FormattingEnabled = true;
            cbxOgunSec.Location = new Point(463, 450);
            cbxOgunSec.Name = "cbxOgunSec";
            cbxOgunSec.Size = new Size(250, 22);
            cbxOgunSec.TabIndex = 30;
            cbxOgunSec.SelectedIndexChanged += cbxOgunSec_SelectedIndexChanged;
            // 
            // txtIstenilenPorsiyon
            // 
            txtIstenilenPorsiyon.BackColor = Color.LightGray;
            txtIstenilenPorsiyon.BorderColor = Color.SeaGreen;
            txtIstenilenPorsiyon.BorderFocusColor = Color.Red;
            txtIstenilenPorsiyon.BorderRadius = 14;
            txtIstenilenPorsiyon.BorderSize = 1;
            txtIstenilenPorsiyon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtIstenilenPorsiyon.ForeColor = Color.Black;
            txtIstenilenPorsiyon.Location = new Point(463, 402);
            txtIstenilenPorsiyon.Multiline = false;
            txtIstenilenPorsiyon.Name = "txtIstenilenPorsiyon";
            txtIstenilenPorsiyon.Padding = new Padding(7);
            txtIstenilenPorsiyon.PasswordChar = false;
            txtIstenilenPorsiyon.PlaceholderColor = Color.Black;
            txtIstenilenPorsiyon.PlaceholderText = "";
            txtIstenilenPorsiyon.Size = new Size(250, 29);
            txtIstenilenPorsiyon.TabIndex = 22;
            txtIstenilenPorsiyon.TabStop = false;
            txtIstenilenPorsiyon.UnderlinedStyle = false;
            txtIstenilenPorsiyon._TextChanged += txtPorsiyon__TextChanged;
            txtIstenilenPorsiyon.Enter += txtPorsiyon_Enter;
            txtIstenilenPorsiyon.Leave += txtPorsiyon_Leave;
            // 
            // lblPorsiyonGir
            // 
            lblPorsiyonGir.AutoSize = true;
            lblPorsiyonGir.ForeColor = Color.Black;
            lblPorsiyonGir.Location = new Point(340, 411);
            lblPorsiyonGir.Name = "lblPorsiyonGir";
            lblPorsiyonGir.Size = new Size(117, 14);
            lblPorsiyonGir.TabIndex = 32;
            lblPorsiyonGir.Text = "Porsiyon Ayarla:";
            // 
            // lblOgunSec
            // 
            lblOgunSec.AutoSize = true;
            lblOgunSec.ForeColor = Color.Black;
            lblOgunSec.Location = new Point(382, 452);
            lblOgunSec.Name = "lblOgunSec";
            lblOgunSec.Size = new Size(75, 14);
            lblOgunSec.TabIndex = 32;
            lblOgunSec.Text = "Öğün Seç:";
            // 
            // lblPorsiyon
            // 
            lblPorsiyon.AutoSize = true;
            lblPorsiyon.ForeColor = Color.Black;
            lblPorsiyon.Location = new Point(387, 367);
            lblPorsiyon.Name = "lblPorsiyon";
            lblPorsiyon.Size = new Size(70, 14);
            lblPorsiyon.TabIndex = 32;
            lblPorsiyon.Text = "Porsiyon:";
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.ForeColor = Color.Black;
            lblKalori.Location = new Point(406, 323);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(51, 14);
            lblKalori.TabIndex = 32;
            lblKalori.Text = "Kalori:";
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.ForeColor = Color.Black;
            lblUrunAdi.Location = new Point(388, 279);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(69, 14);
            lblUrunAdi.TabIndex = 32;
            lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblYeniUrunEkle
            // 
            lblYeniUrunEkle.AutoSize = true;
            lblYeniUrunEkle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYeniUrunEkle.Location = new Point(635, 180);
            lblYeniUrunEkle.Name = "lblYeniUrunEkle";
            lblYeniUrunEkle.Size = new Size(155, 18);
            lblYeniUrunEkle.TabIndex = 37;
            lblYeniUrunEkle.Text = "Öğüne Ürün Ekle";
            // 
            // UserSetProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1366, 768);
            Controls.Add(lblYeniUrunEkle);
            Controls.Add(lblOgunSec);
            Controls.Add(lblUrunAdi);
            Controls.Add(lblKalori);
            Controls.Add(lblPorsiyon);
            Controls.Add(lblPorsiyonGir);
            Controls.Add(cbxOgunSec);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(pbxResim);
            Controls.Add(btnResimEkle);
            Controls.Add(btnOguneEkle);
            Controls.Add(txtIstenilenPorsiyon);
            Controls.Add(txtPorsiyon);
            Controls.Add(txtKalori);
            Controls.Add(txtUrunAdi);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSetProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserSetProductForm";
            Load += UserAddNewProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbxResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
        private PictureBox pbxResim;
        private Buttons.DesignButton btnResimEkle;
        private Buttons.DesignButton btnOguneEkle;
        private TextBoxs.TextBox.DesignTextBox txtPorsiyon;
        private TextBoxs.TextBox.DesignTextBox txtKalori;
        private TextBoxs.TextBox.DesignTextBox txtUrunAdi;
        private ComboBox cbxOgunSec;
        private TextBoxs.TextBox.DesignTextBox txtIstenilenPorsiyon;
        private Label lblPorsiyonGir;
        private Label lblOgunSec;
        private Label lblPorsiyon;
        private Label lblKalori;
        private Label lblUrunAdi;
        private Label lblYeniUrunEkle;
    }
}