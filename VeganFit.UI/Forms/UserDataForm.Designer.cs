namespace VeganFit.UI
{
    partial class UserDataForm
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
            dgvGunlukKiloTakibi = new DataGridView();
            dgvGunSonuKalori = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            ((System.ComponentModel.ISupportInitialize)dgvGunlukKiloTakibi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).BeginInit();
            SuspendLayout();
            // 
            // dgvGunlukKiloTakibi
            // 
            dataGridViewCellStyle1.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvGunlukKiloTakibi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGunlukKiloTakibi.BackgroundColor = Color.DarkSeaGreen;
            dgvGunlukKiloTakibi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunlukKiloTakibi.Location = new Point(22, 100);
            dgvGunlukKiloTakibi.Name = "dgvGunlukKiloTakibi";
            dgvGunlukKiloTakibi.RowTemplate.Height = 25;
            dgvGunlukKiloTakibi.Size = new Size(500, 500);
            dgvGunlukKiloTakibi.TabIndex = 0;
            // 
            // dgvGunSonuKalori
            // 
            dataGridViewCellStyle2.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvGunSonuKalori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvGunSonuKalori.BackgroundColor = Color.DarkSeaGreen;
            dgvGunSonuKalori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunSonuKalori.Location = new Point(569, 100);
            dgvGunSonuKalori.Name = "dgvGunSonuKalori";
            dgvGunSonuKalori.RowTemplate.Height = 25;
            dgvGunSonuKalori.Size = new Size(500, 500);
            dgvGunSonuKalori.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(167, 69);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 1;
            label1.Text = "Günlük Kilo Takip Çizelgesi";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(740, 69);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 1;
            label2.Text = "Gün Sonu Kalori Çizelgesi";
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
            btnKapat.Location = new Point(1065, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(25, 25);
            btnKapat.TabIndex = 11;
            btnKapat.Text = "x";
            btnKapat.TextAlign = ContentAlignment.MiddleRight;
            btnKapat.TextColor = Color.White;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            btnKapat.MouseEnter += btnKapat_MouseEnter;
            btnKapat.MouseLeave += btnKapat_MouseLeave;
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1091, 718);
            Controls.Add(lblKapat);
            Controls.Add(btnKapat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGunSonuKalori);
            Controls.Add(dgvGunlukKiloTakibi);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDataForm";
            Text = "UserDataForm";
            Load += UserDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGunlukKiloTakibi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGunlukKiloTakibi;
        private DataGridView dgvGunSonuKalori;
        private Label label1;
        private Label label2;
        private Label lblKapat;
        private Buttons.DesignButton btnKapat;
    }
}