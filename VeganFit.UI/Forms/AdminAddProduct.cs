﻿using System.Data;
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

        public AdminAddProduct(IProductService productService, IProductRepo productRepo)
        {
            InitializeComponent();

            _service = productService;
            _productRepo = productRepo;
        }

        private void AdminAddProduct_Load(object sender, EventArgs e)
        {


            txtUrunAdi.ForeColor = Color.SlateGray;
            txtKalori.ForeColor = Color.SlateGray;
            txtPorsiyon.ForeColor = Color.SlateGray;
            txtAramaCubugu.ForeColor = Color.SlateGray;

            ListeyiYenile();
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





        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ProductCreateVm vm = new ProductCreateVm()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToDouble(txtKalori.Text),
                Serving = txtPorsiyon.Text,
                Picture = ImageToByteArray.imageToByteArray(pbxResim.Image)
            };
            _service.Create(vm);

            MessageBox.Show("Ürün Başarıyla Eklenmiştir");

            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dgvUrunler.DataSource = _productRepo.GetFilteredList(select: x => new { x.Id, x.ProductName, x.Calori, x.Serving, x.Picture }, where: x => x.State != State.Deleted);
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            ProductUpdateVm updateVm = new ProductUpdateVm()
            {
                Id = Convert.ToInt32(dgvUrunler.SelectedCells[0].Value),
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToDouble(txtKalori.Text),
                Serving = txtPorsiyon.Text,
                Picture = ImageToByteArray.imageToByteArray(pbxResim.Image)
            };
            _service.Update(updateVm);

            MessageBox.Show("Ürün Başarıyla Güncellenmiştir");

            ListeyiYenile();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunler.SelectedCells[0].Value);
            var product = _service.Delete(id);

            MessageBox.Show("Ürün Başarıyla Silinmiştir");

            ListeyiYenile();
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

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void txtAramaCubugu__TextChanged(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();
            dgvUrunler.DataSource = db.Products.Where(x => x.ProductName.Contains(txtAramaCubugu.Text) && x.State != State.Deleted)
                .Select(x => new { x.Id, x.ProductName, x.Calori, x.Serving, x.Picture })
                .ToList();
        }
    }
}
