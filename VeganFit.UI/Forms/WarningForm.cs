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
using VeganFit.UI.EFContextForm;

namespace VeganFit.UI
{
    public partial class WarningForm : Form
    {
        bool mov;
        int movX, movY;
        private readonly IUserService _userService;
        public WarningForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;


        }
        private void btnIlerle_Click(object sender, EventArgs e)
        {
            var formRegister = EFContextForm.EFContextForm.ConfigureServices<NewRegisterForm>();
            formRegister.Show();
            this.Close();
        }

        private void pnlWarningForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlWarningForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void pnlWarningForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        //private void btnGeriDön_Click(object sender, EventArgs e)
        //{
        //    LoginForm loginForm = new LoginForm();
        //    loginForm.ShowDialog();
        //    this.Close();
        //}

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            lblKapat.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.Visible = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
