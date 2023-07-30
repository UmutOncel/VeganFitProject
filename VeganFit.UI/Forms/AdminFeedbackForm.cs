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
using VeganFit.UI.LoginUser;

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
            try
            {
                int id = Convert.ToInt32(dgvGorusOneri.SelectedCells[0].Value);
                var product = _service.Delete(id);

                MessageBox.Show("Geribildirim başarıyla silinmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Geribildirimi silmek için önce listeden bir geribildirim seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void AdminFeedbackForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        /// <summary>
        /// İşlemler sonucunda listeyi otomatik yenileyip verilerin ekrana gelmesini sağlayan metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshList()
        {

            dgvGorusOneri.DataSource = _feedbackRepo.GetFilteredList(select: x => new {x.UserName, x.Message }, where: x => x.State != State.Deleted );

            dgvGorusOneri.Columns[0].HeaderText = "Email";
            dgvGorusOneri.Columns[1].HeaderText = "Geri Bildirim Mesajı";
        }

        private void dgvGorusOneri_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
