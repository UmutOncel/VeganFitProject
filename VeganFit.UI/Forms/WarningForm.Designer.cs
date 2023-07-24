namespace VeganFit.UI
{
    partial class WarningForm
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
            btnIlerle = new Buttons.DesignButton();
            pnlWarningForm = new Panel();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            pictureBox1 = new PictureBox();
            lblUyari = new Label();
            pnlWarningForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIlerle
            // 
            btnIlerle.BackColor = Color.Transparent;
            btnIlerle.BackgroundColor = Color.Transparent;
            btnIlerle.BorderColor = Color.DarkViolet;
            btnIlerle.BorderRadius = 10;
            btnIlerle.BorderSize = 2;
            btnIlerle.FlatAppearance.BorderSize = 0;
            btnIlerle.FlatStyle = FlatStyle.Popup;
            btnIlerle.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIlerle.ForeColor = Color.DarkViolet;
            btnIlerle.Location = new Point(110, 350);
            btnIlerle.Name = "btnIlerle";
            btnIlerle.Size = new Size(80, 30);
            btnIlerle.TabIndex = 1;
            btnIlerle.Text = "İlerle";
            btnIlerle.TextColor = Color.DarkViolet;
            btnIlerle.UseVisualStyleBackColor = false;
            btnIlerle.Click += btnIlerle_Click;
            // 
            // pnlWarningForm
            // 
            pnlWarningForm.BackColor = SystemColors.Control;
            pnlWarningForm.Controls.Add(lblKapat);
            pnlWarningForm.Controls.Add(btnKapat);
            pnlWarningForm.Controls.Add(pictureBox1);
            pnlWarningForm.Controls.Add(lblUyari);
            pnlWarningForm.Controls.Add(btnIlerle);
            pnlWarningForm.Dock = DockStyle.Fill;
            pnlWarningForm.Location = new Point(0, 0);
            pnlWarningForm.Name = "pnlWarningForm";
            pnlWarningForm.Size = new Size(300, 400);
            pnlWarningForm.TabIndex = 3;
            pnlWarningForm.MouseDown += pnlWarningForm_MouseDown;
            pnlWarningForm.MouseMove += pnlWarningForm_MouseMove;
            pnlWarningForm.MouseUp += pnlWarningForm_MouseUp;
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(255, 29);
            lblKapat.Name = "lblKapat";
            lblKapat.Size = new Size(44, 13);
            lblKapat.TabIndex = 10;
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
            btnKapat.Location = new Point(274, 1);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 9;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon24_scale_100;
            pictureBox1.Location = new Point(142, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblUyari
            // 
            lblUyari.BackColor = SystemColors.Control;
            lblUyari.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUyari.ForeColor = Color.DarkViolet;
            lblUyari.Location = new Point(-7, 159);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(320, 97);
            lblUyari.TabIndex = 2;
            lblUyari.Text = "                                   UYARI !\r\n\r\n  Uygulamamız orta yaşlı(45-64 yaş) kadınlar içindir.\r\n         \r\n           Yine de devam etmek istiyor musunuz?\r\n";
            // 
            // WarningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(pnlWarningForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarningForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarningForm";
            pnlWarningForm.ResumeLayout(false);
            pnlWarningForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Buttons.DesignButton btnIlerle;
        private Panel pnlWarningForm;
        private Label lblUyari;
        private PictureBox pictureBox1;
        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
    }
}