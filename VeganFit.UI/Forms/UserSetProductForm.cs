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
        private readonly DataDetailDto _detailDto;
        private readonly IDataRepo _dataRepo;
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
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string resimAdi = ofd.FileName;
                pbxResim.Image = Image.FromFile(resimAdi);
            }
        }
        private void btnOguneEkle_Click(object sender, EventArgs e)
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

            MessageBox.Show("Ürün Başarıyla Eklenmiştir");

            this.Close();


        }
        private void ForBegin()
        {
            Object[] array = new object[3] { Meal.Lunch, Meal.Breakfast, Meal.Dinner };
            cbxOgunSec.Items.AddRange(array);

            if(dataDetail != null )
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

        private void txtPorsiyon__TextChanged(object sender, EventArgs e)
        {
            //var serv = Convert.ToInt32(dataDetail.Serving);
            //var ser1 = Convert.ToInt32(txtPorsiyon.Text);
            //var ser2 = Convert.ToInt32(txtKalori.Text);
            //txtKalori.Text = ((ser2 / serv) * ser1).ToString();
        }
    }
}
