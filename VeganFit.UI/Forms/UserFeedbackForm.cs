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
using VeganFit.Models.VMs.FeedbackVms;

namespace VeganFit.UI
{
    public partial class UserFeedbackForm : Form
    {
        //private readonly IFeedbackService _feedbackService;
        public UserFeedbackForm(/*IFeedbackService feedbackService*/)
        {
            InitializeComponent();
            //_feedbackService = feedbackService;
        }
               
        private void UserFeedbackForm_Load(object sender, EventArgs e)
        {
            txtGorusOneri.Text = "Görüş ve Öneriniz";
            txtGorusOneri.ForeColor = Color.SteelBlue;
        }
        private void txtGorusOneri_Enter(object sender, EventArgs e)
        {
            if (txtGorusOneri.Text == "Görüş ve Öneriniz")
            {
                txtGorusOneri.Text = "";
                txtGorusOneri.ForeColor = Color.Black;
            }
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
          FeedbackCreateVm feedbackCreateVm=new FeedbackCreateVm();
            feedbackCreateVm.Message = txtGorusOneri.Text;


           MessageBox.Show("Geri Bildiriminiz İçin Teşekkürler");
        }
    }
}
