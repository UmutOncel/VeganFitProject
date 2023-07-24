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
using VeganFit.Models.DTOs.WeigthDtos;
using VeganFit.Models.VMs.WeightVms;

namespace VeganFit.UI
{
    public partial class UserDataForm : Form
    {
        private readonly IWeightRepo _weightRepo;
        private readonly IDataRepo _dataRepo;

        public UserDataForm(IWeightRepo weightRepo, IDataRepo dataRepo)
        {
            InitializeComponent();
          _weightRepo = weightRepo;
            _dataRepo = dataRepo;
        }

        public UserDataForm()
        {
        }

       
        private void UserDataForm_Load(object sender, EventArgs e)
        {
            dgvGunlukKiloTakibi.DataSource = _weightRepo.GetFilteredList(select: x => new
            {
                x.UserWeight,
                x.DateOfRecord
            },
            where: x=>x.State!=State.Deleted);

            VeganFitDbContext db = new VeganFitDbContext();
            dgvGunSonuKalori.DataSource = db.Datas.Where(x => x.UserId ==)
                .GroupBy(x => new { x.UserId, x.Datetime })
                .Select(x => new
                {
                    Tarih = x.Key.Datetime,
                    ToplamKalori = x.Sum(x => x.Calori)
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
