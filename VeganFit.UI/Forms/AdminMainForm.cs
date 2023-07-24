using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeganFit.DAL.Concrete.Context;

namespace VeganFit.UI
{
    public partial class AdminMainForm : Form
    {
        bool mov;
        int movX, movY;
        public AdminMainForm()
        {
            InitializeComponent();
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            VeganFitDbContext db = new VeganFitDbContext();
            lblKayitliKullaniciSayisi.Text = db.Users.Select(x => x.Email).Distinct().Count().ToString();
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
            //openChildFormInPanel(new AdminAddProduct());
        }

        private void btnBildirimleriGor_Click(object sender, EventArgs e)
        {
            pnlSecim1.Visible = false;
            pnlSecim2.Visible = true;
            openChildFormInPanel(new AdminFeedbackForm());
        }
    }
}
