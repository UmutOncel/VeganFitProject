using Microsoft.VisualBasic;
using System.Data;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Bll.Concrete.Services;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Entities;
using VeganFit.Models.DTOs.DataDtos;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserAddMealForm : Form
    {
        private readonly IProductRepo _ProductRepo;
        public static DataDetailDto _data;
        private readonly IDataRepo _dataRepo;
        private readonly IDataService _dataService;



        public UserAddMealForm(IProductRepo ProductRepo, IDataRepo dataRepo, IDataService dataService)
        {
            InitializeComponent();

            this._ProductRepo = ProductRepo;
            _data = new DataDetailDto();
            _dataRepo = dataRepo;
            _dataService = dataService;
        }

        private void UserAddMealForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            RefreshMealLists();
        }

        /// <summary>
        /// Öğün Listelerini yenilemeye yarayan metottur.
        /// </summary>
        public void RefreshMealLists()
        {
            string sqlFormattedDate = DateTimeTodayTostring();

            dgvSabah.DataSource = _dataRepo.GetFilteredList(select: x => new { x.ProductName, x.Calori }, where: x => x.State != State.Deleted && x.Meal == Meal.Breakfast
              && x.UserEmail == ActiveUser.ActiveUserName && x.Datetime.ToString() == sqlFormattedDate); ;

            dgvOgle.DataSource = _dataRepo.GetFilteredList(select: x => new { x.ProductName, x.Calori }, where: x => x.State != State.Deleted && x.Meal == Meal.Lunch
              && x.UserEmail == ActiveUser.ActiveUserName && x.Datetime.ToString() == sqlFormattedDate);

            dgvAksam.DataSource = _dataRepo.GetFilteredList(select: x => new { x.ProductName, x.Calori }, where: x => x.State != State.Deleted && x.Meal == Meal.Dinner
              && x.UserEmail == ActiveUser.ActiveUserName && x.Datetime.ToString() == sqlFormattedDate);

            DataGridViewColumnNames();
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
            try
            {
                string msg = "Ürün sabah öğününden başarıyla silinmiştir.";
                string chooseProduct = dgvSabah.SelectedCells[0].Value.ToString();
                DeleteProductFromMeal(Meal.Breakfast, chooseProduct, msg);
            }
            catch (Exception u)
            {
                MessageBox.Show("Sabah Listenizde Ürün Bulunmamaktadır","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            
        }
        private void DeleteProductFromMeal(Meal meal,string productName,string msg)
        {
            string dateTimeToday = DateTimeTodayTostring();
            int id = _dataRepo.GetFilteredFirstOrDefault(select: x => x.Id, where: x => x.ProductName == productName && x.UserEmail == ActiveUser.ActiveUserName && x.Datetime.ToString() == dateTimeToday && x.State == State.Created && x.Meal == meal);
            var product = _dataService.Delete(id);
            MessageBox.Show(msg, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshMealLists();
        }

        private void btnUrunuSilOgle_Click(object sender, EventArgs e)
        {
            string msg = "Ürün öğle öğününden başarıyla silinmiştir.";
            string chooseProduct = dgvOgle.SelectedCells[0].Value.ToString();
            DeleteProductFromMeal(Meal.Lunch, chooseProduct, msg);
            
        }

        private void btnUrunuSilAksam_Click(object sender, EventArgs e)
        {
            string msg = "Ürün akşam öğnünden başarıyla silinmiştir.";
            string chooseProduct = dgvAksam.SelectedCells[0].Value.ToString();
            DeleteProductFromMeal(Meal.Dinner, chooseProduct, msg);           
        }

        /// <summary>
        /// Listeyi yenilemeye yarayan metottur.
        /// </summary>
        private void RefreshList()
        {
            if (_ProductRepo != null)
            {
                dgvUrunlerListesi.DataSource = _ProductRepo.GetFilteredList(select: x => new
                {
                    x.ProductName,
                    x.Calori,
                    x.Serving,
                    x.Picture
                }, where: x => x.State != State.Deleted);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            RefreshList();
            var urunEkle = EFContextForm.EFContextForm.ConfigureServices<UserAddNewProductForm>();
            urunEkle.ShowDialog();
        }

        private void btnListeyiYenile_Click(object sender, EventArgs e)
        {
            RefreshMealLists();
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
            try
            {
                _data.ProductName = dgvUrunlerListesi.SelectedRows[0].Cells[0].Value.ToString();
                _data.Calori = Convert.ToInt32(dgvUrunlerListesi.SelectedRows[0].Cells[1].Value);
                _data.Serving = dgvUrunlerListesi.SelectedRows[0].Cells[2].Value.ToString();
                _data.Picture = (byte[])dgvUrunlerListesi.SelectedRows[0].Cells[3].Value;

                var setProductForm = EFContextForm.EFContextForm.ConfigureServices<UserSetProductForm>();
                setProductForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sadece ilk sütundan seçim yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtAramaKutusu__TextChanged(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();
            dgvUrunlerListesi.DataSource = db.Products.Where(x => x.ProductName.Contains(txtAramaKutusu.Text) && x.State != State.Deleted)
                .Select(x => new { x.ProductName, x.Calori, x.Serving, x.Picture })
                .ToList();
        }

        private void DataGridViewColumnNames()
        {
            dgvSabah.Columns[0].HeaderText = "Ürün İsmi";
            dgvSabah.Columns[1].HeaderText = "Kalori";

            dgvOgle.Columns[0].HeaderText = "Ürün İsmi";
            dgvOgle.Columns[1].HeaderText = "Kalori";

            dgvAksam.Columns[0].HeaderText = "Ürün İsmi";
            dgvAksam.Columns[1].HeaderText = "Kalori";

            dgvUrunlerListesi.Columns[0].HeaderText = "Ürün İsmi";
            dgvUrunlerListesi.Columns[1].HeaderText = "Kalori";
            dgvUrunlerListesi.Columns[2].HeaderText = "Porsiyon";
            dgvUrunlerListesi.Columns[3].HeaderText = "Resim";
        }

        private string DateTimeTodayTostring()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            return sqlFormattedDate;
        }


    }
}
