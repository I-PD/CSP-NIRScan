using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ISC_Win_WinForm_GUI
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //MessageBox.Show(
            //    "EXE: " + Application.ExecutablePath + "\n" +
            //    "CFG: " + System.Configuration.ConfigurationManager
            //              .OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None).FilePath + "\n\n" +
            //    "ApiPythonExe=" + (System.Configuration.ConfigurationManager.AppSettings["ApiPythonExe"] ?? "<null>") + "\n" +
            //    "ApiWorkingDir=" + (System.Configuration.ConfigurationManager.AppSettings["ApiWorkingDir"] ?? "<null>"),
            //    "DEBUG"
            //);

            // força ponto decimal por defeito
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ApplicationExit += (_, __) => ApiBootstrap.StopApiIfStartedByUs();

            // Fluxo certo: Bootstrap (arranca/espera API) -> Login -> Main
            Application.Run(new BootstrapForm(args));

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //// Exibir o LoginForm
            //var loginForm = new LoginForm();
            //if (loginForm.ShowDialog() != DialogResult.OK)
            //    return;  // Sai se cancelar

            ////Se login OK, passa o token para a MainWindow
            //Application.Run(new MainWindow(args, TokenManager.JwtToken,loginForm.Username));
        }
    }   
}
