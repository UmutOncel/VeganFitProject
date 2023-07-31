using System.Text.RegularExpressions;
using TextBoxs.TextBox;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Services;
using VeganFit.Core.Enums;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class UserAddNewProductForm : Form
    {
        UserAddMealForm on = (UserAddMealForm)Application.OpenForms["UserAddMealForm"];
        private readonly IDataService _dataService;
        bool isLetter, isDoubleCalori, isDoubleServing;

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
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pictureName = ofd.FileName;
                pbxResim.Image = Image.FromFile(pictureName);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtKalori.Text) < 0)
            {
                MessageBox.Show("Kalori değeri sıfıra eşit veya sıfırdan küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToDouble(txtPorsiyon.Text) < 0)
                {
                    MessageBox.Show("Porsiyon değeri sıfıra eşit veya sıfırdan küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AddProduct();
                }

            }
            on.RefreshMealLists();
            this.Close();
        }

        /// <summary>
        /// Ürün ekleyen metot.
        /// </summary>
        private void AddProduct()
        {
            DataDetailDto dto = new DataDetailDto()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Math.Round(Convert.ToDouble(txtKalori.Text) / Convert.ToDouble(txtPorsiyon.Text) * Convert.ToDouble(txtPorsiyon.Text), 2),
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
            Object[] array = new object[3] { Meal.Sabah, Meal.Öğle, Meal.Akşam };
            cbxOgunSec.Items.AddRange(array);
        }

        private void txtUrunAdi__TextChanged(object sender, EventArgs e)
        {
            isLetter = RegularEx(@"^[a-zA-ZüıöğşçĞÖÜİŞÇ ]*$", txtUrunAdi);
            if (!isLetter)
            {
                MessageBox.Show("Ürün adı yazarken sadece harf kullanınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            EnableButton();
        }

        /// <summary>
        /// Kayıt esnasında şartları eşleştirip kontrolünü sağlayan metottur.
        /// </summary>
        /// <param name="rgx"></param>
        /// <param name="txtb"></param>
        /// <returns></returns>
        public bool RegularEx(string rgx, DesignTextBox txtb)
        {
            bool control = false;
            Regex regex = new Regex(rgx);
            Match match = regex.Match(txtb.Text);
            if (match.Success)
            {
                control = true;
            }
            else
            {
                control = false;
            }
            return control;
        }

        /// <summary>
        /// Parametre olarak girilen string değerin double tipine dönüştürülüp dönüştürülemediğini kontrol eden ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private bool IsDouble(string str, double data)
        {
            return double.TryParse(str, out data);
        }

        private void txtKalori__TextChanged(object sender, EventArgs e)
        {
            string strCalori = txtKalori.Text;
            double calori = 0;
            isDoubleCalori = IsDouble(strCalori, calori);
            bool isDot = strCalori.Contains('.');
            if (!isDoubleCalori || isDot)
            {
                MessageBox.Show("Kalori değeri sadece tam sayı veya ondalıklı sayı olabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            EnableButton();
        }

        private void txtPorsiyon__TextChanged(object sender, EventArgs e)
        {
            string strServing = txtPorsiyon.Text;
            double serving = 0;
            isDoubleServing = IsDouble(strServing, serving);
            bool isDot = strServing.Contains('.');
            if (!isDoubleServing || isDot)
            {
                MessageBox.Show("Porsiyon değeri sadece tam sayı veya ondalıklı sayı olabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            EnableButton();
        }

        private void cbxOgunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        /// <summary>
        /// Ürün ekle butonun aktifliğini kontrol eden metot.
        /// </summary>
        private void EnableButton()
        {
            if (cbxOgunSec.Text.Length > 0 && isLetter && isDoubleCalori && isDoubleServing)
            {
                btnUrunEkle.Enabled = true;
            }
            else
            {
                btnUrunEkle.Enabled = false;
            }
        }
    }
}
