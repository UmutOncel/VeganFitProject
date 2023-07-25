using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Services;
using VeganFit.Core.Enums;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class UserSetProductForm : Form
    {

        private readonly IDataService _dataService;
        //private readonly DataRepo _dataRepo;


        public UserSetProductForm(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            //_dataRepo = dataRepo;
        }

        private void UserAddNewProductForm_Load(object sender, EventArgs e)
        {

            txtUrunAdi.Text = "Ürün Adı";
            txtKalori.Text = "Kaç Kalori";
            txtPorsiyon.Text = "Porsiyon Giriniz";

            txtUrunAdi.ForeColor = Color.SlateGray;
            txtKalori.ForeColor = Color.SlateGray;
            txtPorsiyon.ForeColor = Color.SlateGray;

            ForBegin();

        }
        private void txtUrunAdi_Enter(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "Ürün Adı")
            {
                txtUrunAdi.Text = "";
                txtUrunAdi.ForeColor = Color.Black;
            }
        }

        private void txtUrunAdi_Leave(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "")
            {
                txtUrunAdi.Text = "Ürün Adı";
                txtUrunAdi.ForeColor = Color.SlateGray;
            }
        }

        private void txtKalori_Enter(object sender, EventArgs e)
        {

            if (txtKalori.Text == "Kaç Kalori")
            {
                txtKalori.Text = "";
                txtKalori.ForeColor = Color.Black;
            }
        }

        private void txtKalori_Leave(object sender, EventArgs e)
        {
            if (txtKalori.Text == "")
            {
                txtKalori.Text = "Kaç Kalori";
                txtKalori.ForeColor = Color.SlateGray;
            }
        }

        private void txtPorsiyon_Enter(object sender, EventArgs e)
        {
            if (txtPorsiyon.Text == "Porsiyon Giriniz")
            {
                txtPorsiyon.Text = "";
                txtPorsiyon.ForeColor = Color.Black;
            }
        }

        private void txtPorsiyon_Leave(object sender, EventArgs e)
        {
            if (txtPorsiyon.Text == "")
            {
                txtPorsiyon.Text = "Porsiyon Giriniz";
                txtPorsiyon.ForeColor = Color.SlateGray;
            }
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
                Calori = Convert.ToInt32(txtKalori.Text),
                ProductName = txtUrunAdi.Text,
                Serving = txtPorsiyon.Text,
                Picture = ImageToByteArray.imageToByteArray(pbxResim.Image),
                Meal = (Meal)cbxOgunSec.SelectedItem
            };
            _dataService.Create(dto);

            MessageBox.Show("Ürün Başarıyla Eklenmiştir");
        }
        private void ForBegin()
        {
            Object[] array = new object[3] { Meal.Lunch, Meal.Breakfast, Meal.Dinner };
            cbxOgunSec.Items.AddRange(array);

            DataDetailDto dataDetail = UserAddMealForm._data;
            
            txtUrunAdi.Text = dataDetail.ProductName;
            txtKalori.Text = dataDetail.Calori.ToString();
            txtPorsiyon.Text = dataDetail.Serving;
            pbxResim.Image = ImageToByteArray.byteArrayToImage(dataDetail.Picture);
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
