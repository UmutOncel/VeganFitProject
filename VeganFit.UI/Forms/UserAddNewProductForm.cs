﻿using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Services;
using VeganFit.Core.Enums;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class UserAddNewProductForm : Form
    {
        private readonly IDataService _dataService;
        bool product, calori, serving;

        public UserAddNewProductForm(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
        }

        private void UserAddNewProductForm_Load(object sender, EventArgs e)
        {
            ForBegin();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            lblKapat.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.Visible = false;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string pictureName = ofd.FileName;
                    pbxResim.Image = Image.FromFile(pictureName);
                }
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKalori.Text) > 0)
            {
                if (Convert.ToInt32(txtPorsiyon.Text) > 0)
                {
                    AddProduct();
                }
                else
                {
                    MessageBox.Show("Porsiyon değeri sıfıra eşit veya sıfırdan küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kalori değeri sıfıra eşit veya sıfırdan küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddProduct() 
        {
            DataDetailDto dto = new DataDetailDto()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToDouble(txtKalori.Text) / Convert.ToDouble(txtPorsiyon.Text) * Convert.ToDouble(txtPorsiyon.Text),
                Meal = (Meal)cbxOgunSec.SelectedItem,
                Datetime = DateTime.Now,
                UserEmail = ActiveUser.ActiveUserName
            };

            _dataService.Create(dto);

            MessageBox.Show("Ürün başarıyla eklenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Öğünü seçtirip listeye ekleyen ve porsiyon textbox'ında bilgi veren metottur.
        /// </summary>
        private void ForBegin()
        {
            Object[] array = new object[3] { Meal.Breakfast, Meal.Lunch, Meal.Dinner };
            cbxOgunSec.Items.AddRange(array);

            txtPorsiyon.Font = new Font(txtPorsiyon.Font.FontFamily, 8, FontStyle.Italic);
            txtPorsiyon.Text = "Gram Türünden Giriniz (Örnek = 100)";
        }

        private void txtUrunAdi__TextChanged(object sender, EventArgs e)
        {
            product = RegularExcep.RegularEx(@"^[a-zA-Z]*$", txtUrunAdi);
        }

        private void txtKalori__TextChanged(object sender, EventArgs e)
        {
            calori = RegularExcep.RegularEx(@"^[0-9]*$", txtKalori);
        }

        private void txtPorsiyon__TextChanged(object sender, EventArgs e)
        {
            serving = RegularExcep.RegularEx(@"^[0-9]*$", txtPorsiyon);
        }

        private void cbxOgunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOgunSec.Items.Count > 0)
            {
                if (calori && product && serving)
                {
                    btnUrunEkle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz değerleri kontrol ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKalori.Text = string.Empty;
                    txtPorsiyon.Text = string.Empty;
                    txtUrunAdi.Text = string.Empty;
                    cbxOgunSec.SelectedItem = null;
                }
            }
        }
    }
}
