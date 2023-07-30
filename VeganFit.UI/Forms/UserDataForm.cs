using System.Data;
using VeganFit.Core.Enums;
using VeganFit.DAL.Abstract;
using VeganFit.DAL.Concrete.Context;
using VeganFit.Entities;
using VeganFit.UI.LoginUser;

namespace VeganFit.UI
{
    public partial class UserDataForm : Form
    {
        VeganFitDbContext db = new VeganFitDbContext();
        private readonly IWeightRepo _weightRepo;

        public UserDataForm(IWeightRepo weightRepo)
        {
            InitializeComponent();

            _weightRepo = weightRepo;
        }

        private void UserDataForm_Load(object sender, EventArgs e)
        {
            DailyWeightTracking(dgvGunlukKiloTakibi);

            DataGridViewColumnNames(dgvGunlukKiloTakibi);

            EndOfDayTotalCaloriesList(dgvGunSonuKalori);

            ChartDatas();
        }
        private void DailyWeightTracking(DataGridView dataGrid)
        {
            dataGrid.DataSource = _weightRepo.GetFilteredList(select: x => new { x.UserName, x.UserWeight, x.RecordDate }, where: x => x.UserName == ActiveUser.ActiveUserFirstName);
        }
        private void EndOfDayTotalCaloriesList(DataGridView dataGrid)
        {
            dataGrid.DataSource = db.Datas.Where(x => x.UserEmail == ActiveUser.ActiveUserName && x.State != State.Deleted)
                .GroupBy(x => new { x.UserEmail, x.Datetime })
                .Select(x => new
                {
                    Tarih = x.Key.Datetime,
                    ToplamKalori = x.Sum(x => x.Calori)
                }).ToList();
        }
        private void DataGridViewColumnNames(DataGridView dataGrid)
        {
            dataGrid.Columns[0].HeaderText = "İsim";
            dataGrid.Columns[1].HeaderText = "Kilo";
            dataGrid.Columns[2].HeaderText = "Kayıt Tarihi";
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

        /// <summary>
        /// Chart grafiklere veri girilmesini sağlayan metot.
        /// </summary>
        private void ChartDatas()//BURAYA BİR HATA AYIKLAYICI LAZIM
        {
            for (int i = 0; i < dgvGunSonuKalori.Rows.Count; i++)
            {
                chartCalori.Series["Kalori"].Points.AddXY(dgvGunSonuKalori.Rows[i].Cells[0].Value.ToString(), Convert.ToDouble(dgvGunSonuKalori.Rows[i].Cells[1].Value.ToString()));
            }
            for (int i = 0; i < dgvGunlukKiloTakibi.Rows.Count; i++)
            {
                chartWeight.Series["Kilo"].Points.AddXY(dgvGunlukKiloTakibi.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(dgvGunlukKiloTakibi.Rows[i].Cells[1].Value.ToString()));
            }
        }
    }
}
