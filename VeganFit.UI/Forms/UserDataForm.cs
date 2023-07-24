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
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.WeightVms;

namespace VeganFit.UI
{
    public partial class UserDataForm : Form
    {
        private readonly IDataService _service;
        
        public UserDataForm(IDataService dataService)
        {
            InitializeComponent();
            _service = dataService;
        }

        public UserDataForm()
        {
        }

        private void ListedFill()
        {
            WeightCreateVm weigthVm = new WeightCreateVm();
            dgvGunlukKiloTakibi.DataSource = weigthVm.ToString().ToList();

            dgvGunSonuKalori.DataSource = _service.GetDetails().Data;
           

        }
        private void UserDataForm_Load(object sender, EventArgs e)
        {
            ListedFill();
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

       
    }
}
