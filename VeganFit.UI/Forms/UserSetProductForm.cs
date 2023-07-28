using VeganFit.Bll.Abstract.IServices;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class UserSetProductForm : Form
    {

        private readonly IDataService _dataService;
        DataDetailDto dataDetail = UserAddMealForm._data;

        public UserSetProductForm(IDataService dataService)
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

        private void btnOguneEkle_Click(object sender, EventArgs e)
        {
            string strServing = txtIstenilenPorsiyon.Text;
            double serving;
            bool isDouble = double.TryParse(strServing, out serving);
            if (!isDouble)
            {
                MessageBox.Show("Porsiyonu sadece tam sayı veya ondalıklı sayı olarak girebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToDouble(txtIstenilenPorsiyon.Text) > 0)
                {
                    AddProduct();
                }
                else
                {
                    MessageBox.Show("Porsiyon sıfıra eşit veya sıfırdan küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            this.Close();
        }

        /// <summary>
        /// Database'e seçilen ürünü ekleyen metot.
        /// </summary>
        private void AddProduct() 
        {
            DataDetailDto dto = new DataDetailDto()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Math.Round(Convert.ToDouble(txtKalori.Text) / Convert.ToDouble(txtPorsiyon.Text) * Convert.ToDouble(txtIstenilenPorsiyon.Text), 2),
                Meal = (Meal)cbxOgunSec.SelectedItem,
                Datetime = DateTime.Now,
                UserEmail = ActiveUser.ActiveUserName
            };

            _dataService.Create(dto);

            MessageBox.Show("Ürün başarıyla eklenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Öğünden seçtiği ürünün bilgilerini textbox ve picturebox'a yükleyen ve combobox'tan ürün seçmeyi sağlayan metottur.
        /// </summary>
        private void ForBegin()
        {
            Object[] mealArray = new object[3] { Meal.Lunch, Meal.Breakfast, Meal.Dinner };
            cbxOgunSec.Items.AddRange(mealArray);

            if (dataDetail != null)
            {
                txtUrunAdi.Text = dataDetail.ProductName;
                txtKalori.Text = dataDetail.Calori.ToString();
                txtPorsiyon.Text = dataDetail.Serving;
                pbxResim.Image = ImageToByteArray.byteArrayToImage(dataDetail.Picture);
                txtIstenilenPorsiyon.Text = dataDetail.Serving;
            }
        }

        private void cbxOgunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOgunSec.Items.Count > 0)
            {
                btnOguneEkle.Enabled = true;
            }
        }
    }
}
