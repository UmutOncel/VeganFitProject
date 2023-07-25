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

namespace VeganFit.UI
{
    public partial class UserMainForm : Form
    {
        bool mov;
        int movX, movY;
        private readonly IWeightRepo _weightRepo;
        private readonly IWeightService _weightService;
        private readonly IFeedbackService _feedbackService;
        private readonly IProductRepo _productRepo;

        public UserMainForm()
        {
            InitializeComponent();
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

        private void UserMainForm_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnVerileriGor_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = true;
            pnlSecim2.Visible = false;
            pnlSecim3.Visible = false;
            pnlSecim4.Visible = false;
            openChildFormInPanel(new UserDataForm());
        }

        private void btnKiloTakip_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = false;
            pnlSecim2.Visible = true;
            pnlSecim3.Visible = false;
            pnlSecim4.Visible = false;
            openChildFormInPanel(new UserAddWeigthForm(_weightService,_weightRepo));
        }

        private void btnOgununeUrunEkle_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = false;
            pnlSecim2.Visible = false;
            pnlSecim3.Visible = true;
            pnlSecim4.Visible = false;
            openChildFormInPanel(new UserAddMealForm(_productRepo));
        }

        private void btnGeriBildirimGönder_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = false;
            pnlSecim2.Visible = false;
            pnlSecim3.Visible = false;
            pnlSecim4.Visible = true;
            openChildFormInPanel(new UserFeedbackForm(_feedbackService));
        }
    }
}
