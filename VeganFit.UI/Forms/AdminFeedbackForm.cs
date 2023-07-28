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
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;

namespace VeganFit.UI
{
    public partial class AdminFeedbackForm : Form
    {
        private readonly IFeedbackService _service;
        private readonly IFeedbackRepo _feedbackRepo;

        public AdminFeedbackForm(IFeedbackRepo feedbackRepo, IFeedbackService feedbackService)
        {
            InitializeComponent();
            _feedbackRepo = feedbackRepo;
            _service = feedbackService;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvGorusOneri.SelectedCells[0].Value);        //INDEX!!!!!!
            var product = _service.Delete(id);

            MessageBox.Show("Ürün Başarıyla Silinmiştir");

            ListeyiYenile();
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

        private void AdminFeedbackForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dgvGorusOneri.DataSource = _feedbackRepo.GetFilteredList(select: x => new { x.Id, x.User.Email, x.Message }, where: x => x.State != State.Deleted);
            dgvGorusOneri.Columns[0].HeaderText = "Id";
            dgvGorusOneri.Columns[1].HeaderText = "Email";
            dgvGorusOneri.Columns[2].HeaderText = "Geri Bildirim Mesajı";
        }
    }
}
