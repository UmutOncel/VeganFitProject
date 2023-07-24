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
using VeganFit.Models.DTOs.ProductDtos;
using VeganFit.Models.VMs.OptionalProductVms;
using VeganFit.Models.VMs.ProductVms;

namespace VeganFit.UI
{
    public partial class UserAddNewProductForm : Form
    {
        string _fileName, _sourceFileName, _targetFileName;
        private readonly IOptionalProductService _optionalProductService;
        public UserAddNewProductForm(IOptionalProductService optionalProductService)
        {
            InitializeComponent();
            _optionalProductService = optionalProductService;
        }

        private void UserAddNewProductForm_Load(object sender, EventArgs e)
        {

            txtUrunAdi.Text = "Ürün Adı";
            txtKalori.Text = "Kaç Kalori";
            txtPorsiyon.Text = "Porsiyon Giriniz";

            txtUrunAdi.ForeColor = Color.SlateGray;
            txtKalori.ForeColor = Color.SlateGray;
            txtPorsiyon.ForeColor = Color.SlateGray;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDialog.FileName;

                _sourceFileName = openFileDialog.FileName;
                _targetFileName = Path.Combine(Application.StartupPath, "ImagesFile");
                File.Copy(_sourceFileName, _targetFileName, true);

                pbxResim.Image = Image.FromFile(_targetFileName);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            OptionalProductCreateVm vm = new OptionalProductCreateVm()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToInt32(txtKalori.Text),
                Serving = txtPorsiyon.Text,
                Picture = pbxResim.Image.ToString()
            };
            var optProduct = _optionalProductService.Create(vm);

            MessageBox.Show("Ürün Başarıyla Eklenmiştir");
           
        }
        


    }
}
