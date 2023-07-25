using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Services;
using VeganFit.Core.Enums;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class UserAddNewProductForm : Form
    {

        private readonly IDataService _dataService;

        public UserAddNewProductForm(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
        }

        private void UserAddNewProductForm_Load(object sender, EventArgs e)
        {
            ForBegin();
            //txtUrunAdi.Text = "Ürün Adı";
            //txtKalori.Text = "Kaç Kalori";
            //txtPorsiyon.Text = "Porsiyon Giriniz";

            //txtUrunAdi.ForeColor = Color.SlateGray;
            //txtKalori.ForeColor = Color.SlateGray;
            //txtPorsiyon.ForeColor = Color.SlateGray;
        }
        private void txtUrunAdi_Enter(object sender, EventArgs e)
        {
            //if (txtUrunAdi.Text == "Ürün Adı")
            //{
            //    txtUrunAdi.Text = "";
            //    txtUrunAdi.ForeColor = Color.Black;
            //}
        }

        private void txtUrunAdi_Leave(object sender, EventArgs e)
        {
            //if (txtUrunAdi.Text == "")
            //{
            //    txtUrunAdi.Text = "Ürün Adı";
            //    txtUrunAdi.ForeColor = Color.SlateGray;
            //}
        }

        private void txtKalori_Enter(object sender, EventArgs e)
        {

            //if (txtKalori.Text == "Kaç Kalori")
            //{
            //    txtKalori.Text = "";
            //    txtKalori.ForeColor = Color.Black;
            //}
        }

        private void txtKalori_Leave(object sender, EventArgs e)
        {
            //if (txtKalori.Text == "")
            //{
            //    txtKalori.Text = "Kaç Kalori";
            //    txtKalori.ForeColor = Color.SlateGray;
            //}
        }

        private void txtPorsiyon_Enter(object sender, EventArgs e)
        {
            //if (txtPorsiyon.Text == "Porsiyon Giriniz")
            //{
            //    txtPorsiyon.Text = "";
            //    txtPorsiyon.ForeColor = Color.Black;
            //}
        }

        private void txtPorsiyon_Leave(object sender, EventArgs e)
        {
            //if (txtPorsiyon.Text == "")
            //{
            //    txtPorsiyon.Text = "Porsiyon Giriniz";
            //    txtPorsiyon.ForeColor = Color.SlateGray;
            //}
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
                    string resimAdi = ofd.FileName;
                    pbxResim.Image = Image.FromFile(resimAdi);
                }
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
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

            MessageBox.Show("Ürün Başarıyla Eklenmiştir");
        }
        private void ForBegin()
        {
            Object[] array = new object[3] { Meal.Lunch, Meal.Breakfast, Meal.Dinner };
            cbxOgunSec.Items.AddRange(array);

            
        }


    }
}
