using AutoMapper;
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
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Entities;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.Models.VMs.DataVms;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Models.VMs.ProductVms;
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
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToDouble(txtKalori.Text)/Convert.ToDouble(txtPorsiyon.Text)*Convert.ToDouble(textBox1.Text),
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



            txtUrunAdi.Text = dataDetail.ProductName;
            txtKalori.Text = dataDetail.Calori.ToString();
            txtPorsiyon.Text = dataDetail.Serving;
            //pbxResim.Image = ImageToByteArray.byteArrayToImage(dataDetail.Picture);
            textBox1.Text = dataDetail.Serving;
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
