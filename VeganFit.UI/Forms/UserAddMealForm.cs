using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Services;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Entities;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class UserAddMealForm : Form
    {
        private readonly IProductRepo _ProductRepo;
        private readonly IDataService _dataService;
        private readonly ProductService _productService;
        public static string name = string.Empty;
        public static DataDetailDto _data;
        private readonly IDataRepo _dataRepo;

        public UserAddMealForm(IProductRepo ProductRepo, IDataRepo dataRepo)
        {
            InitializeComponent();
            _ProductRepo = ProductRepo;
            _data = new DataDetailDto();
            _dataRepo = dataRepo;
        }

        private void UserAddMealForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();

            txtAramaKutusu.Text = "Ürün Ara";
            txtAramaKutusu.ForeColor = Color.SlateGray;

            OgunListeleriniYenile();
        }

        public void OgunListeleriniYenile() 
        {
            dgvSabah.DataSource = _dataRepo.GetFilteredList(select: x => new { x.Product.ProductName, x.Calori }, where: x => x.State != State.Deleted && x.Meal == Meal.Breakfast
              && x.User.Email == ActiveUser.ActiveUserName && x.Datetime == DateTime.Now);

            dgvOgle.DataSource = _dataRepo.GetFilteredList(select: x => new { x.Product.ProductName, x.Calori }, where: x => x.State != State.Deleted && x.Meal == Meal.Lunch
              && x.User.Email == ActiveUser.ActiveUserName && x.Datetime == DateTime.Now);

            dgvAksam.DataSource = _dataRepo.GetFilteredList(select: x => new { x.Product.ProductName, x.Calori }, where: x => x.State != State.Deleted && x.Meal == Meal.Dinner
              && x.User.Email == ActiveUser.ActiveUserName && x.Datetime == DateTime.Now);
        }

        private void txtAramaCubugu_Enter(object sender, EventArgs e)
        {
            if (txtAramaKutusu.Text == "Ürün Ara")
            {
                txtAramaKutusu.Text = "";
                txtAramaKutusu.ForeColor = Color.Black;
            }
        }

        private void txtAramaCubugu_Leave(object sender, EventArgs e)
        {
            if (txtAramaKutusu.Text == "")
            {
                txtAramaKutusu.Text = "Ürün Ara";
                txtAramaKutusu.ForeColor = Color.SlateGray;
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

        private void btnUrunuSilSabah_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSabah.SelectedCells[0].Value);
            var product = _productService.Delete(id);
            MessageBox.Show("Başarıyla Silinmiştir");
        }

        private void btnUrunuSilOgle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvOgle.SelectedCells[0].Value);
            var product = _productService.Delete(id);
            MessageBox.Show("Başarıyla Silinmiştir");
        }

        private void btnUrunuSilAksam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAksam.SelectedCells[0].Value);
            var product = _productService.Delete(id);
            MessageBox.Show("Başarıyla Silinmiştir");
        }
        private void ListeyiYenile()
        {
            dgvUrunlerListesi.DataSource = _ProductRepo.GetFilteredList(select:x=> new
            {
                x.ProductName,
                x.Calori,
                x.Serving,
                x.Picture
            },where:x=>x.State!= State.Deleted);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btnListeyiYenile_MouseEnter(object sender, EventArgs e)
        {
            lblListeyiYenile.Visible = true;
        }

        private void btnListeyiYenile_MouseLeave(object sender, EventArgs e)
        {
            lblListeyiYenile.Visible = false;
        }

        private void dgvUrunlerListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            _data.ProductName = dgvUrunlerListesi.SelectedRows[0].Cells[0].Value.ToString();
            _data.Calori =Convert.ToInt32( dgvUrunlerListesi.SelectedRows[0].Cells[1].Value);
            _data.Serving = dgvUrunlerListesi.SelectedRows[0].Cells[2].Value.ToString();
            _data.Picture = (byte[])dgvUrunlerListesi.SelectedRows[0].Cells[3].Value;



            UserSetProductForm userSet = new UserSetProductForm(_dataService);
            userSet.ShowDialog();
            

            //int id = Convert.ToInt32(dgvUrunlerListesi.SelectedRows[0].Cells[0].Value);
            //UserSetProductForm userSetProductForm = new UserSetProductForm(id);

        }
    }
}
