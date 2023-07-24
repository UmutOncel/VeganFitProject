using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeganFit.UI
{
    public partial class AdminFeedbackForm : Form
    {
        public AdminFeedbackForm()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Başarıyla Silinmiştir");
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
    }
}
