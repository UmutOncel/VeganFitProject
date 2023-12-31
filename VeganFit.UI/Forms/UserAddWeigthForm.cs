﻿using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Models.VMs.WeightVms;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserAddWeigthForm : Form
    {
        private readonly IWeightService _service;
        private readonly IWeightRepo _weightRepo;

        public UserAddWeigthForm(IWeightService weightService, IWeightRepo weightRepo)
        {
            InitializeComponent();

            _service = weightService;
            _weightRepo = weightRepo;
        }

        private void UserAddWeigthForm_Load(object sender, EventArgs e)
        {
            DisplayOfDailyDateinLabel();
            RefreshList(dgvGunlukKiloTakibi);
        }

        /// <summary>
        /// Günün tarihini label'da gösteren metot.
        /// </summary>
        private void DisplayOfDailyDateinLabel()
        {
            lblDateToday.Text = DateTime.Today.ToShortDateString();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string strWeight = txtKilo.Text;
            double weight;
            bool isDouble = double.TryParse(strWeight, out weight);
            bool isDot = strWeight.Contains('.');
            if (!isDouble || isDot)
            {
                MessageBox.Show("Kilonuzu sadece tam sayı veya ondalıklı sayı olarak girebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (weight > 0)
                {
                    AddWeight();
                }
                else
                {
                    MessageBox.Show("Kilo değeriniz sıfıra eşit veya sıfırdan küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Kullanıcının kilosunu şarta bağlı database'e ekleyen, şart sağlanmıyorsa uyarı veren metot.
        /// </summary>
        private void AddWeight()
        {
            bool isExist = _weightRepo.Any(x => x.RecordDate == Convert.ToDateTime(lblDateToday.Text) && x.UserName == ActiveUser.ActiveUserFirstName);
            if (!isExist)
            {
                WeightCreateVm vm = new WeightCreateVm()
                {
                    UserWeight = Convert.ToDouble(txtKilo.Text),
                    UserName = ActiveUser.ActiveUserFirstName
                };
                _service.Create(vm);
                MessageBox.Show("Kilonuz başarıyla kaydedilmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList(dgvGunlukKiloTakibi);
            }
            else
            {
                MessageBox.Show("Seçilen tarihte kaydınız bulunmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Listeyi yenilemeye yarayan metottur.
        /// </summary>
        private void RefreshList(DataGridView dataGrid)
        {
            dataGrid.DataSource = _weightRepo.GetFilteredList(select: x => new { x.RecordDate, x.UserWeight, x.UserName }, where: x => x.UserName == ActiveUser.ActiveUserFirstName);

            dataGrid.Columns[0].HeaderText = "Kayıt Tarihi";
            dataGrid.Columns[1].HeaderText = "Kilonuz";
            dataGrid.Columns[2].HeaderText = "İsim";
        }

        private void txtKilo__TextChanged(object sender, EventArgs e)
        {
            if (txtKilo.Text.Length > 0)
            {
                btnKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;
            }
        }
    }
}
