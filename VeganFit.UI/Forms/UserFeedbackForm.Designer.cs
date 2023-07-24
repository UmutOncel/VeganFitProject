namespace VeganFit.UI
{
    partial class UserFeedbackForm
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
            txtGorusOneri = new TextBoxs.TextBox.DesignTextBox();
            lblGorusVeOneri = new Label();
            btnGonder = new Buttons.DesignButton();
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
            lblKapat.TabIndex = 23;
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
            btnKapat.TabIndex = 22;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // txtGorusOneri
            // 
            txtGorusOneri.AutoSize = true;
            txtGorusOneri.BackColor = Color.LightSteelBlue;
            txtGorusOneri.BorderColor = Color.SteelBlue;
            txtGorusOneri.BorderFocusColor = Color.Red;
            txtGorusOneri.BorderRadius = 10;
            txtGorusOneri.BorderSize = 1;
            txtGorusOneri.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGorusOneri.Location = new Point(145, 344);
            txtGorusOneri.Multiline = false;
            txtGorusOneri.Name = "txtGorusOneri";
            txtGorusOneri.Padding = new Padding(7);
            txtGorusOneri.PasswordChar = false;
            txtGorusOneri.PlaceholderColor = Color.DarkGray;
            txtGorusOneri.PlaceholderText = "";
            txtGorusOneri.Size = new Size(800, 29);
            txtGorusOneri.TabIndex = 24;
            txtGorusOneri.UnderlinedStyle = false;
            txtGorusOneri.Enter += txtGorusOneri_Enter;
            txtGorusOneri.Leave += txtGorusOneri_Leave;
            // 
            // lblGorusVeOneri
            // 
            lblGorusVeOneri.AutoSize = true;
            lblGorusVeOneri.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGorusVeOneri.Location = new Point(476, 311);
            lblGorusVeOneri.Name = "lblGorusVeOneri";
            lblGorusVeOneri.Size = new Size(139, 18);
            lblGorusVeOneri.TabIndex = 25;
            lblGorusVeOneri.Text = "Görüş ve Öneri";
            // 
            // btnGonder
            // 
            btnGonder.BackColor = Color.Transparent;
            btnGonder.BackgroundColor = Color.Transparent;
            btnGonder.BorderColor = Color.DarkGreen;
            btnGonder.BorderRadius = 15;
            btnGonder.BorderSize = 2;
            btnGonder.FlatAppearance.BorderSize = 0;
            btnGonder.FlatStyle = FlatStyle.Flat;
            btnGonder.ForeColor = Color.Black;
            btnGonder.Location = new Point(490, 409);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(110, 40);
            btnGonder.TabIndex = 26;
            btnGonder.Text = "Gönder";
            btnGonder.TextColor = Color.Black;
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // UserFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1091, 718);
            Controls.Add(btnGonder);
            Controls.Add(lblGorusVeOneri);
            Controls.Add(txtGorusOneri);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserFeedbackForm";
            Text = "UserFeedbackForm";
            Load += UserFeedbackForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
        private TextBoxs.TextBox.DesignTextBox txtGorusOneri;
        private Label lblGorusVeOneri;
        private Buttons.DesignButton btnGonder;
    }
}