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
using VeganFit.Models.VMs.WeightVms;

namespace VeganFit.UI
{
    public partial class UserAddWeigthForm : Form
    {        
        public UserAddWeigthForm()
        {
            InitializeComponent();
           
        }
               
        private void UserAddWeigthForm_Load(object sender, EventArgs e)
        {
            ListedFill();

            txtKilo.Text = "Kilonuzu Giriniz";
            txtKilo.ForeColor = Color.SlateGray;
  
        }
        private void txtKilo_Enter(object sender, EventArgs e)
        {
            if (txtKilo.Text == "Kilonuzu Giriniz")
            {
                txtKilo.Text = "";
                txtKilo.ForeColor = Color.Black;
            }
        }

        private void txtKilo_Leave(object sender, EventArgs e)
        {
            if (txtKilo.Text == "")
            {
                txtKilo.Text = "Kilonuzu Giriniz";
                txtKilo.ForeColor = Color.SlateGray;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            WeightCreateVm vm = new WeightCreateVm()
            {
                Weight=Convert.ToInt32(txtKilo.Text)                
            };

            MessageBox.Show("Kayıt Başarılı");
        }
        private void ListedFill()
        {
            WeightCreateVm weigthVm = new WeightCreateVm();
            dgvGunlukKiloTakibi.DataSource = weigthVm.ToString().ToList();
        }

    }
}
