using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserMainForm : Form
    {
        bool mov;
        int movX, movY;
        private readonly IDataRepo _dataRepo;

        public UserMainForm(IDataRepo dataRepo)
        {
            InitializeComponent();
            _dataRepo = dataRepo;
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
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnVerileriGor_Click(object sender, EventArgs e)
        {
            ChoosedPanelVisible(true, false, false, false);
            openChildFormInPanel(EFContextForm.EFContextForm.ConfigureServices<UserDataForm>());
        }

        private void btnKiloTakip_Click(object sender, EventArgs e)
        {
            ChoosedPanelVisible(false, true, false, false);
            openChildFormInPanel(EFContextForm.EFContextForm.ConfigureServices<UserAddWeigthForm>());
        }

        private void btnOgununeUrunEkle_Click(object sender, EventArgs e)
        {
            ChoosedPanelVisible(false, false, true, false);
            openChildFormInPanel(EFContextForm.EFContextForm.ConfigureServices<UserAddMealForm>());
        }

        private void btnGeriBildirimGönder_Click(object sender, EventArgs e)
        {
            ChoosedPanelVisible(false, false, false, true);
            openChildFormInPanel(EFContextForm.EFContextForm.ConfigureServices<UserFeedbackForm>());
        }
        private void ChoosedPanelVisible(bool pnl1, bool pnl2, bool pnl3, bool pnl4)
        {
            pnlSecim1.Visible = pnl1;
            pnlSecim2.Visible = pnl2;
            pnlSecim3.Visible = pnl3;
            pnlSecim4.Visible = pnl4;
        }

        /// <summary>
        /// Data tablosunda kullanıcının tükettiği ürünlerin kalori bilgisi yoksa verileri gör butonunu pasif, varsa aktif yapan metot.
        /// </summary>
        private void EnableButton()
        {
            var data = _dataRepo.GetFilteredList(select: x => new { x.Calori }, where: x => x.UserEmail == ActiveUser.ActiveUserName && x.State != State.Deleted);
            if (data.Count != 0)
            {
                btnVerileriGor.Enabled = true;
            }
            else
            {
                btnVerileriGor.Enabled = false;
            }
        }

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            EnableButton();
        }
    }
}
