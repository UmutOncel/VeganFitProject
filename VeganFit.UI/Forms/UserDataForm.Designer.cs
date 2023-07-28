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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dgvGunlukKiloTakibi = new DataGridView();
            dgvGunSonuKalori = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblKapat = new Label();
            btnKapat = new Buttons.DesignButton();
            chartCalori = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dgvGunlukKiloTakibi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGunSonuKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartWeight).BeginInit();
            SuspendLayout();
            // 
            // dgvGunlukKiloTakibi
            // 
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvGunlukKiloTakibi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGunlukKiloTakibi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGunlukKiloTakibi.BackgroundColor = Color.DarkSeaGreen;
            dgvGunlukKiloTakibi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunlukKiloTakibi.Location = new Point(22, 100);
            dgvGunlukKiloTakibi.Name = "dgvGunlukKiloTakibi";
            dgvGunlukKiloTakibi.ReadOnly = true;
            dgvGunlukKiloTakibi.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dgvGunlukKiloTakibi.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvGunlukKiloTakibi.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OliveDrab;
            dgvGunlukKiloTakibi.RowTemplate.Height = 25;
            dgvGunlukKiloTakibi.Size = new Size(500, 500);
            dgvGunlukKiloTakibi.TabIndex = 0;
            // 
            // dgvGunSonuKalori
            // 
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvGunSonuKalori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvGunSonuKalori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGunSonuKalori.BackgroundColor = Color.DarkSeaGreen;
            dgvGunSonuKalori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunSonuKalori.Location = new Point(569, 100);
            dgvGunSonuKalori.Name = "dgvGunSonuKalori";
            dgvGunSonuKalori.ReadOnly = true;
            dgvGunSonuKalori.RowTemplate.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            dgvGunSonuKalori.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvGunSonuKalori.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OliveDrab;
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
            // chartCalori
            // 
            chartCalori.BackColor = Color.DarkSeaGreen;
            chartArea1.Name = "ChartArea1";
            chartCalori.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCalori.Legends.Add(legend1);
            chartCalori.Location = new Point(569, 372);
            chartCalori.Name = "chartCalori";
            chartCalori.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kalori";
            series1.YValuesPerPoint = 4;
            chartCalori.Series.Add(series1);
            chartCalori.Size = new Size(500, 228);
            chartCalori.TabIndex = 13;
            chartCalori.Text = "chart1";
            // 
            // chartWeight
            // 
            chartWeight.BackColor = Color.DarkSeaGreen;
            chartArea2.Name = "ChartArea1";
            chartWeight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartWeight.Legends.Add(legend2);
            chartWeight.Location = new Point(22, 372);
            chartWeight.Name = "chartWeight";
            chartWeight.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Kilo";
            series2.YValuesPerPoint = 4;
            chartWeight.Series.Add(series2);
            chartWeight.Size = new Size(500, 228);
            chartWeight.TabIndex = 13;
            chartWeight.Text = "chart1";
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1091, 718);
            Controls.Add(chartWeight);
            Controls.Add(chartCalori);
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
            ((System.ComponentModel.ISupportInitialize)chartCalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartWeight).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalori;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeight;
    }
}