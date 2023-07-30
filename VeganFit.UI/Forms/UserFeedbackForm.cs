using VeganFit.Bll.Abstract.IServices;
using VeganFit.Models.VMs.FeedbackVms;

namespace VeganFit.UI
{
    public partial class UserFeedbackForm : Form
    {
        private readonly IFeedbackService _service;

        public UserFeedbackForm(IFeedbackService feedbackService)
        {
            InitializeComponent();
            _service = feedbackService;
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

            MessageBox.Show("Geri bildiriminiz için teşekkür ederiz", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
