namespace VeganFit.UI
{
    partial class AdminFeedbackForm
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
            dgvGorusOneri = new DataGridView();
            btnSil = new Buttons.DesignButton();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            ((System.ComponentModel.ISupportInitialize)dgvGorusOneri).BeginInit();
            SuspendLayout();
            // 
            // dgvGorusOneri
            // 
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvGorusOneri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGorusOneri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGorusOneri.BackgroundColor = Color.LightSteelBlue;
            dgvGorusOneri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGorusOneri.Location = new Point(100, 84);
            dgvGorusOneri.Name = "dgvGorusOneri";
            dgvGorusOneri.RowTemplate.Height = 25;
            dgvGorusOneri.Size = new Size(894, 541);
            dgvGorusOneri.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Transparent;
            btnSil.BackgroundColor = Color.Transparent;
            btnSil.BorderColor = Color.DarkRed;
            btnSil.BorderRadius = 15;
            btnSil.BorderSize = 2;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(884, 631);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 40);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.TextColor = Color.Black;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lblKapat
            // 
            lblKapat.AutoSize = true;
            lblKapat.BackColor = Color.Transparent;
            lblKapat.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapat.ForeColor = Color.Red;
            lblKapat.Location = new Point(1048, 29);
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
            btnKapat.Location = new Point(1065, 0);
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
            // AdminFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1091, 718);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(btnSil);
            Controls.Add(dgvGorusOneri);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminFeedbackForm";
            Text = "AdminFeedbackForm";
            Load += AdminFeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGorusOneri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGorusOneri;
        private Buttons.DesignButton btnSil;
        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
    }
}