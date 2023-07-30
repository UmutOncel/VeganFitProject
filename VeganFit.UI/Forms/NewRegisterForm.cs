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
        bool mov, isFirstname, isLastname, password1, password2, isEmail;
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
            ControlUserFirstnameAndLastname();
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

        /// <summary>
        /// Kullanıcının şifre kontrolünü sağlayan metottur.
        /// </summary>
        private void ControlUserPassword()
        {
            if (txtSifre.Text == txtSifreyiTekrarGirin.Text)
            {
                if (password1)
                {
                    CreateNewUser();
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz şifre belirlenen kriterlere uygun değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz şifrelerin aynı olması gerekir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///  Kullanıcının email kontrolünü sağlayan metottur.
        /// </summary>
        private void ControlUserEmail()
        {
            isEmail = TestEmailRegex(txtEMail.Text);
            if (isEmail)
            {
                var dbUserName = _userRepo.Any(x => x.Email == txtEMail.Text);
                if (!dbUserName)
                {

                    ControlUserPassword();
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz mail adresi sisteme kayıtlıdır. Kayıtlı mail adresi ile tekrar kayıt olamazsınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz mail adresi kriterlere uygun değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            + @"[a-zA-Z]{3,}))$";

            Regex reStrict = new Regex(patternStrict);
            bool isStrictMatch = reStrict.IsMatch(emailAddress);
            return isStrictMatch;
        }

        /// <summary>
        ///  Kullanıcının yaş kontrolünü sağlayan metottur.
        /// </summary>
        private void ControlUserAge()
        {
            int birthdate = dtpDogumTatihi.Value.Year;
            int minLimit = Convert.ToInt32(DateTime.Now.Year) - 64;
            int maxLimit = Convert.ToInt32(DateTime.Now.Year) - 45;

            if (minLimit <= birthdate && birthdate <= maxLimit)
            {
                ControlUserEmail();
            }
            else
            {
                MessageBox.Show("Yaşınız uygulamamızın hedef kitlesi dışındadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///  Kullanıcının ad soyad kontrolünü sağlayan metottur.
        /// </summary>
        private void ControlUserFirstnameAndLastname()
        {
            if (isFirstname && isLastname)
            {
                ControlUserAge();
            }
            else
            {
                MessageBox.Show("Lütfen ad soyad kısmına harf dışında karakter girmeyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAd__TextChanged(object sender, EventArgs e)
        {
            isFirstname = RegularEx(@"^[a-zA-ZüıöğşçĞÖÜİŞÇ]*$", txtAd);

            SetButtonState();
        }

        private void txtSoyad__TextChanged(object sender, EventArgs e)
        {
            isLastname = RegularEx(@"^[a-zA-ZüıöğşçĞÖÜİŞÇ]*$", txtSoyad);

            SetButtonState();
        }

        private void txtEMail__TextChanged(object sender, EventArgs e)
        {
            SetButtonState();
        }

        private void txtSifre__TextChanged(object sender, EventArgs e)
        {
            password1 = RegularEx("^(?=.*?[A-ZĞÖÜİŞÇ])(?=.*?[A-ZĞÖÜİŞÇ])(?=.*?[a-züıöğşç])(?=.*?[a-züıöğşç])(?=.*?[a-züıöğşç])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{4,}$", txtSifre);

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
            password2 = RegularEx("^(?=.*?[A-ZĞÖÜİŞÇ])(?=.*?[A-ZĞÖÜİŞÇ])(?=.*?[a-züıöğşç])(?=.*?[a-züıöğşç])(?=.*?[a-züıöğşç])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{4,}$", txtSifreyiTekrarGirin);

            SetButtonState();
        }

        /// <summary>
        /// Kayıt butonun aktiflik şartını içeren metottur.
        /// </summary>
        /// <param name="txtbox1"></param>
        /// <param name="txtbox2"></param>
        /// <param name="txtbox3"></param>
        /// <param name="txtbox4"></param>
        /// <param name="txtbox5"></param>
        private void EnableButton(DesignTextBox txtbox1, DesignTextBox txtbox2, DesignTextBox txtbox3, DesignTextBox txtbox4, DesignTextBox txtbox5)
        {
            if (txtbox1.Text.Length > 0 && txtbox2.Text.Length > 0 && txtbox3.Text.Length > 0 && txtbox4.Text.Length > 0 && txtbox5.Text.Length > 0)
            {
                btnKaydiTamamla.Enabled = true;
            }
            else
            {
                btnKaydiTamamla.Enabled = false;
            }
        }

        /// <summary>
        /// Kayıt butonunun aktiflik durumunu kontrol eden metottur.
        /// </summary>
        private void SetButtonState()
        {
            EnableButton(txtAd, txtSoyad, txtEMail, txtSifre, txtSifreyiTekrarGirin);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
