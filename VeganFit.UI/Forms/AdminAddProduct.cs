using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeganFit.UI
{
    public partial class AdminAddProduct : Form
    {
        public AdminAddProduct()
        {
            InitializeComponent();
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
            MessageBox.Show("Ürün Başarıyla Eklenmiştir");
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Başarıyla Güncellenmiştir");
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Başarıyla Silinmiştir");
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

        }
    }
}
