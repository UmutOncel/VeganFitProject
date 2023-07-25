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
            lblOgun = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxResim).BeginInit();
            SuspendLayout();
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
            btnKapat.Location = new Point(1065, 0);
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
            pbxResim.Location = new Point(555, 254);
            pbxResim.Name = "pbxResim";
            pbxResim.Size = new Size(202, 129);
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
            btnResimEkle.Location = new Point(647, 389);
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
            btnOguneEkle.FlatAppearance.BorderSize = 0;
            btnOguneEkle.FlatStyle = FlatStyle.Flat;
            btnOguneEkle.ForeColor = Color.Black;
            btnOguneEkle.Location = new Point(469, 456);
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
            txtPorsiyon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPorsiyon.ForeColor = Color.Black;
            txtPorsiyon.Location = new Point(270, 354);
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
            txtKalori.Location = new Point(270, 304);
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
            txtKalori.Enter += txtKalori_Enter;
            txtKalori.Leave += txtKalori_Leave;
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
            txtUrunAdi.Location = new Point(270, 254);
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
            txtUrunAdi.Enter += txtUrunAdi_Enter;
            txtUrunAdi.Leave += txtUrunAdi_Leave;
            // 
            // cbxOgunSec
            // 
            cbxOgunSec.FormattingEnabled = true;
            cbxOgunSec.Location = new Point(12, 30);
            cbxOgunSec.Name = "cbxOgunSec";
            cbxOgunSec.Size = new Size(169, 22);
            cbxOgunSec.TabIndex = 30;
            cbxOgunSec.SelectedIndexChanged += cbxOgunSec_SelectedIndexChanged;
            // 
            // lblOgun
            // 
            lblOgun.AutoSize = true;
            lblOgun.Location = new Point(12, 5);
            lblOgun.Name = "lblOgun";
            lblOgun.Size = new Size(98, 14);
            lblOgun.TabIndex = 31;
            lblOgun.Text = "Öğün Seçiniz:";
            // 
            // UserSetProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1091, 718);
            Controls.Add(lblOgun);
            Controls.Add(cbxOgunSec);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(pbxResim);
            Controls.Add(btnResimEkle);
            Controls.Add(btnOguneEkle);
            Controls.Add(txtPorsiyon);
            Controls.Add(txtKalori);
            Controls.Add(txtUrunAdi);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSetProductForm";
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
        private Label lblOgun;
    }
}