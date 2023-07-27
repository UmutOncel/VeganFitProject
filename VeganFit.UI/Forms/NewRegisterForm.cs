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
        bool mov, ad, soyad;
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
            int dogumtarihi = dtpDogumTatihi.Value.Year;
            int altSinir = Convert.ToInt32(DateTime.Now.Year) - 64;
            int ustSinir = Convert.ToInt32(DateTime.Now.Year) - 45;


            if (ad && soyad)
            {
                if (altSinir <= dogumtarihi && dogumtarihi <= ustSinir)
                {
                    var dbKullaniciAdi = _userRepo.Any(x => x.Email == txtEMail.Text);
                    if (txtEMail.Text != string.Empty && !dbKullaniciAdi)
                    {
                        if (txtSifre.Text == txtSifreyiTekrarGirin.Text)
                        {
                            string sifre = PasswordHassing.Sha256Hash(txtSifre.Text);
                            CreateVm createVm = new CreateVm()
                            {
                                FirstName = txtAd.Text,
                                LastName = txtSoyad.Text,
                                Email = txtEMail.Text,
                                BirthDate = dtpDogumTatihi.Value,
                                Password = sifre,
                                PasswordConfirm = txtSifreyiTekrarGirin.Text
                            };

                            var exist = _userService.Create(createVm);

                            if (exist != null)
                            {
                                MessageBox.Show("Başarıyla Kayıt Oluşturuldu.");
                                this.Close();
                                var loginForm = EFContextForm.EFContextForm.ConfigureServices<LoginForm>();
                                loginForm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girmiş olduğunuz şifrelerin aynı olması gerekir.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girmiş olduğunuz mail adresi sisteme kayıtlı veya boş olabilir.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Yaşınız uygulamamızın hedef kitlesi dışındadır.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad kısmına harf dışında karakter girmeyiniz.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSifre__TextChanged(object sender, EventArgs e)
        {
            RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{4,}$", txtSifre);
        }

        public bool RegularEx(string rgx, DesignTextBox txtb)
        {
            bool control = false;
            Regex regex = new Regex(rgx);
            Match match = regex.Match(txtb.Text);
            if (match.Success)
            {
                btnKaydiTamamla.Enabled = true;
                control = true;
            }
            else
            {
                btnKaydiTamamla.Enabled = false;
                control = false;
            }
            return control;

        }

        private void txtSifreyiTekrarGirin__TextChanged(object sender, EventArgs e)
        {
            RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{4,}$", txtSifreyiTekrarGirin);
        }

        private void txtAd__TextChanged(object sender, EventArgs e)
        {
            ad = RegularEx(@"^[a-zA-Z]*$", txtAd);
        }

        private void txtSoyad__TextChanged(object sender, EventArgs e)
        {
            soyad = RegularEx(@"^[a-zA-Z]*$", txtSoyad);
        }
    }
}
