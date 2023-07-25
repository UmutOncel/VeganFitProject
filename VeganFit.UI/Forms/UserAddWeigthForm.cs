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
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserAddWeigthForm : Form
    {
        private readonly IWeightService _service;
        private readonly IWeightRepo _weightRepo;
        private readonly IUserService _userService;

        public UserAddWeigthForm(IWeightService weightService, IWeightRepo weightRepo)
        {
            InitializeComponent();

            _service = weightService;
            _weightRepo = weightRepo;
        }

        private void UserAddWeigthForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();

            //txtKilo.Text = "Kilonuzu Giriniz";
            //txtKilo.ForeColor = Color.SlateGray;

        }
        private void txtKilo_Enter(object sender, EventArgs e)
        {
            //if (txtKilo.Text == "Kilonuzu Giriniz")
            //{
            //    txtKilo.Text = "";
            //    txtKilo.ForeColor = Color.Black;
            //}
        }

        private void txtKilo_Leave(object sender, EventArgs e)
        {
            //if (txtKilo.Text == "")
            //{
            //    txtKilo.Text = "Kilonuzu Giriniz";
            //    txtKilo.ForeColor = Color.SlateGray;
            //}
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
            bool varMi = _weightRepo.Any(x => x.RecordDate == dtpTarih.Value);
            if (!varMi)
            {
                WeightCreateVm vm = new WeightCreateVm()
                {
                    UserWeight = Convert.ToInt32(txtKilo.Text),
                    UserName = ActiveUser.ActiveUserFirstName

                };
                _service.Create(vm);
                MessageBox.Show("Kayıt Başarılı");
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show("Seçilen tarihte kaydınız bulunmaktadır!");
            }
        }

        private void ListeyiYenile()
        {
            dgvGunlukKiloTakibi.DataSource = _weightRepo.GetFilteredList(select: x => new { x.RecordDate, x.UserWeight, x.UserName }, where: x => x.UserName == ActiveUser.ActiveUserFirstName);
        }

        private void txtKilo__TextChanged(object sender, EventArgs e)
        {
            if (txtKilo.Text.Length > 0)
            {
                btnKaydet.Enabled = true;
            }
        }
    }
}
