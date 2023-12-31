﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.UI.EFContextForm;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class AdminMainForm : Form
    {
        bool mov;
        int movX, movY;
        private readonly IUserRepo _userRepo;

        public AdminMainForm(IUserRepo userRepo)
        {
            InitializeComponent();
            _userRepo = userRepo;
        }
        
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lblKayitliKullaniciSayisi.Text = _userRepo.GetFilteredList(select:x => x.Email,where:x=>x.Role == Role.StandartUser).Count().ToString();
        }

        private void pnlUstMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlUstMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void pnlUstMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void btnSimgeDurumunaKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSimgeDurumunaKucult_MouseEnter(object sender, EventArgs e)
        {
            lblSimgeDurumunaKucult.Visible = true;
        }

        private void btnSimgeDurumunaKucult_MouseLeave(object sender, EventArgs e)
        {
            lblSimgeDurumunaKucult.Visible = false;
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        private Form activeForm = null;

        /// <summary>
        /// Main form içinde child formları iç içe açmak için kullanılan metottur.
        /// </summary>
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = true;
            pnlSecim2.Visible = false;
            openChildFormInPanel(EFContextForm.EFContextForm.ConfigureServices<AdminAddProduct>());
        }

        private void btnBildirimleriGor_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = false;
            pnlSecim2.Visible = true;
            openChildFormInPanel(EFContextForm.EFContextForm.ConfigureServices<AdminFeedbackForm>());
        }
    }
}
