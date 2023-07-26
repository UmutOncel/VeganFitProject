using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBoxs.TextBox;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Models.VMs.UserVms;
using VeganFit.UI.EFContextForm;
using VeganFit.UI.LoginUser;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class NewRegisterForm : Form
    {
        bool mov;
        int movX, movY;
        private readonly IUserService _userService;
        private readonly IUserRepo _userRepo;

        public NewRegisterForm(IUserService userService, IUserRepo userRepo)
        {
            InitializeComponent();
            _userService = userService;
            _userRepo = userRepo;
        }

        private void pnlNewRegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlNewRegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void pnlNewRegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void NewRegisterForm_Load(object sender, EventArgs e)
        {
            txtAd.Text = "Ad";
            txtSoyad.Text = "Soyad";
            txtEMail.Text = "EMail";
            txtSifre.Text = "Şifre";
            txtSifreyiTekrarGirin.Text = "Şifre";

            txtAd.ForeColor = Color.DarkViolet;
            txtSoyad.ForeColor = Color.DarkViolet;
            txtEMail.ForeColor = Color.DarkViolet;
            txtSifre.ForeColor = Color.DarkViolet;
            txtSifreyiTekrarGirin.ForeColor = Color.DarkViolet;
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text == "Ad")
            {
                txtAd.Text = "";
                txtAd.ForeColor = Color.DarkViolet;
            }
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "Ad";
                txtAd.ForeColor = Color.DarkViolet;
            }
        }
        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "Soyad")
            {
                txtSoyad.Text = "";
                txtSoyad.ForeColor = Color.DarkViolet;
            }
        }
        private void txtSoyad_Leave(object sender, EventArgs e)
        {

            if (txtSoyad.Text == "")
            {
                txtSoyad.Text = "Soyad";
                txtSoyad.ForeColor = Color.DarkViolet;
            }
        }
        private void txtEMail_Enter(object sender, EventArgs e)
        {
            if (txtEMail.Text == "EMail")
            {
                txtEMail.Text = "";
                txtEMail.ForeColor = Color.DarkViolet;
            }
        }

        private void txtEMail_Leave(object sender, EventArgs e)
        {
            if (txtEMail.Text == "")
            {
                txtEMail.Text = "EMail";
                txtEMail.ForeColor = Color.DarkViolet;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.DarkViolet;
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.DarkViolet;
            }
        }

        private void txtSifreyiTekrarGirin_Enter(object sender, EventArgs e)
        {

            if (txtSifreyiTekrarGirin.Text == "Şifre")
            {
                txtSifreyiTekrarGirin.Text = "";
                txtSifreyiTekrarGirin.ForeColor = Color.DarkViolet;
            }
        }

        private void txtSifreyiTekrarGirin_Leave(object sender, EventArgs e)
        {
            if (txtSifreyiTekrarGirin.Text == "")
            {
                txtSifreyiTekrarGirin.Text = "Şifre";
                txtSifreyiTekrarGirin.ForeColor = Color.DarkViolet;
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

        private void btnKaydiTamamla_Click(object sender, EventArgs e)
        {
            var dbKullaniciAdi = _userRepo.Any(x => x.Email == txtEMail.Text);
            if (!dbKullaniciAdi)
            {
                if (txtSifre.Text == txtSifreyiTekrarGirin.Text)
                {
                    string sifre = PasswordHassing.Sha256Hash(txtSifre.Text);
                    CreateVm createVm = new CreateVm()
                    {
                        FirstName = txtAd.Text,
                        LastName = txtSoyad.Text,
                        Email = txtEMail.Text,
                        BirthDate = dtpDogumTatihi.Value,
                        Password = sifre,
                        PasswordConfirm = txtSifreyiTekrarGirin.Text
                    };

                    var exist = _userService.Create(createVm);

                    if (exist != null)
                    {
                        MessageBox.Show("Başarıyla Kayıt Oluşturuldu.");
                        this.Close();
                        var loginForm = EFContextForm.EFContextForm.ConfigureServices<LoginForm>();
                        loginForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz şifrelerin aynı olması gerekir!");
                }
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz mail adresi sisteme kayıtlıdır. Farklı bir mail adresi giriniz!");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSifre__TextChanged(object sender, EventArgs e)
        {
            RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{8,}$", txtSifre);
        }

        public void RegularEx(string rgx, DesignTextBox txtb)
        {
            Regex regex = new Regex(rgx);
            Match match = regex.Match(txtb.Text);
        }

        private void txtSifreyiTekrarGirin__TextChanged(object sender, EventArgs e)
        {
            RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{8,}$", txtSifreyiTekrarGirin);

            if (txtSifre.Text == txtSifreyiTekrarGirin.Text)
            {
                btnKaydiTamamla.Enabled = true;
            }
        }
    }
}
