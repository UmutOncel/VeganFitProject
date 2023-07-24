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
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserAddWeigthForm : Form
    {
        private readonly IWeightService _weightService;
        private readonly WeightRepo _weightRepo;
        public UserAddWeigthForm(IWeightService weightService, WeightRepo weightRepo)
        {
            InitializeComponent();
            _weightService = weightService;
            _weightRepo = weightRepo;
        }
               
        private void UserAddWeigthForm_Load(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();

            dgvGunlukKiloTakibi.DataSource = db.Weights.Where(x => x.User.Email == ActiveUser.ActiveUserName)

                .Select(x => new
                {
                    Tarih = x.DateOfRecord,
                    Kilo = x.UserWeight
                }).ToList();

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
            MessageBox.Show("Kayıt Başarılı");
        }
        
    }
}
