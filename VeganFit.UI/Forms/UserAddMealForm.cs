using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.Bll.Concrete.Services;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Entities;

namespace VeganFit.UI
{
    public partial class UserAddMealForm : Form
    {
        private readonly OptionalProductRepo _optionalProductRepo;
        private readonly ProductService _productService;
        public UserAddMealForm(OptionalProductRepo optionalProductRepo, ProductService productService)
        {
            InitializeComponent();
            _optionalProductRepo = optionalProductRepo;
            _productService = productService;
        }

        public UserAddMealForm()
        {
        }

        private void UserAddMealForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();

            txtAramaKutusu.Text = "Ürün Ara";
            txtAramaKutusu.ForeColor = Color.SlateGray;
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
            dgvUrunlerListesi.DataSource = _optionalProductRepo.GetAll(null);
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
            //int id = Convert.ToInt32(dgvUrunlerListesi.SelectedRows[0].Cells[0].Value);
            //UserSetProductForm userSetProductForm = new UserSetProductForm(id);

            /////////////////////
        }
    }
}
