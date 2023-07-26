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
using VeganFit.Bll.Concrete.Services;
using VeganFit.DAL.Concrete.Context;
using VeganFit.Models.VMs.FeedbackVms;

namespace VeganFit.UI
{
    public partial class UserFeedbackForm : Form
    {
        private readonly IFeedbackService _service;

        public UserFeedbackForm(IFeedbackService feedbackService)
        {
            InitializeComponent();
            this._service = feedbackService;
        }

        private void UserFeedbackForm_Load(object sender, EventArgs e)
        {

            txtGorusOneri.ForeColor = Color.SteelBlue;
        }

        private void txtGorusOneri_Leave(object sender, EventArgs e)
        {
            if (txtGorusOneri.Text == "")
            {
                txtGorusOneri.Text = "Görüş ve Öneriniz";
                txtGorusOneri.ForeColor = Color.SteelBlue;
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

        private void btnGonder_Click(object sender, EventArgs e)
        {
            FeedbackCreateVm vm = new FeedbackCreateVm()
            {
                Message = txtGorusOneri.Text
            };
            _service.Create(vm);

            MessageBox.Show("Geri Bildiriminiz İçin Teşekkürler");
            this.Close();
        }

        private void txtGorusOneri__TextChanged(object sender, EventArgs e)
        {
            if (txtGorusOneri.Text.Length > 0)
            {
                btnGonder.Enabled = true;
            }
            else
            {
                btnGonder.Enabled = false;
            }
        }
    }
}
