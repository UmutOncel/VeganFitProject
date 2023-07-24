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
    public partial class UserAddMealForm : Form
    {
        public UserAddMealForm()
        {
            InitializeComponent();
        }

        private void UserAddMealForm_Load(object sender, EventArgs e)
        {
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
            MessageBox.Show("Başarıyla Silinmiştir");
        }

        private void btnUrunuSilOgle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Silinmiştir");
        }

        private void btnUrunuSilAksam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Silinmiştir");
        }

    }
}
