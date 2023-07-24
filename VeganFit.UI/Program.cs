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

            Application.Run(new AdminMainForm());
        }
    }
}