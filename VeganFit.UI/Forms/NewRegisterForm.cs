using System.Drawing.Printing;
using System.Text.RegularExpressions;
using TextBoxs.TextBox;
using VeganFit.Bll.Abstract.IServices;
using VeganFit.DAL.Abstract;
using VeganFit.Models.VMs.UserVms;
using VeganFit.UI.UserOperation;

namespace VeganFit.UI
{
    public partial class NewRegisterForm : Form
    {
        bool mov, isFirstname, isLastname, password1, password2, isEmail, dbUserName, isBirthdate;
        int movX, movY;
        private readonly IUserService _userService;
        private readonly IUserRepo _userRepo;

        public NewRegisterForm(IUserService userService, IUserRepo userRepo)
        {
            InitializeComponent();
            _userService = userService;
            _userRepo = userRepo;
        }

        private void pnlNewRegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlNewRegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void pnlNewRegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            lblKapat.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.Visible = false;
        }

        private void btnKaydiTamamla_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        /// <summary>
        /// Yeni kullanıcı yaratan metottur.
        /// </summary>
        private void CreateNewUser()
        {
            string password = PasswordHassing.Sha256Hash(txtSifre.Text);
            CreateVm createVm = new CreateVm()
            {
                FirstName = txtAd.Text,
                LastName = txtSoyad.Text,
                Email = txtEMail.Text,
                BirthDate = dtpDogumTatihi.Value,
                Password = password,
                PasswordConfirm = txtSifreyiTekrarGirin.Text
            };

            var exist = _userService.Create(createVm);

            if (exist != null)
            {
                MessageBox.Show("Başarıyla kayıt oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                var loginForm = EFContextForm.EFContextForm.ConfigureServices<LoginForm>();
                loginForm.ShowDialog();
            }
        }

        private void txtAd__TextChanged(object sender, EventArgs e)
        {
            string firstname = txtAd.Text;
            isFirstname = ControlIsLetter(firstname);
            if (!isFirstname)
            {
                MessageBox.Show("Adınızı yazarken sadece harf kullanınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SetButtonState();
        }

        private void txtSoyad__TextChanged(object sender, EventArgs e)
        {
            string lastname = txtSoyad.Text;
            isLastname = ControlIsLetter(lastname);
            if (!isLastname)
            {
                MessageBox.Show("Soyadınızı yazarken sadece harf kullanınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SetButtonState();
        }

        /// <summary>
        /// Parametredeki string ifadenin tamamen harf içerip içermediğini kontrol eden ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool ControlIsLetter(string str)
        {
            return str.All(Char.IsLetter);
        }

        private void dtpDogumTatihi_ValueChanged(object sender, EventArgs e)
        {
            int birthdate = dtpDogumTatihi.Value.Year;
            int minLimit = Convert.ToInt32(DateTime.Now.Year) - 64;
            int maxLimit = Convert.ToInt32(DateTime.Now.Year) - 45;
            isBirthdate = (minLimit >= birthdate && birthdate >= maxLimit);

            if (!isBirthdate)
            {
                MessageBox.Show("Yaşınız uygulamamızın hedef kitlesi dışındadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEMail__TextChanged(object sender, EventArgs e)
        {
            string email = txtEMail.Text;
            isEmail = TestEmailRegex(email);
            if (!isEmail)
            {
                MessageBox.Show("Girmiş olduğunuz mail adresi geçerli değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbUserName = _userRepo.Any(x => x.Email == txtEMail.Text);
                if (dbUserName)
                {
                    MessageBox.Show("Girmiş olduğunuz mail adresi sisteme kayıtlıdır. Kayıtlı mail adresi ile tekrar kayıt olamazsınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            SetButtonState();
        }

        /// <summary>
        /// Parametre olarak girilen mail'i kontrol eden ve sonucu boolean olarak döndüren metot.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        public bool TestEmailRegex(string emailAddress)
        {
            string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
            + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
            + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
            + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
            + @"[a-zA-Z]{2,}))$";

            Regex reStrict = new Regex(patternStrict);
            bool isStrictMatch = reStrict.IsMatch(emailAddress);
            return isStrictMatch;
        }

        private void txtSifre__TextChanged(object sender, EventArgs e)
        {
            password1 = RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{4,}$", txtSifre);
            if (!password1)
            {
                MessageBox.Show("Girmiş olduğunuz şifre belirlenen kriterlere uygun değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SetButtonState();
        }

        /// <summary>
        /// Kayıt esnasında şartları eşleştirip kontrolünü sağlayan metottur.
        /// </summary>
        /// <param name="rgx"></param>
        /// <param name="txtb"></param>
        /// <returns></returns>
        public bool RegularEx(string rgx, DesignTextBox txtb)
        {
            bool control = false;
            Regex regex = new Regex(rgx);
            Match match = regex.Match(txtb.Text);
            if (match.Success)
            {
                control = true;
            }
            else
            {
                control = false;
            }
            return control;
        }

        private void txtSifreyiTekrarGirin__TextChanged(object sender, EventArgs e)
        {
            password2 = RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{4,}$", txtSifreyiTekrarGirin);
            if (txtSifre.Text != txtSifreyiTekrarGirin.Text)
            {
                MessageBox.Show("Tekrar yazmış olduğunuz şifre ilk yazılanla aynı olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SetButtonState();
        }

        /// <summary>
        /// Kayıt butonunun aktiflik durumunu kontrol eden metottur.
        /// </summary>
        private void SetButtonState()
        {
            if (isFirstname && isLastname && isBirthdate && isEmail && dbUserName && password1 && password2)
            {
                btnKaydiTamamla.Enabled = true;
            }
            else
            {
                btnKaydiTamamla.Enabled = false;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
