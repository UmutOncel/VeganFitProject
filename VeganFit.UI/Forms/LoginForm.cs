using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Repositories;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeganFit.UI
{
    public partial class LoginForm : Form
    {
        bool mov, isAdmin;
        int movX, movY;

        private readonly IUserService _userService;
        private readonly IUserRepo _userRepo;

        public LoginForm(IUserService userService, IUserRepo userRepo)
        {
            InitializeComponent();
            _userService = userService;
            _userRepo = userRepo;
        }
        private void pnlLoginUI_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlLoginUI_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void pnlLoginUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "Kullanıcı Maili";
            txtSifre.Text = "Şifre";
            txtKullaniciAdi.ForeColor = Color.FromArgb(70, 205, 207);
            txtSifre.ForeColor = Color.FromArgb(70, 205, 207);

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Maili")
            {
                txtKullaniciAdi.Text = "";
                txtKullaniciAdi.ForeColor = Color.FromArgb(70, 205, 207);
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullanıcı Maili";
                txtKullaniciAdi.ForeColor = Color.FromArgb(70, 205, 207);
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.FromArgb(70, 205, 207);
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.FromArgb(70, 205, 207);
            }
        }


        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            lblKapat.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.Visible = false;
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
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            WarningForm warningForm = new WarningForm(_userService);
            warningForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sifre = PasswordHassing.Sha256Hash(txtSifre.Text);
            var login = _userService.Login(txtKullaniciAdi.Text, sifre);

            if (login.Data == null)
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Edin");
            }
            else
            {
                isAdmin = login.Data.Role == Core.Enums.Role.Admin;

                ActiveUser.Role = login.Data.Role;
                ActiveUser.ActiveUserName = login.Data.Email;
                ActiveUser.ActiveUserFirstName = _userRepo.GetFirstOrDefault(filter: x => x.Email == login.Data.Email).Firstname;

                if (isAdmin)
                {
                    AdminMainForm adminMainForm = new AdminMainForm();
                    adminMainForm.Show();
                    this.Hide(); // Close olabilir mi ??
                }
                else
                {
                    UserMainForm userMainForm = new UserMainForm();
                    userMainForm.Show();
                    this.Hide();
                }
            }




        }
    }
}
