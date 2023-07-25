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
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.UserVms;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserDataForm : Form
    {
        public UserDataForm()
        {
            InitializeComponent();
        }


        private void UserDataForm_Load(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();
            
            dgvGunSonuKalori.DataSource = db.Datas.Where(x => x.User.Email == ActiveUser.ActiveUserName)
                .GroupBy(x => new { x.User.Email, x.Datetime })
                .Select(x => new
                {
                    Tarih = x.Key.Datetime,
                    ToplamKalori = x.Sum(x => x.Calori)
                }).ToList();

            dgvGunlukKiloTakibi.DataSource = db.Weights.Where(x => x.User.Email == ActiveUser.ActiveUserName)
                .Select(x => new
                {
                    Tarih = x.DateOfRecord,
                    Kilo = x.UserWeight
                }).ToList();
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
