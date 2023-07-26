using VeganFit.Bll.Abstract.IServices;
using VeganFit.UI.EFContextForm;

namespace VeganFit.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var form = EFContextForm.EFContextForm.ConfigureServices<LoginForm>();
            var form1 = EFContextForm.EFContextForm.ConfigureServices<AdminAddProduct>();
            var form2 = EFContextForm.EFContextForm.ConfigureServices<UserDataForm>();
            var form3 = EFContextForm.EFContextForm.ConfigureServices<UserSetProductForm>();
            var form4 = EFContextForm.EFContextForm.ConfigureServices<UserAddMealForm>();
            var form5 = EFContextForm.EFContextForm.ConfigureServices<UserFeedbackForm>();
            var form6 = EFContextForm.EFContextForm.ConfigureServices<AdminFeedbackForm>();
            var form7 = EFContextForm.EFContextForm.ConfigureServices<NewRegisterForm>();
            var form8 = EFContextForm.EFContextForm.ConfigureServices<UserAddWeigthForm>();
            var form9 = EFContextForm.EFContextForm.ConfigureServices<UserAddNewProductForm>();
            var form10 = EFContextForm.EFContextForm.ConfigureServices<UserFeedbackForm>();


            Application.Run(form8);
        }
    }
}