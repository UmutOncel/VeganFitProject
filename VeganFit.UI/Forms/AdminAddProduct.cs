﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.Entities;
using VeganFit.Models.VMs.ProductVms;

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
            txtUrunAdi.Text = "Ürün Adı";
            txtKalori.Text = "Kaç Kalori";
            txtPorsiyon.Text = "Porsiyon Giriniz";
            txtAramaCubugu.Text = "Ürün Ara";


            txtUrunAdi.ForeColor = Color.SlateGray;
            txtKalori.ForeColor = Color.SlateGray;
            txtPorsiyon.ForeColor = Color.SlateGray;
            txtAramaCubugu.ForeColor = Color.SlateGray;

            ListeyiYenile();
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
                txtKalori.ForeColor = Color.SlateGray;
            }
        }

        private void txtKalori_Leave(object sender, EventArgs e)
        {
            if (txtKalori.Text == "")
            {
                txtKalori.Text = "Kaç Kalori";
                txtKalori.ForeColor = Color.Black;
            }
        }

        private void txtPorsiyon_Enter(object sender, EventArgs e)
        {
            if (txtPorsiyon.Text == "Porsiyon Giriniz")
            {
                txtPorsiyon.Text = "";
                txtPorsiyon.ForeColor = Color.SlateGray;
            }
        }

        private void txtPorsiyon_Leave(object sender, EventArgs e)
        {
            if (txtPorsiyon.Text == "")
            {
                txtPorsiyon.Text = "Porsiyon Giriniz";
                txtPorsiyon.ForeColor = Color.Black;
            }
        }

        private void txtAramaCubugu_Enter(object sender, EventArgs e)
        {
            if (txtAramaCubugu.Text == "Ürün Ara")
            {
                txtAramaCubugu.Text = "";
                txtAramaCubugu.ForeColor = Color.SlateGray;
            }
        }

        private void txtAramaCubugu_Leave(object sender, EventArgs e)
        {
            if (txtAramaCubugu.Text == "")
            {
                txtAramaCubugu.Text = "Ürün Ara";
                txtAramaCubugu.ForeColor = Color.Black;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ProductCreateVm vm = new ProductCreateVm()
            {
                ProductName = txtUrunAdi.Text,
                Calori = Convert.ToInt32(txtKalori.Text),
                Serving = txtPorsiyon.Text,
                Picture = pbxResim.Image.ToString()
            };
            var product = _service.Create(vm);

            MessageBox.Show("Ürün Başarıyla Eklenmiştir");

            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dgvUrunler.DataSource = _productRepo.GetFilteredList(select: x => new { x.Id, x.ProductName, x.Calori, x.Serving, x.Picture }, where: x => x.State != State.Deleted);
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunler.SelectedCells[0].Value);        //INDEX!!!!!!
            Product product = _productRepo.GetFirstOrDefault(x => x.Id == id);
            product.ProductName = txtUrunAdi.Text;
            product.Calori = Convert.ToInt32(txtKalori.Text);
            product.Serving = txtPorsiyon.Text;
            product.Picture = pbxResim.Image.ToString();
            _productRepo.Update(product);

            //ProductUpdateVm vm = new ProductUpdateVm() 
            //{
            //    ProductName = txtUrunAdi.Text,
            //    Calori = Convert.ToInt32(txtKalori.Text),
            //    Serving = txtPorsiyon.Text,
            //    Picture = pbxResim.Image.ToString()
            //};
            //var product = _service.Update(vm);

            MessageBox.Show("Ürün Başarıyla Güncellenmiştir");

            ListeyiYenile();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunler.SelectedCells[0].Value);        //INDEX!!!!!!
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
                pbxResim.Image = Image.FromFile(dgvUrunler.SelectedRows[0].Cells["Picture"].Value.ToString());
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void txtAramaCubugu__TextChanged(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();
            dgvUrunler.DataSource = db.Products.Where(x => x.ProductName.Contains(txtUrunAdi.Text))
                .Select(x => new { x.Id, x.ProductName, x.Calori, x.Serving, x.Picture })
                .ToList();
        }
    }
}