﻿using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
using TextBoxs.TextBox;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.Entities;
using VeganFit.Models.VMs.ProductVms;
using VeganFit.UI.Properties;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class AdminAddProduct : Form
    {
        private readonly IProductService _service;
        private readonly IProductRepo _productRepo;
        bool isString;

        public AdminAddProduct(IProductService productService, IProductRepo productRepo)
        {
            InitializeComponent();

            _service = productService;
            _productRepo = productRepo;

        }

        private void AdminAddProduct_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            bool isString = txtUrunAdi.Text.All(Char.IsLetter);
            if (isString)
            {
                ControlCaloriForAddProduct();
            }
            else
            {
                MessageBox.Show("Ürün adını girerken sadece harf kullanınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Ürün eklerken kalori için gerekli kontrolleri yapan metot.
        /// </summary>
        private void ControlCaloriForAddProduct()
        {
            string strCalori = txtKalori.Text;
            double calori;
            bool isDouble = double.TryParse(strCalori, out calori);
            if (isDouble && Convert.ToDouble(txtKalori.Text) > 0)
            {
                ControlServingForAddProduct();
            }
            else
            {
                MessageBox.Show("Kalori değeri sıfırdan büyük bir sayı olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Ürün eklerken porsiyon için gerekli kontrolleri yapan metot.
        /// </summary>
        private void ControlServingForAddProduct()
        {
            string strServing = txtPorsiyon.Text;
            double serving;
            bool isDouble = double.TryParse(strServing, out serving);
            if (isDouble && Convert.ToDouble(txtKalori.Text) > 0)
            {
                AddProduct();
            }
            else
            {
                MessageBox.Show("Porsiyon değeri sıfırdan büyük bir sayı olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Database'e yeni ürün ekleyen metot.
        /// </summary>
        private void AddProduct()
        {
            ProductCreateVm vm = new ProductCreateVm()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToDouble(txtKalori.Text),
                Serving = txtPorsiyon.Text,
                Picture = ImageToByteArray.imageToByteArray(pbxResim.Image)
            };
            _service.Create(vm);

            MessageBox.Show("Ürün başarıyla eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();

            RefreshList();
        }

        /// <summary>
        /// İşlemler sonucunda listeyi otomatik yenileyip verilerin ekrana gelmesini sağlayan metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshList()
        {
            dgvUrunler.DataSource = _productRepo.GetFilteredList(select: x => new { x.Id, x.ProductName, x.Calori, x.Serving, x.Picture }, where: x => x.State != State.Deleted);
            DatagridViewChangeColumnName();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {                
                ControlProductNameForUpdateProduct();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ürün güncellemek için önce listeden bir ürün seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Ürün güncellerken porsiyon için gerekli kontrolleri yapan metot.
        /// </summary>
        private void ControlServingForUpdateProduct()
        {
            string strServing = txtPorsiyon.Text;
            double serving;
            bool isDouble = double.TryParse(strServing, out serving);
            if (isDouble && Convert.ToDouble(txtKalori.Text) > 0)
            {
                UpdateProduct();
            }
            else
            {
                MessageBox.Show("Porsiyon değeri sıfırdan büyük bir sayı olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Ürün güncellerken kalori için gerekli kontrolleri yapan metot.
        /// </summary>
        private void ControlCaloriForUpdateProduct()
        {
            string strCalori = txtKalori.Text;
            double calori;
            bool isDouble = double.TryParse(strCalori, out calori);
            if (isDouble && Convert.ToDouble(txtKalori.Text) > 0)
            {
                ControlServingForUpdateProduct();
            }
            else
            {
                MessageBox.Show("Kalori değeri sıfırdan büyük bir sayı olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Ürün güncellerken ürün adı için gerekli kontrolleri yapan metot.
        /// </summary>
        private void ControlProductNameForUpdateProduct()
        {
            if (isString)
            {
                ControlCaloriForUpdateProduct();
            }
            else
            {
                MessageBox.Show("Ürün adını girerken sadece harf kullanınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Database'deki ürünü güncelleyen metot.
        /// </summary>
        private void UpdateProduct()
        {
            ProductUpdateVm updateVm = new ProductUpdateVm()
            {
                Id = _productRepo.GetFilteredFirstOrDefault(select:x=>x.Id,where:x=>x.Id == Convert.ToInt32(dgvUrunler.SelectedCells[0].Value)),
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToDouble(txtKalori.Text),
                Serving = txtPorsiyon.Text,
                Picture = ImageToByteArray.imageToByteArray(pbxResim.Image)
            };
            _service.Update(updateVm);

            MessageBox.Show("Ürün başarıyla güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
            RefreshList();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUrunler.SelectedCells[0].Value);
                var product = _service.Delete(id);

                MessageBox.Show("Ürün başarıyla silinmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshList();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün silmek için önce listeden bir ürün seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string pictureName = ofd.FileName;
                pbxResim.Image = Image.FromFile(pictureName);
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.SelectedRows[0].Cells["ProductName"].Value.ToString();
            txtKalori.Text = dgvUrunler.SelectedRows[0].Cells["Calori"].Value.ToString();
            txtPorsiyon.Text = dgvUrunler.SelectedRows[0].Cells["Serving"].Value.ToString();
            byte[] image = (byte[])(dgvUrunler.SelectedRows[0].Cells["Picture"].Value);

            if (image != null)
            {
                 pbxResim.Image = ImageToByteArray.byteArrayToImage(image);
                 pbxResim.BorderStyle = BorderStyle.None;
            }
            else
            {
                 pbxResim.Image = null;
                 pbxResim.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void txtAramaCubugu__TextChanged(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();
            dgvUrunler.DataSource = db.Products.Where(x => x.ProductName.Contains(txtAramaCubugu.Text) && x.State != State.Deleted)
                .Select(x => new { x.Id, x.ProductName, x.Calori, x.Serving, x.Picture })
                .ToList();
        }

        private void dgvUrunler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// <summary>
        /// Textbox ve picturebox'taki verileri silen metottur.
        /// </summary>
        private void ClearAll()
        {
            txtKalori.Text = string.Empty;
            txtPorsiyon.Text = string.Empty;
            txtUrunAdi.Text = string.Empty;
            pbxResim.Image = null;
            pbxResim.BorderStyle = BorderStyle.Fixed3D;
        }

        private void DatagridViewChangeColumnName()
        {
            dgvUrunler.Columns[1].HeaderText = "Ürün İsmi";
            dgvUrunler.Columns[2].HeaderText = "Kalori";
            dgvUrunler.Columns[3].HeaderText = "Porsiyon";
            dgvUrunler.Columns[4].HeaderText = "Resim";
        }

        private void txtUrunAdi__TextChanged(object sender, EventArgs e)
        {
            isString = RegularEx(@"^[a-zA-ZüıöğşçĞÖÜİŞÇ ]*$", txtUrunAdi);

            if (txtUrunAdi.Text.Length > 0 && txtKalori.Text.Length > 0 && txtPorsiyon.Text.Length > 0)
            {
                btnUrunEkle.Enabled = true;
            }
            else
            {
                btnUrunEkle.Enabled = false;
            }
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
    }
}
