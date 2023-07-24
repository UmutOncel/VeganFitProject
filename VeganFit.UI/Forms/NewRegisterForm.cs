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

namespace VeganFit.UI
{
    public partial class NewRegisterForm : Form
    {
        bool mov;
        int movX, movY;
        private readonly IUserService _userService;
        public NewRegisterForm()
        {
            InitializeComponent();

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
            txtSifreyiTekrarGirin.Text = "Şifreyi Tekrar Girin";

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

            if (txtSifreyiTekrarGirin.Text == "Şifreyi Tekrar Girin")
            {
                txtSifreyiTekrarGirin.Text = "";
                txtSifreyiTekrarGirin.ForeColor = Color.DarkViolet;
            }
        }

        private void txtSifreyiTekrarGirin_Leave(object sender, EventArgs e)
        {
            if (txtSifreyiTekrarGirin.Text == "")
            {
                txtSifreyiTekrarGirin.Text = "Şifreyi Tekrar Girin";
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
            //var user = _userService.Create(txtEMail.Text, txtSifre.Text);

            //if(user != null)
            //{
            //    MessageBox.Show("Kayıt Başarılı");
            //    LoginForm loginForm = new LoginForm(_userService);
            //    loginForm.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Test");
            //}

            

            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

    }
}
